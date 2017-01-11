schoolsModule.controller("indexController", function ($scope, $state) {       

    if (localStorage['user.isAuthenticated'] === undefined || localStorage['user.isAuthenticated'] === "false")
        $scope.isUserAuthenticated = false;
    if (localStorage['user.isAuthenticated'] === "true")
        {
        $scope.isUserAuthenticated = true;
        $scope.username = SecurityManager.username;
        }    

    $scope.$on('userAuthenticated', function () {        
        $scope.isUserAuthenticated = true;
        $scope.username = SecurityManager.username;
        localStorage["user.isAuthenticated"] = true;
    });

    $scope.logout = function () {
        SecurityManager.logout();
        $scope.isUserAuthenticated = false;
        $state.go('login');        
        localStorage.removeItem('user.isAuthenticated');
}
});