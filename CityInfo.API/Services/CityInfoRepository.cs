using System;
using System.Collections.Generic;
using System.Linq;
using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.Services
{
    public class CityInfoRepository : ICityInfoRepository
    {
        CityInfoContext _ctx;
        public CityInfoRepository(CityInfoContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<City> GetCities()
        {
            return _ctx.City.OrderBy(c => c.Name).ToList();
        }

        public City GetCity(int cityId, bool includePOI)
        {
            if (includePOI)
            {
                return _ctx.City.Include(c => c.PointOfInterests).Where(c => c.Id == cityId).FirstOrDefault();
            }
            return _ctx.City.Where(c => c.Id == cityId).FirstOrDefault();
        }

        public PointOfInterest GetPointOfInterest(int ctyId, int pointOfInterestId)
        {
            return _ctx.PointOfInterest.Where(c => c.CityId == ctyId && c.Id == pointOfInterestId).FirstOrDefault();
        }

        public IEnumerable<PointOfInterest> GetPointOfInterests(int cityId)
        {
            return _ctx.PointOfInterest.Where(c => c.CityId == cityId).ToList();
        }
    }
}
