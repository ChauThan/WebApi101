(function () {
    'use strict';

    angular.module('ContosoUniversity', ['common.ui', 'common.core'])
        .config(config);

    config.$inject = ['$routeProvider'];
    function config($routeProvider) {
        $routeProvider
            .when("/", {
                templateUrl: "scripts/app/home/index.html",
                controller: "indexCtrl"
            })
            .when("/student", {
                templateUrl: "scripts/app/student/students.html",
                controller: "studentsCtrl"
            })
            .when("/student/add/", {
                templateUrl: "scripts/app/student/add.html",
                controller: "studentAddCtrl"
            })
            .when("/student/edit/:id", {
                templateUrl: "scripts/app/student/edit.html",
                controller: "studentEditCtrl"
            })
            //.when("/", {
            //    templateUrl: "scripts/app/student/students.html",
            //    controller: "studentsCtrl"
            //})
            .otherwise({ redirectTo: "/" });
    }
})();