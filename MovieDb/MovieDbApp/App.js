(function () {
    var app = angular.module('App', ['ngRoute']);

    app.config(function ($routeProvider) {
        $routeProvider

            // route for the home search page
            .when('/', {
                templateUrl: 'Search/Index.html',
                controller: 'MovieCtrl'
            })
    });

    app.controller('SearchCtrl', function ($scope, $http)
    {
        // Variables
        var self = this;
        self.searchResult = [];
        self.numResults = 10;
        self.posterBasePath = "https://image.tmdb.org/t/p/w185";
        self.searchTerm = "";

        // Movie Search API Call
        self.searchMovie = function () {
            $http.get('/api/Movie/SearchMovie?searchTerm=' + self.searchTerm).then(function (data) {
                self.searchResult = data.data[0].results;
                self.searchResult = self.searchResult.slice(0, self.numResults);
            });
        };

        // Initalize
        self.init = function () {
            self.searchMovie();
        }
        self.init();
    });
})();