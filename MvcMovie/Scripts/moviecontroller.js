my_app.controller("movieblogcontroller", function ($scope, movieblogfactory) {

    $scope.movieList = [];
    $scope.blogList = [];



    $scope.getMovies = function (callback) {
        movieblogfactory.requestMovieIndex(callback);
    },


    $scope.getBlogs = function (callback) {
            movieblogfactory.requestBlogIndex(callback);
     },


    $scope.GetMoviesCallback = function (response) {
        
        
        $scope.movieList = response;

     },


        $scope.GetBlogsCallback = function (response) {

            
            $scope.blogList = response;

     }

    $scope.getBlogs($scope.GetBlogsCallback);

    $scope.getMovies($scope.GetMoviesCallback);

});