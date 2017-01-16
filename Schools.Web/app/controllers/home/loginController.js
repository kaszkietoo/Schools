schoolsModule.controller("loginController", function ($scope, $http, $state) {
    $scope.login = function (username, password) {        


        $http.get('/account/login?token=' + SecurityManager.generate(username, password)).then(function (data) {
            $scope.username = ""; $scope.password = "";
            $scope.$emit('userAuthenticated');            

            if (data.data === 'Admin') {                
                $state.go('schools');
            }

            if (data.data === 'Teacher') {
                $state.go('classes');
            }


        }, function () {
            $scope.username = ""; $scope.password = "";
        })

        
    }
});