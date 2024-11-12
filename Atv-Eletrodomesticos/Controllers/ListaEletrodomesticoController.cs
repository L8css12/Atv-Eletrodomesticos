using Atv_Eletrodomesticos.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atv_Eletrodomesticos.Controllers
{
    public class ListaEletrodomesticoController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico> eletrodomesticos = new List<Eletrodomestico>
            {
                new Geladeira {Marca = "Samsung", Modelo = "Duplex RT42", ConsumoEnergetico = 5, CapacidadeLitros = 400, TemFreezer = true },
                new Televisor {Marca = "TCL", Modelo = "75P755", ConsumoEnergetico = 10, EhSmart = true, TamanhoTela = 75 },
                new Televisor {Marca = "LG", Modelo = "75P7", ConsumoEnergetico = 15, EhSmart = true, TamanhoTela = 75 },

            };

            return View(eletrodomesticos);
        }
    }
}
