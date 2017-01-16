schoolsModule.controller("addScoreController", function ($scope, $http, studentId) {

    $http.get('/subject/getall?token=' + SecurityManager.generate()).then(function (data) {
        $scope.subjects = data.data;
    }, function (data) {
    })

    $scope.addScore = function (score) {

        score.StudentId = studentId;        

        $http.post('/score/add?token=' + SecurityManager.generate(), score).then(function (data) {

        }, function () {

        })
    }

});