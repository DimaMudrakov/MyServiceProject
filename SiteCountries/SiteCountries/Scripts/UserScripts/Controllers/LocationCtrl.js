angular.module('SiteCountries')
.controller('LocationCtrl', ['LocationService', function (LocationService) {

    var vm = this;

    vm.saveCountry = function () {

        LocationService.saveCountry(vm.country);
    }
}]);