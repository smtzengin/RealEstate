﻿namespace RealEstate_Dapper_Api.Dtos.PopularLocationDtos
{
    public class GetByIDPopularLocation
    {
        public int LocationID { get; set; }
        public string CityName { get; set; }
        public string ImageUrl { get; set; }
    }
}
