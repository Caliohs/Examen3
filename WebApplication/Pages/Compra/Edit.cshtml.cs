using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using WebApplication;

namespace WebApp.Pages.Compra
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


        public CompraEntity Entity { get; set; } = new CompraEntity();


        public IEnumerable<ClientesEntity> ClienteLista { get; set; } = new List<ClientesEntity>();

        public IEnumerable<ProductoEntity> ProductoLista { get; set; } = new List<ProductoEntity>();




        public async Task<IActionResult> OnGet()
        {
            try
            {
                if (!this.SessionOnline()) return RedirectToPage("../Login");
                if (id.HasValue)
                {
                    Entity = await service.CompraGetById(id.Value);
                }


                ClienteLista = await service.ClientesGetLista();

                ProductoLista = await service.ProductoGetLista();

                return Page();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
    }
}
