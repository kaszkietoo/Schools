schoolsModule.controller("loginController", function ($scope, $http, $state) {
    $scope.login = function (username, password) {        


        $http.get('/account/login?token=' + SecurityManager.generate(username, password)).then(function () {
            $scope.username = ""; $scope.password = "";
            $scope.$emit('userAuthenticated');
            $scope.isUserAuthenticated = true;
            localStorage["user.isAuthenticated"] = true;
            $state.go('about');

        }, function () { console.log('error') })

        
    }
});