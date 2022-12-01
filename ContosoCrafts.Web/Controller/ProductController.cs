using ContosoCrafts.Web.Models;
using ContosoCrafts.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCrafts.Web.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController(JsonFileProductService productService)
        {
            this.ProductService = productService;


        }
        public JsonFileProductService ProductService { get; }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }


    }
}
