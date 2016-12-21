module app {
    class Config {
        constructor($stateProvider: any, $urlRouterProvider: any) {
            $urlRouterProvider.otherwise("index");

            $stateProvider
                .state("index", {
                    url: "/index",
                    templateUrl: "/Profile/Index",
                    controller: "profileController",
                    controllerAs: "vm"
                });

        }
    }
    Config.$inject = ['$stateProvider', '$urlRouterProvider'];
    var mainApp = angular.module('mainApp', ['ui.router']);
    mainApp.config(Config);
}