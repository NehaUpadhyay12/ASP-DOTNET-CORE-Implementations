using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CityInfo.API.Models;
using CityInfo.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api")]
    public class CitiesController : Controller
    {
        private ICityInfoRepository _cityInfoRepo;
        public CitiesController(ICityInfoRepository cityInfoRepo)
        {
            _cityInfoRepo = cityInfoRepo;
        }

        [HttpGet("cities")]
        public IActionResult GetCities()
        {
            var cities = _cityInfoRepo.GetCities();
            var results = Mapper.Map<IEnumerable<CityWithoutPointsOfInterestDto>>(cities);
            return Ok(results);

        }

        [HttpGet("cities/{id}")]
        public IActionResult GetCity(int id)
        {
            var city =  _cityInfoRepo.GetCity(id, true); 
            if(city == null)
            {
                return NotFound();
            }
            var result = Mapper.Map<CityDto>(city);
            return Ok(result);
        }

    }
}
