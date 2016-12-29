module app.Home {

    class TeamFilesController {
        static $inject = ['$location'];
        constructor(private $location: ng.ILocationService) {
        }
    }
    angular.module('mainApp')
        .controller('teamFilesController', TeamFilesController);
}