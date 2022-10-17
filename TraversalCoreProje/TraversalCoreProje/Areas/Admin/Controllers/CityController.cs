﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(cities);
            return Json(jsonCity);
        } 

        public static List<CityClass> cities = new List<CityClass>
        {
            new CityClass()
            {
                CityId = 1,
                CityName="üsküp",
                CityCountry="Makedonya"
            },
            new CityClass()
            {
                CityId = 2,
                CityName="Roma",
                CityCountry="İtalya"
            },
            new CityClass()
            {
                CityId = 3,
                CityName="Londra",
                CityCountry="İngiltere"
            }
        };
    }
}
