window.app.factory('theFactory',
    function () {
        // you could run some code here to initialise the factory
        var initialValue = Math.round(Math.random() * 10);

        // Then return an object to use
        return {
            factoryProperty: initialValue,
            performService: function() {
                this.factoryProperty++;
            }    
        };
    });