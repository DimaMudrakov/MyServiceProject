angular.module('SiteCountries', [])
    .factory('LocationService',
        function ($http, $q) {

            var saveCountry = function (country) {

                var deferred = $q.defer();

                $http.post('/SiteCountries/api/countries/', '"' + country + '"')
                    .success(function (data) {
                        deferred.resolve(data);
                    })
                    .error(function (data) {
                        deferred.reject(data);
                    });
                return deferred.promise;
            }

            return {
                saveCountry: saveCountry
            }
        });