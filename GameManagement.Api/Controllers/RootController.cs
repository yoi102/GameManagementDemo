﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameManagement.Shared.Models;
using Microsoft.AspNetCore.Mvc;


namespace GameManagement.Api.Controllers
{
    [Route("api")]
    [ApiController]
    public class RootController : ControllerBase
    {
        [HttpGet(Name = nameof(GetRoot))]
        public IActionResult GetRoot()
        {
            var links = new List<LinkDto>
            {
                new LinkDto(Url.Link(nameof(GetRoot), new { })!, "self", "GET"),
                //new LinkDto(Url.Link(nameof(CompaniesController.GetGamesByTag), new { }), "companies", "GET"),
                //new LinkDto(Url.Link(nameof(CompaniesController.CreateCompany), new { }), "create_company", "POST")
            };

            return Ok(links);
        }
    }
}
