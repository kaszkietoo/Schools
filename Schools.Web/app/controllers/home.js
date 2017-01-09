var app = angular.module('homeApplication', []);

app.controller('homeController', function ($scope, $http) {
    $http.get('/values/find?q=am&token=' + SecurityManager.generate()).then(function (data) {        
        $scope.people = data.data;
    });

    
});