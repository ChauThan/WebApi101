(function (app) {
    'use strict';

    app.controller('indexCtrl', indexCtrl);

    indexCtrl.$inject = ['$scope'];
    function indexCtrl($scope) {
        $scope.message = 'Contoso University';
    }

})(angular.module('ContosoUniversity'));