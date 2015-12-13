(function (app) {
    'use strict';

    app.controller('studentAddCtrl', studentAddCtrl);

    studentAddCtrl.$inject = ['$scope', '$http', '$location', '$routeParams'];
    function studentAddCtrl($scope, $http, $location, $routeParams) {
        $scope.student = {};
        $scope.addStudent = addStudent;

        function addStudent() {
            $http.post('api/student', $scope.student)
                .success(function (data, status, headers, config) {
                    $scope.student = data;
                    $location.path('/student');
                })
                .error(function (data, status, headers, config) {
                    console.log(data);
                });

            $location.path('/student');
        }
    }

})(angular.module('ContosoUniversity'));