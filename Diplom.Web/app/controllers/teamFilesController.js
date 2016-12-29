var app;
(function (app) {
    var Home;
    (function (Home) {
        var TeamFilesController = (function () {
            function TeamFilesController($location) {
                this.$location = $location;
            }
            TeamFilesController.$inject = ['$location'];
            return TeamFilesController;
        }());
        angular.module('mainApp')
            .controller('teamFilesController', TeamFilesController);
    })(Home = app.Home || (app.Home = {}));
})(app || (app = {}));
