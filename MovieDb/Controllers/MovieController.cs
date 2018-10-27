using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using MovieDb.Models;
using MovieDb.Services;
using Newtonsoft.Json.Linq;

namespace MovieDb.Controllers
{
    public class MovieController : ApiController
    {
        private MovieLogic _movieLogic;
        public MovieController()
        {
            // create a logic class when the controller is initalized
            _movieLogic = new MovieLogic();
        }

        [HttpGet()]
        [ActionName("SearchMovie")]
        public IHttpActionResult SearchMovie(string searchTerm = null)
        {
            var result = _movieLogic.SearchMovie(searchTerm);

            if (result.StatusCode != HttpStatusCode.OK)
                return Content(result.StatusCode, JObject.Parse(result.Content));

            return Ok(result.Data);
        }
    }
}
