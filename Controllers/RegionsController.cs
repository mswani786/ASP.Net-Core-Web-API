using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        private readonly NZWalksDbContext dbContext;

        public RegionsController(NZWalksDbContext dbContext )
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {
            //var regions = new List<Region>
            //{
            //new Region
            //{
            //Id= Guid.NewGuid(),
            //Name = "Auckland Region",
            //Code = "AKL",
            //RegionImageUrl = ""
            //},
            //new Region
            //{
            //Id= Guid.NewGuid(),
            //Name = "Wellington Region",
            //Code = "WLG",
            //RegionImageUrl = ""
            //}
            //};
            var regions = dbContext.Regions.ToList();
            return Ok(regions);
        }
    }
}
