﻿'user strict';
angular.module('app.controllers')
// Path: /
    .controller('HomeCtrl', [
        '$scope', '$location', '$window', function ($scope, $location, $window) {
            $scope.$root.title = 'JC Espinoza\'s GuessIt Soccer';
            $scope.$on('$viewContentLoaded', function () {
                $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
            });
        }
    ]);