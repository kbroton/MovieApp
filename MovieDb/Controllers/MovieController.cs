using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using MovieDb.Models;
using MovieDb.Services;
using System.Threading.Tasks;
using Newtonsoft.Json;


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
        public List<SearchQuery> SearchMovie(string searchTerm)
        {
            return _movieLogic.SearchMovie(searchTerm);
        }
    }
}
