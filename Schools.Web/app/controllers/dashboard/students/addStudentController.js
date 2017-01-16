schoolsModule.controller("addStudentController", function ($scope, $http, classId) {

    $scope.addStudent = function (student) {           
        
        student.ClassId = classId;

        $http.post('/student/add?token=' + SecurityManager.generate(), student).then(function (data) {

        }, function () {

        })
    }

});