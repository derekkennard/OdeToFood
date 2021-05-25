// Created by Derek Kennard
// Solution: OdeToFood
// Project Name: OdeToFood
// File Name: List.cshtml.cs
// Created on: 05/25/2021 at 12:06 AM
// Edited on: 05/25/2021 at 12:30 AM
// Developed and Copyrighted by Derek "Doctork" Kennard

#region imports

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

#endregion

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration _config;
        private readonly IRestaurantData _restaurantData;

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            _config = config;
            _restaurantData = restaurantData;
        }

        public string Message { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }

        public void OnGet()
        {
            Message = _config["Messages"];
            Restaurants = _restaurantData.GetAll();
        }
    }
}