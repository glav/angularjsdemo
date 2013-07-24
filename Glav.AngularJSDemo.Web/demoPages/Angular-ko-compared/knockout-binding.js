var koData = {
    firstName: ko.observable("James"),
    lastName: ko.observable("Bond"),
    age: ko.observable(35)
};

ko.applyBindings(koData);