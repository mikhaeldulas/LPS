using LPSWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LPSWeb.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string? Search)
        {
            var prdct = _context.ProductsModels.FromSqlInterpolated($"[dbo].[Search_Data] {Search}").ToListAsync();
            return View(await prdct);
            //return View(await _context.ProductsModels.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productModel = await _context.ProductsModels
                .FirstOrDefaultAsync(m => m.id == id);

            if (productModel == null)
            {
                return NotFound();
            }

            return View(productModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("nama_barang,kode_barang,jumlah_barang,tanggal")] ProductsModel productModel)
        {
            if (ModelState.IsValid)
            {
                var insrt = _context.Database.ExecuteSqlInterpolatedAsync(
                    $"[dbo].[Insert_Data] @nama_barang={productModel.nama_barang},@kode_barang={productModel.kode_barang},@jumlah_barang={productModel.jumlah_barang},@tanggal={productModel.tanggal}");

                await insrt;
                return RedirectToAction(nameof(Index));
            }
            return View(productModel);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productModel = await _context.ProductsModels.FindAsync(id);
            if (productModel == null)
            {
                return NotFound();
            }
            return View(productModel);
        }

        // POST: Role/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,nama_barang,kode_barang,jumlah_barang,tanggal")] ProductsModel productModel)
        {
            if (id != productModel.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //_context.Update(productModel);
                    //await _context.SaveChangesAsync();
                    var update_ = _context.Database.ExecuteSqlInterpolatedAsync(
                    $"[dbo].[Update_Data]  @id={productModel.id},@nama_barang={productModel.nama_barang},@kode_barang={productModel.kode_barang},@jumlah_barang={productModel.jumlah_barang},@tanggal={productModel.tanggal}");
                    //_context.Add(productModel);

                    //await _context.SaveChangesAsync();
                    await update_;
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductModelExists(productModel.id))
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
            return View(productModel);
        }

        // GET: Role/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleModel = await _context.ProductsModels
                .FirstOrDefaultAsync(m => m.id == id);
            if (roleModel == null)
            {
                return NotFound();
            }

            return View(roleModel);
        }

        // POST: Role/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var delete_ = _context.Database.ExecuteSqlInterpolatedAsync(
                  $"[dbo].[Delete_Data] @id={id}");
            await delete_;
            return RedirectToAction(nameof(Index));
        }

        private bool ProductModelExists(int id)
        {
            return _context.ProductsModels.Any(e => e.id == id);
        }

    }
}
