var app;
(function (app) {
    var Home;
    (function (Home) {
        var ProfileController = (function () {
            function ProfileController($location) {
                this.$location = $location;
                this.hello = "hello world";
            }
            ProfileController.$inject = ['$location'];
            return ProfileController;
        }());
        angular.module('mainApp')
            .controller('profileController', ProfileController);
    })(Home = app.Home || (app.Home = {}));
})(app || (app = {}));
