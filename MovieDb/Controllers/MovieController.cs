using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieDb.Models;
using RestSharp;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace MovieDb.Controllers
{
    public class MovieController : ApiController
    {
        [HttpGet()]
        [ActionName("SearchMovie")]
        public List<SearchQuery> SearchMovie(string searchTerm)
        {
            //List<SearchQuery> result = new List<SearchQuery>();
            //result.Add(new SearchQuery()
            //{
            //    poster_path = "/IfB9hy4JH1eH6HEfIgIGORXi5h.jpg",
            //    adult = false,
            //    overview = "Jack Reacher must uncover the truth behind a major government conspiracy in order to clear his name. On the run as a fugitive from the law, Reacher uncovers a potential secret from his past that could change his life forever.",
            //    release_date = "2016-10-19",
            //    genre_ids = new List<int> { 53, 28, 80, 18, 9648 },
            //    id = 343611,
            //    original_title = "Jack Reacher: Never Go Back",
            //    original_language = "en",
            //    title = "Jack Reacher: Never Go Back",
            //    backdrop_path = "/4ynQYtSEuU5hyipcGkfD6ncwtwz.jpg",
            //    popularity = 26.818468,
            //    vote_count = 201,
            //    video = false,
            //    vote_average = 4.19
            //});
            var client = new RestClient("https://api.themoviedb.org/3/search/movie?api_key=25b0ec2076136f9ff81789961775fa03&language=en-US&query=" + searchTerm);
            client.AddHandler("application/json", new JsonDeserializer());
            var result = client.Execute<List<SearchQuery>>(new RestRequest());
            return result.Data;
        }
    }
}
