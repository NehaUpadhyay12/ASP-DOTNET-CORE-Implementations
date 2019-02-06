using System;
using System.Collections.Generic;
using System.Linq;
using CityInfo.API.Entities;

namespace CityInfo.API
{
    public static class CityInfoContextExtension
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.City.Any())
                return;
            var cities = new List<City>()
            {
                new City()
                {
                    Name = "Mumbai",
                    PointOfInterests = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Gateway of india",
                            Description = "Gateway of india"

                        },
                        new PointOfInterest()
                        {
                            Name = "Marine Drive",
                            Description = "Marine Drive"

                        }
                    }

                },
                new City()
                {
                    Name="Pune",
                    PointOfInterests = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Dagdu Sheth",
                            Description = "Dagdu Sheth"

                        },
                        new PointOfInterest()
                        {
                            Name = "Aga Khan Palace",
                            Description = "Aga Khan Palace"

                        }
                    }

                }
            };
            context.City.AddRange(cities);
            context.SaveChanges();      
            }
    }
}
