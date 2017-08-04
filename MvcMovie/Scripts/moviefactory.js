my_app.factory("movieblogfactory", function ($http) {
    return {
        requestMovieIndex: function (callback) {
            var url = "http://localhost:59555/Movies/GetMovies";

            $http({ method: 'GET', url: url, headers: { 'Content-Type': 'application/json' } })
                .success(function (data, status, headers, config) {
                    data = angular.fromJson(data);
                    callback(data);
                }).error(function (data, status, headers, config) { });
        },

        requestBlogIndex: function (callback) {
            var url = "http://localhost:59555/Blogs/getBlogs";

            $http({ method: 'GET', url: url, headers: { 'Content-Type': 'application/json' } })
                .success(function (data, status, headers, config) {
                    data = angular.fromJson(data);
                    callback(data);
                }).error(function (data, status, headers, config) { });
        }


    }



});