angular.module('SiteCountries')
.controller('LocationCtrl', ['LocationService', function (LocationService) {

    var vm = this;

    vm.saveCountry = function () {
        debugger;
        LocationService.saveCountry(vm.country)
            .then(function (data) {
                    debugger;
                    alert(data);
                },
                function(data) {
                    alert( vm.country + ' The country is not added');
                    console.log(data);
                });
    }
}]);