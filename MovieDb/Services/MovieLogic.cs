using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieDb.Models;
using RestSharp;
using RestSharp.Deserializers;

namespace MovieDb.Services
{
    public class MovieLogic
    {
        private readonly string apiKey = "25b0ec2076136f9ff81789961775fa03";
        private readonly string popularMovieUrl = "https://api.themoviedb.org/3/movie/popular?api_key=";
        private readonly string searchMovieUrl = "https://api.themoviedb.org/3/search/movie?api_key=";

        public List<SearchQuery> SearchMovie(string searchTerm)
        {
            RestClient client;

            // If no search term is provided, return a list of popular movies
            if (searchTerm == null)
                client = new RestClient(popularMovieUrl + apiKey);
            else
                client = new RestClient(searchMovieUrl + apiKey + "&query=" + searchTerm);

            client.AddHandler("application/json", new JsonDeserializer());
            var result = client.Execute<List<SearchQuery>>(new RestRequest());
            return result.Data;
        }
    }
}