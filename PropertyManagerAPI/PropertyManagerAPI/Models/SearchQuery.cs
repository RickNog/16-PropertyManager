﻿
namespace PropertyManagerAPI.Models
{
    public class SearchQuery
    {
        //Building SearchQuery model to accept these search terms
        public string UserName { get; set; }
        public string City { get; set; }
        public int? Zip { get; set; }
        public int? MinRent { get; set; }
        public int? MaxRent { get; set; }
        public int? Bedrooms { get; set; }
        public int? Bathrooms { get; set; }
    }
}