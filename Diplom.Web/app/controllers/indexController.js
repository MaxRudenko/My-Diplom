var app;
(function (app) {
    var Home;
    (function (Home) {
        var IndexController = (function () {
            function IndexController($location) {
                this.$location = $location;
            }
            IndexController.prototype.test = function () {
                console.log(1);
            };
            IndexController.$inject = ['$location'];
            return IndexController;
        }());
        angular.module('mainApp')
            .controller('indexController', IndexController);
    })(Home = app.Home || (app.Home = {}));
})(app || (app = {}));
