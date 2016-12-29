module app.Home {

    class IndexController {
        static $inject = ['$location'];
        constructor(private $location: ng.ILocationService) {
        }

        test(): void {
            console.log(1);
        }
    }
    angular.module('mainApp')
        .controller('indexController', IndexController);
}