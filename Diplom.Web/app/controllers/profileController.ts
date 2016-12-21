module app.Home {

    class ProfileController {
        hello: string = "hello world";
        static $inject = ['$location'];
        constructor(private $location: ng.ILocationService) {
        }

        test(): void {
            console.log(1);
        }
    }
    angular.module('mainApp')
        .controller('profileController', ProfileController);
}