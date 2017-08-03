﻿moviesApp.controller("moviecontroller", function ($scope, moviefactory) {

    $scope.movieList = [];

    $scope.getMovies = function (callback) {
        moviefactory.requestMovieIndex(callback);
    }

    $scope.GetMoviesCallback = function (response) {
        
        console.log(response);
        $scope.movieList = response;

    }

    $scope.getMovies($scope.GetMoviesCallback);

});