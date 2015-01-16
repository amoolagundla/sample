'use strict'
/************************************************************************************************************************************/
/** This is the service which calls the back end web api and handles all the backend interactions for the page **********************/

angularStartServices.factory('homeService', ['$q', '$resource', '$http', function ($q, $resource, $http) {

    var BaseUrl = "/api/values/";
    var homeService = {};
    var homeService = $resource(BaseUrl, {

    }, {
        query: {
            method: 'GET',
            isArray: false,
            transformResponse: function (data) {return {list: angular.fromJson(data)} }
        }
    });
    homeService.helloworld = function () {

        var deferred = $q.defer();


        homeService.query({}, {}, function (data) {

            deferred.resolve(data.list);


        }, function (error) {
            deferred.reject("no data found");
        });


        return deferred.promise;
    };
   
    return homeService;

}]);