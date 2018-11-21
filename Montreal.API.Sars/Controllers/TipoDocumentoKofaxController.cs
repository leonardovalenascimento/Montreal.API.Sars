using Microsoft.AspNetCore.Mvc;
using Montreal.API.Sars.Models;
using System.Threading.Tasks;

namespace Montreal.API.Sars.Controllers
{
    [Route("api/TipoDocumentoKofax")]
    public class TipoDocumentoKofaxController : Controller

    {

        private DataContext db = new DataContext();

        [Produces("application/json")]
        [HttpGet("findAll")]
        public async Task<IActionResult> findAll()
        {
            try
            {
                var TipoDocumentoKofax = db.TipoDocumentoKofax.ToString();
                return Ok(TipoDocumentoKofax);
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}