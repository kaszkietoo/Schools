schoolsModule.controller("addClassController", function ($scope, $http, dialog, scope) {

    $scope.addClass = function (classModel) {

        $http.post('/class/add?token=' + SecurityManager.generate(), classModel).then(function (data) {

            $http.get('/class/getallforuser?token=' + SecurityManager.generate()).then(function (data) {
                scope.classes = data.data;
            }, function (data) {
            })

            dialog.close();

        }, function () {

        })
    }

});