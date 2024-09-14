using EticaretServer.Application.Repositories.Customers;
using EticaretServer.Application.Repositories.Orders;
using EticaretServer.Application.Repositories.Products;
using EticaretServer.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EticaretServer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;
        readonly private IOrderWriteRepository _orderWriteRepository;

        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository; 
        }

        [HttpGet]
        public async Task Get()
        {
            var Customerıd = Guid.NewGuid();
           
            await _customerWriteRepository.AddAsyc(new() { Id= Customerıd, Name="Arda" });

            await _orderWriteRepository.AddAsyc(new() { Address = "6440/5 sk. İzmir", Description = "Lütfen Çabuk Gelsin", CustomerID = Customerıd });
            await _orderWriteRepository.AddAsyc(new() { Address = "6399 sk. İzmir", Description = "Lütfen Gelince Zile Basmayın", CustomerID =Customerıd});


            await _orderWriteRepository.SaveAsync();
        }
       
    }
}
