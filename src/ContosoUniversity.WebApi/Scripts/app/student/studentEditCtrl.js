(function (app) {
    'use strict';

    app.controller('studentEditCtrl', studentEditCtrl);

    studentEditCtrl.$inject = ['$scope', '$http', '$location', '$routeParams'];
    function studentEditCtrl($scope, $http, $location, $routeParams) {
        $scope.student = {};
        $scope.updateStudent = updateStudent;

        function loadStudent() {
            $http.get('/api/student/' + $routeParams.id)
                .success(function (data, status, headers, config) {
                    $scope.student = data;
                })
                .error(function (data, status, headers, config) {
                    console.log(data);
                });
        }

        function updateStudent() {
            $http.put('api/student/' + $routeParams.id, $scope.student)
                .success(function (data, status, headers, config) {
                    $scope.student = data;
                })
                .error(function (data, status, headers, config) {
                    console.log(data);
                });
            console.log($scope.student);
        }

        loadStudent();
    }

})(angular.module('ContosoUniversity'));