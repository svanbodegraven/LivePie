﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Livepie.Domain;
using System.Net;

namespace Livepie.Api.Controllers
{
    [Route("api/[controller]")]
    public class AnonymousPoiController : Controller
    {
        // GET api/AnonymousPoi
        [HttpGet]
        public int Get()
        {
            return (int)HttpStatusCode.OK;
        }

        // GET api/AnonymousPoi
        //[HttpGet]
        //public string Get([FromBody]Location location)
        //{
        //    return "value";
        //}

        // POST api/AnonymousPoi
        //[HttpPost]
        //public void Post([FromBody]Ping ping)
        //{
        //}
    }
}
