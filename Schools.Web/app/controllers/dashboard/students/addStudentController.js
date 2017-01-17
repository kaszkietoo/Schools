schoolsModule.controller("addStudentController", function ($scope, $http, classId, dialog, scope) {

    $scope.addStudent = function (student) {           
        
        student.ClassId = classId;

        $http.post('/student/add?token=' + SecurityManager.generate(), student).then(function (data) {

            $http.get('/class/getallforuser?token=' + SecurityManager.generate()).then(function (data) {
                scope.classes = data.data;
            }, function (data) {
            })

            dialog.close();

        }, function () {

        })
    }

});