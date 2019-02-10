using System;
using System.Collections;
using System.Collections.Generic;
using CityInfo.API.Entities;

namespace CityInfo.API.Services
{
    public interface ICityInfoRepository
    {
        IEnumerable<City> GetCities();
        City GetCity(int cityId, bool includePOI);
        IEnumerable<PointOfInterest> GetPointOfInterests(int cityId);
        PointOfInterest GetPointOfInterest(int ctyId, int pointOfInterestId);
    }
}
