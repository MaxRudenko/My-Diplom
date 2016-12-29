var app;
(function (app) {
    var Helpers;
    (function (Helpers) {
        var HttpHelpers = (function () {
            function HttpHelpers($q, growl, $rootScope, $http) {
                this.$q = $q;
                this.growl = growl;
                this.$rootScope = $rootScope;
                this.$http = $http;
            }
            HttpHelpers.prototype.http = function (delegate, shouldHandleOperationResult, interval) {
                var _this = this;
                if (shouldHandleOperationResult === void 0) { shouldHandleOperationResult = false; }
                if (interval === void 0) { interval = false; }
                var deferred = this.$q.defer();
                delegate()
                    .success(function (result, status, headers) {
                    if (status == 302) {
                        _this.$http.get("/account/logOff");
                        setTimeout(new function () { window.location.href = ""; }, 1500);
                        return;
                    }
                    deferred.resolve(result);
                })
                    .error(function (result) {
                    if (result != null) {
                        alert(result);
                    }
                    else {
                        alert("Unexpected server error");
                    }
                    deferred.reject(result);
                });
                return deferred.promise;
            };
            HttpHelpers.$inject = ["$q", "growl", "$rootScope", "$http"];
            return HttpHelpers;
        }());
        Helpers.HttpHelpers = HttpHelpers;
        angular.module("mainApp").service("httpHelpers", HttpHelpers);
    })(Helpers = app.Helpers || (app.Helpers = {}));
})(app || (app = {}));
