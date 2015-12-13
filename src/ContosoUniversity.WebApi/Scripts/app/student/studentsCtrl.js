(function (app) {
    'use strict';

    app.controller('studentsCtrl', studentsCtrl);

    studentsCtrl.$inject = ['$scope', '$http'];

    function studentsCtrl($scope, $http) {
        $scope.pageClass = 'page-students';
        $scope.loadingMovies = true;
        $scope.page = 0;
        $scope.pagesCount = 0;

        $scope.Students = [];
        $scope.loadStudents = loadStudents;
        $scope.deleteStudent = deleteStudent;


        function loadStudents() {
            $http.get('/api/student')
                .success(function (data, status, headers, config) {
                    $scope.Students = data;
                })
                .error(function (data, status, headers, config) {
                    console.log(data);
                });

        }

        function deleteStudent(id) {
            $http.delete('/api/student/' + id)
                .success(function (data, status, headers, config) {
                    loadStudents();
                })
                .error(function (data, status, headers, config) {
                    console.log(data);
                });
        }

        $scope.loadStudents();
    }

})(angular.module('ContosoUniversity'));