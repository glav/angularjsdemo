window.app.factory('slideFactory', ['$http', function ($http) {
    return {
        getSlide: function (slideNumber) {
            if (slideNumber === undefined) {
                slideNumber = 0;
            }

            return $http(
                {
                    method: "GET",
                    url: "/api/slide/" + slideNumber,
                });
        }
    };
}]);