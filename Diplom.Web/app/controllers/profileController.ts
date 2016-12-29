module app.Home {

    class ProfileController {
        hello: string = "hello world";
        static $inject = ['$location'];
        constructor(private $location: ng.ILocationService) {
        }
    }
    angular.module('mainApp')
        .controller('profileController', ProfileController);
}