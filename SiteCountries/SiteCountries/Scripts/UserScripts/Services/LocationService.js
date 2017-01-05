angular.module('SiteCountries', [])
    .factory('LocationService',
        function($http) {

            var saveCountry = function (country) {
                alert(country);
            }

            return {
                saveCountry: saveCountry
            }
        });