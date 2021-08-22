using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;

namespace WebApplication.Pages.Producto
{
    public class GridModel : PageModel
    {
        private readonly ServiceApi service;

        public GridModel(ServiceApi service)
        {
            this.service = service;
        }


        public IEnumerable<ProductoEntity> GridList { get; set; } = new List<ProductoEntity>();
        public async Task<IActionResult> OnGet()
        {
            try
            {
                GridList = await service.ProductoGet();


                return Page();


            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

       
    }
}
