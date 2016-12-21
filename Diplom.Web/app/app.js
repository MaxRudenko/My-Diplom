var app;
(function (app) {
    var Config = (function () {
        function Config($stateProvider, $urlRouterProvider) {
            $urlRouterProvider.otherwise("index");
            $stateProvider
                .state("index", {
                url: "/index",
                templateUrl: "/Profile/Index",
                controller: "profileController",
                controllerAs: "vm"
            });
        }
        return Config;
    }());
    Config.$inject = ['$stateProvider', '$urlRouterProvider'];
    var mainApp = angular.module('mainApp', ['ui.router']);
    mainApp.config(Config);
})(app || (app = {}));
