schoolsModule.controller("loginController", function ($scope, $http, $state) {
    $scope.login = function (username, password) {        


        $http.get('/account/login?token=' + SecurityManager.generate(username, password)).then(function () {
            $scope.username = ""; $scope.password = "";
            localStorage['isAuthenticated'] = true;
            $state.go('about');

        }, function () { console.log('error') })

        
    }
});