schoolsModule.controller("addTeacherController", function ($scope, $http, schoolId) {
    
    $scope.addTeacher = function(teacher) {
        $http.post('/account/addteacher?token=' + SecurityManager.generate(), teacher).then(function () { }, function () { });
    }

});