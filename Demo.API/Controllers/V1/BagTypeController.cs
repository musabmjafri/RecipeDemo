using Demo.Core.DTO;
using Demo.Core.Entity;
using Demo.Core.Interface.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recipe.NetCore.Helper;
using Recipe.NetCore.Infrastructure;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.API.Controllers
{
    [ApiVersion("1")]
    [Route("[controller]")]
    public class BagTypeController : BaseController
    {
        private readonly IBagTypeService service;

        public BagTypeController(IBagTypeService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => JsonResponse(await service.GetAllAsync(QueryHelper.Get<BagType>(HttpContext.Request.Query, new List<string>())));

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id) => JsonResponse(await service.GetAsync(id));

        [HttpPost]
        public async Task<IActionResult> Create([FromBody]BagTypeDto dto) => JsonResponse(await service.CreateAsync(dto));

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]BagTypeDto dto) => JsonResponse(await service.UpdateAsync(dto));

        [HttpDelete("{id}")]
        public async Task Delete([FromRoute] int id) => await service.DeleteAsync(id); 
    }
}