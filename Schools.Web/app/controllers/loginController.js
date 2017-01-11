schoolsModule.controller("loginController", function ($scope, $http, $state) {
    $scope.login = function (username, password) {        


        $http.get('/account/login?token=' + SecurityManager.generate(username, password)).then(function (data) {
            $scope.username = ""; $scope.password = "";
            $scope.$emit('userAuthenticated');                       

        }, function () {
            $scope.username = ""; $scope.password = "";
        })

        
    }
});