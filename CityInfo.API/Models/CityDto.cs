using System;
using System.Collections.Generic;

namespace CityInfo.API.Models
{
    public class CityDto
    {
        public CityDto()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NoOfPointsOfInterest { get
            {
                return PointsOfInterests.Count;
            }}
        public List<PointsOfInterestDto> PointsOfInterests { get; set; } = new List<PointsOfInterestDto>();
    }

    public class CitiDataStore
    {
        public static CitiDataStore Current { get; } = new CitiDataStore();
        public List<CityDto> Cities { get; set; }
        public CitiDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id= 1,
                    Name = "Mumbai",
                    Description = "Hi Mumbai",
                    PointsOfInterests = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id=1,
                            Name = "Gateway of india",
                            Description = "Gateway of india"

                        },
                        new PointsOfInterestDto()
                        {
                            Id=2,
                            Name = "Marine Drive",
                            Description = "Marine Drive"

                        }
                    }

                },
                new CityDto()
                {
                    Id=2,
                    Name="Pune",
                    Description = "Hi Pune",
                    PointsOfInterests = new List<PointsOfInterestDto>()
                    {
                        new PointsOfInterestDto()
                        {
                            Id=3,
                            Name = "Dagdu Sheth",
                            Description = "Dagdu Sheth"

                        },
                        new PointsOfInterestDto()
                        {
                            Id=4,
                            Name = "Aga Khan Palace",
                            Description = "Aga Khan Palace"

                        }
                    }

                }
            };
        }


    }
}
