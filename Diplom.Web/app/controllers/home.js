var app;
(function (app) {
    var Home;
    (function (Home) {
        var HomeController = (function () {
            function HomeController($location) {
                this.$location = $location;
                this.hello = "hello world";
            }
            HomeController.prototype.test = function () {
                console.log(1);
            };
            HomeController.$inject = ['$location'];
            return HomeController;
        }());
        angular.module('mainApp')
            .controller('homeController', HomeController);
    })(Home = app.Home || (app.Home = {}));
})(app || (app = {}));
