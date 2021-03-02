using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampApı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        public ActionResult<CampData.AuthorData> GetById(int entityID)
        {
            CampService.AuthorService authorServices = new CampService.AuthorService();
            var data = authorServices.GetById(entityID);
            if (data != null) return Ok(data);
            return NotFound("Beklenmedik bir hata oluştu. Lütfen daha sonra tekrar deneyiniz!");
        }

      
    }
}
