using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;

namespace WebApplication.Pages.Producto
{ 
    public class EditModel : PageModel
    {
        private readonly ServiceApi service;

        public EditModel(ServiceApi service)
        {
            this.service = service;
        }

        [BindProperty(SupportsGet = true)]
        public int? id { get; set; }

        [BindProperty]
        [FromBody]
        public ProductoEntity Entity { get; set; } = new ProductoEntity();


        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (!this.SessionOnline()) return RedirectToPage("../Login");
                if (id.HasValue)
                {
                    Entity = await service.ProductoGetById(id.Value);
                }

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

        //public async Task<IActionResult> OnPost()
        //{
        //    try
        //    {

        //        var result = new DBEntity();
        //        if (Entity.ProductoId.HasValue)
        //        {
        //            //Actualizar
        //            result = await productoService.Update(Entity);


        //        }
        //        else
        //        {
        //            //Nuevo
        //            result = await productoService.Create(Entity);


        //        }

        //        return new JsonResult(result);


        //    }
        //    catch (Exception ex)
        //    {

        //        return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
        //    }



       // }
    }
}
