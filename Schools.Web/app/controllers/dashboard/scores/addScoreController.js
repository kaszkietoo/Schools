schoolsModule.controller("addScoreController", function ($scope, $http, studentId, $state, dialog, scope) {

    $http.get('/subject/getall?token=' + SecurityManager.generate()).then(function (data) {
        $scope.subjects = data.data;
    }, function (data) {
    })

    $scope.addScore = function (score) {

        score.StudentId = studentId;

        $http.post('/score/add?token=' + SecurityManager.generate(), score).then(function (data) {

            $http.get('/class/getallforuser?token=' + SecurityManager.generate()).then(function (data) {
                scope.classes = data.data;
            }, function (data) {
            })

            dialog.close();
            


        }, function () {

        })
    }

});