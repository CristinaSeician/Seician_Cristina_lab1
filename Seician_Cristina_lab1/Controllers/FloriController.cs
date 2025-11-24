using Microsoft.AspNetCore.Mvc;

namespace Seician_Cristina_lab1.Controllers
{
    public class FloriController : Controller
    {
        public string Index()
        {
            return "Bun venit Cristina!";
        }
        public string Salut()
        {
            return "Salutare Cristina!";
        }
        public string CateFlori(int cantitate, string nume)
        {
            return $"Avem {cantitate} de {nume} in stoc";
        }
    }
}
