(function () {
    var app = angular.module('App', ['ngRoute', 'services', 'ui.bootstrap']);

    app.config(function ($routeProvider) {
        $routeProvider

            // route for the home search page
            .when('/', {
                templateUrl: 'Search/Index.html',
                controller: 'MovieCtrl'
            })
    });

    angular.module('services', []).factory('MovieData', ['$http',
        function ($http) {
            return {
                // API calls here
                SearchMovie: function (SearchTerm) {
                    return $http.get('/api/Movie/SearchMovie?searchTerm=' + SearchTerm);
                }
            }
        }]);

    app.controller('SearchCtrl', function ($scope, MovieData)
    {
        // Variables
        var self = this;
        self.searchResult = [];
        self.numResults = 10;
        self.posterBasePath = "https://image.tmdb.org/t/p/w185";
        self.searchTerm = "";

        // Movie Search API Call
        self.searchMovie = function () {
            MovieData.SearchMovie(self.searchTerm).then(
                function (data) {
                    self.searchResult = data.data[0].results;
                    self.searchResult = self.searchResult.slice(0, self.numResults);
                }, function (data) {
                    // Error code handeling here
                    console.log("Failed to get movies, " + data.status + ": " + data.data.status_message)
                }
            );
        };

        // Initalize
        self.init = function () {
            self.searchMovie();
        }
        self.init();
    });
})();