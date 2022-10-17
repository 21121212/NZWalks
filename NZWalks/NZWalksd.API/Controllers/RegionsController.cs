using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalksd.API.Models.Domain;
using NZWalksd.API.Repository;

namespace NZWalksd.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;

        public RegionsController(IRegionRepository regionRepository,IMapper mapper )
        {
            this._regionRepository = regionRepository;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            var regions =  await _regionRepository.GetAllAsync();

             /* //return DTO regions
            var regionsDTO = new List<Models.DTO.Region>();
            regions.ToList().ForEach(region =>
            {
                var regionDTO = new Models.DTO.Region()
                {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    Area = region.Area,
                    Lat = region.Lat,
                    Long = region.Long,
                    Population = region.Population,

                };

                regionsDTO.Add(regionDTO);
            });*/
             var regionsDto =  _mapper.Map<Models.DTO.Region>(regions);

            return Ok(regionsDto);

        }
    }
}
