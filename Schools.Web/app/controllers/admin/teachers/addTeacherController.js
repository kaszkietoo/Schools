schoolsModule.controller("addTeacherController", function ($scope, $http, schoolId) {
    
    $scope.addTeacher = function (teacher) {
        teacher.SchoolId = schoolId;        
        $http.post('/account/addteacher?token=' + SecurityManager.generate(), teacher).then(function () { }, function () { });
    }

});