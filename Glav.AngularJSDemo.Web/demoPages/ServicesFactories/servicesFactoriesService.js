window.app.service('servicesFactoriesService',
    function () {
        // We are in a constructor function
        this.serviceProperty = 1;
        this.performService = function() {
            this.serviceProperty++;
        };
    });