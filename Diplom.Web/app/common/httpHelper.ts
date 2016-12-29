module app.Helpers {

    export class HttpHelpers {
        constructor(
            private $q: ng.IQService,
            private growl: any,
            private $rootScope, private $http) {
        }
        static $inject = ["$q", "growl", "$rootScope", "$http"];

        http(delegate, shouldHandleOperationResult = false, interval = false) {
            var deferred = this.$q.defer();
            delegate()
                .success((result, status, headers) => {
                    if (status == 302) {
                        this.$http.get("/account/logOff");
                        setTimeout(new function () { window.location.href = "" }, 1500);
                        return;
                    }
                    deferred.resolve(result);
                })
                .error((result) => {
                    if (result != null) {
                        alert(result);
                    } else {
                        alert("Unexpected server error");
                    }
                    deferred.reject(result);
                });
            return deferred.promise;
        }
    }
    angular.module("mainApp").service("httpHelpers", HttpHelpers);
}