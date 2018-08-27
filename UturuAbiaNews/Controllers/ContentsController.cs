using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting; 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UturuAbiaNews.Data;
using UturuAbiaNews.Models;

namespace UturuAbiaNews.Controllers
{
	public class ContentCreateViewModel : Content
	{
		public IFormFile Url { get; set; }
	}
    public class ContentsController : Controller
    {
		private IHostingEnvironment _env;
        private readonly ApplicationDbContext _context;

        public ContentsController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            _context = context;
			_env = environment;
        }

        // GET: Contents
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Content.Include(c => c.Category);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Contents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var content = await _context.Content
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (content == null)
            {
                return NotFound();
            }

            return View(content);
        }

        // GET: Contents/Create
        public IActionResult Create()
        {
			ContentCreateViewModel content = new ContentCreateViewModel();
            ViewData["CategoryID"] = new SelectList(_context.Category, "ID", "CategoryName");
            return View(content);
        }

        // POST: Contents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ContentTitle,ShortDescription,Url,LongDescription,NoOfLikes,IsEdited,IsHeadline,DatePublished,DateEdited,CategoryID")] ContentCreateViewModel contentView)
        {
			Content content = new Content();
			if (ModelState.IsValid)
            {
				
				IFormFile file = contentView.Url;
				string relativePath = "";
				if (file != null)
				{
					var fileName = $"{contentView.ID}{Path.GetFileName(file.FileName)}";
					relativePath = Path.Combine("images", fileName);
					var absolutePath = Path.Combine(_env.WebRootPath, relativePath);

					using (FileStream stream = new FileStream(absolutePath, FileMode.Create))
					{
						file.CopyTo(stream);
					}

				}

				content = new Content
				{
					ID = contentView.ID,
					ContentTitle = contentView.ContentTitle,
					ShortDescription = contentView.ShortDescription,
					ImageUrl = relativePath,
					LongDescription = contentView.LongDescription,
					NoOfLikes = contentView.NoOfLikes,
					IsEdited = contentView.IsEdited,
					IsHeadline = contentView.IsHeadline,
					DatePublished = DateTime.Now,
					DateEdited = DateTime.Now,
					CategoryID = contentView.CategoryID
				};
				

                _context.Add(content);
				
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "ID", "CategoryName", content.CategoryID);
            return View(content);
        }

        // GET: Contents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var content = await _context.Content.FindAsync(id);
            if (content == null)
            {
                return NotFound();
            }
			ContentCreateViewModel realContent = new ContentCreateViewModel { Category = content.Category, CategoryID = content.CategoryID, ContentTitle = content.ContentTitle, DateEdited = content.DateEdited, DatePublished = content.DatePublished,
																			  ID = content.ID, ImageUrl = content.ImageUrl, IsEdited = content.IsEdited, IsHeadline = content.IsHeadline, LongDescription = content.LongDescription,
																			  NoOfLikes = content.NoOfLikes, ShortDescription = content.ShortDescription };
            ViewData["CategoryID"] = new SelectList(_context.Category, "ID", "CategoryName", content.CategoryID);
            return View(realContent);
        }

        // POST: Contents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ContentTitle,ShortDescription,Url,LongDescription,NoOfLikes,IsEdited,IsHeadline,DatePublished,DateEdited,CategoryID,ImageUrl")] ContentCreateViewModel contentView)
        {
			Content content = new Content();
            if (id != contentView.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
				IFormFile file = contentView.Url;
				string relativePath = "";
				if (file != null)
				{
					if (contentView.ImageUrl != null)
					{
						var oldPath = Path.Combine(_env.WebRootPath, contentView.ImageUrl);
						if (System.IO.File.Exists(oldPath))
						{
							System.IO.File.Delete(oldPath);
						}
					}
					
					var fileName = $"{contentView.ID}{Path.GetFileName(file.FileName)}";
					relativePath = Path.Combine("images", fileName);
					var absolutePath = Path.Combine(_env.WebRootPath, relativePath);

					using (FileStream stream = new FileStream(absolutePath, FileMode.Create))
					{
						file.CopyTo(stream);
					}

				}
				content = new Content
				{
					ID = contentView.ID,
					ContentTitle = contentView.ContentTitle,
					ShortDescription = contentView.ShortDescription,
					ImageUrl = (!string.IsNullOrEmpty(relativePath)) ? relativePath : contentView.ImageUrl,
					LongDescription = contentView.LongDescription,
					NoOfLikes = contentView.NoOfLikes,
					IsEdited = contentView.IsEdited,
					IsHeadline = contentView.IsHeadline,
					DatePublished = contentView.DatePublished,
					DateEdited = DateTime.Now,
					CategoryID = contentView.CategoryID
				};
				try
                {
                    _context.Update(content);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContentExists(content.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Category, "ID", "ID", content.CategoryID);
            return View(content);
        }

        // GET: Contents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var content = await _context.Content
                .Include(c => c.Category)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (content == null)
            {
                return NotFound();
            }

            return View(content);
        }

        // POST: Contents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var content = await _context.Content.FindAsync(id);

			var oldPath = Path.Combine(_env.WebRootPath, content.ImageUrl);
			if (System.IO.File.Exists(oldPath))
			{
				System.IO.File.Delete(oldPath);
			}
			_context.Content.Remove(content);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContentExists(int id)
        {
            return _context.Content.Any(e => e.ID == id);
        }
    }
}
