angular.module('SiteCountries', [])
    .factory('LocationService',
        function ($http, $q) {

            var saveCountry = function (country) {


                var deferred = $q.defer();


                $http.post('http://localhost:11111/SiteCountries/Countries/api/countries/', country)
                    .success(function (data) {
                        debugger;
                        deferred.resolve(data);
                    })
                    .error(function (data) {
                        debugger;
                        deferred.reject(data);
                    });
                return deferred.promise;
            }

            return {
                saveCountry: saveCountry
            }
        });