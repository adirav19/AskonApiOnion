using dbfirstTest.Application.Repositories;
using dbfirstTest.Domain.Entities;
using dbfirstTest.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dbfirstTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakineController : ControllerBase   
    {

        //private readonly IGunlukMakineReadRepository _makineReadRepository;
        private readonly IOpcVardiyaReadRepository opcVardiyaReadRepository;
        private readonly IGunlukMakineReadRepository gunlukMakineReadRepoasitory;

        public MakineController( IOpcVardiyaReadRepository opcVardiyaReadRepository,IGunlukMakineReadRepository gunlukMakineReadRepository)
        {
            this.gunlukMakineReadRepoasitory = gunlukMakineReadRepository; 
            this.opcVardiyaReadRepository = opcVardiyaReadRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetVardiya()
        {
            
            return Ok(gunlukMakineReadRepoasitory.GetAll(false));
        }
        
        

        
        //[HttpGet]
        //public async Task<IActionResult> GetMakine()
        //{

        //    return Ok(gunlukMakineReadRepoasitory.GetAll());
        //}


    }
}



