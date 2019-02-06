using System;
using System.Collections.Generic;
using System.Linq;
using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api")]
    public class CitiesController : Controller
    {
        public CitiesController()
        {
        }

        [HttpGet("cities")]
        public IActionResult GetCities()
        {
            return Ok(new JsonResult(CitiDataStore.Current.Cities));

        }

        [HttpGet("cities/{id}")]
        public IActionResult GetCity(int id)
        {
            var city =  CitiDataStore.Current.Cities.FirstOrDefault(x => x.Id == id); 
            if(city == null)
            {
                return NotFound();
            }
            return Ok(city);
        }

    }
}
