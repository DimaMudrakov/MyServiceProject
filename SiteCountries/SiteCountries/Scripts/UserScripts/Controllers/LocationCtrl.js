angular.module('SiteCountries')
.controller('LocationCtrl', ['LocationService', function (LocationService) {

    var vm = this;

    vm.saveCountry = function () {
        LocationService.saveCountry(vm.country)
            .then(function (data) {
                    alert(data.Message);
                },
                function (data) {
                    alert(data.Message);
                    console.log(data.ExceptionMessage);
                });
    }
}]);