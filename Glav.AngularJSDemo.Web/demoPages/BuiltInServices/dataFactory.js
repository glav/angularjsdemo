window.app.factory('dataFactory',
    function ($http) {
        // you could run some code here to initialise the factory
        var initialValue = Math.round(Math.random() * 10);

        // Then return an object to use
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