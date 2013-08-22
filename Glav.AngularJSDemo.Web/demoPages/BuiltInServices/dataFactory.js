window.app.factory('dataFactory',
    function ($http) {

        return {
            getData: function() {
                return $http(
                {
                    method: "GET",
                    url: "/api/exampleapi",
                    cache: false
                });
            },
            postData: function(payload) {
                return $http(
                {
                    method: "POST",
                    url: "/api/exampleapi?blob=" +payload,
                    data: payload
                });
            }
        };
    });