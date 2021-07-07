using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebshopApi.Models;

namespace WebshopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebshopItemsController : ControllerBase
    {
        private readonly WebshopContext _context;

        public WebshopItemsController(WebshopContext context)
        {
            _context = context;
        }

        // GET: api/WebshopItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<WebshopItem>>> GetWebshopItems()
        {
            return await _context.WebshopItems.ToListAsync();
        }

        // GET: api/WebshopItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WebshopItem>> GetWebshopItem(long id)
        {
            var WebshopItem = await _context.WebshopItems.FindAsync(id);

            if (WebshopItem == null)
            {
                return NotFound();
            }

            return WebshopItem;
        }

        // GET: api/WebshopItems/productimages/1
        [HttpGet("productimages/{id}")]
        
        public async Task<ActionResult<WebshopItem>> GetProductImage(long id)
        {       
            var WebshopItem = await _context.WebshopItems.FindAsync(id);
            Byte[] b = System.IO.File.ReadAllBytes(@"C:\dev\webshop\WebshopApi\db_productimages\ws_" + WebshopItem.Id + ".jpg");        
            return File(b, "image/jpeg");
        }

        // PUT: api/WebshopItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWebshopItem(long id, WebshopItem WebshopItem)
        {
            if (id != WebshopItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(WebshopItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WebshopItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/WebshopItems
        [HttpPost]
        public async Task<ActionResult<WebshopItem>> PostWebshopItem(WebshopItem WebshopItem)
        {
            _context.WebshopItems.Add(WebshopItem);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetWebshopItem", new { id = WebshopItem.Id }, WebshopItem);
            return CreatedAtAction(nameof(GetWebshopItem), new { id = WebshopItem.Id }, WebshopItem);
        }

        // DELETE: api/WebshopItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWebshopItem(long id)
        {
            var WebshopItem = await _context.WebshopItems.FindAsync(id);
            if (WebshopItem == null)
            {
                return NotFound();
            }

            _context.WebshopItems.Remove(WebshopItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WebshopItemExists(long id)
        {
            return _context.WebshopItems.Any(e => e.Id == id);
        }
    }
}
