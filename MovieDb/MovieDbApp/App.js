(function () {
    var app = angular.module('App', ['ngRoute']);

    app.config(function ($routeProvider) {
        $routeProvider

            // route for the home page
            .when('/', {
                templateUrl: 'Search/Index.html',
                controller: 'MovieCtrl'
            })

            // route for the about page
            .when('/about', {
                templateUrl: 'About/Index.html',
                controller: 'aboutController'
            })
    });

    app.controller('SearchCtrl', function ($scope, $http)
    {
        var self = this;
        self.test = "hello world";
        self.searchResult = [];
        self.numResults = 10;
        self.posterBasePath = "https://image.tmdb.org/t/p/w185";
        self.searchTerm = "";
        self.buttonTest = function () {
            $http.get('/api/Movie/SearchMovie?searchTerm=' + self.searchTerm).then(function (data) {
                self.searchResult = data.data[0].results;
                self.searchResult = self.searchResult.slice(0, self.numResults);
            });
        };
    });
})();