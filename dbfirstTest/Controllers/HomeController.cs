
using dbfirstTest.Application.Repositories;
using dbfirstTest.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dbfirstTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        
        private readonly IGunlukMakineReadRepository _makineReadRepository;

        

        public ProductsController( IGunlukMakineReadRepository makineReadRepository, 
            this.orderWriteRepository = orderWriteRepository;
            this.orderReadRepository = orderReadRepository;
            this.customerWriteRepository = customerWriteRepository;
            t
        }
        [HttpGet]
        public async Task get()
        {
            Order order = await orderReadRepository.GetByIdAsync("f7400daa-5e83-4db8-9f2c-f9f39b516bb9");
            order.Address = "ist";
            await orderWriteRepository.SaveAsync();
        }
    }
}