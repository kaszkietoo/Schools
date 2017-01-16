schoolsModule.controller("addClassController", function ($scope, $http) {

    $scope.addClass = function (classModel) {

        $http.post('/class/add?token=' + SecurityManager.generate(), classModel).then(function (data) {

        }, function () {

        })
    }

});