using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces.Repository;

namespace ProductApp.WebApi.Controllers
{
    /// <summary>
    /// Burası sadece eline geçen veriyi döndürmek için kullanılır.
    /// Conversion işlemlerini yapılmaması gerekiyor.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }    
     
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // Controller içerisinden domain'e erişim oluyor ki bu istenmeyen bir durum
            var allList = await _productRepository.GellAllAsync();

            var result = allList.Select(x => new ProductViewDto
            {
                Id = x.Id,
                Name = x.Name               
            }).ToList();

            return Ok(result); // bu conversion işlemini controller içerisinde yapmamalıyız
        }
    }
}
