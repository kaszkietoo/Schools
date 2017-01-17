schoolsModule.controller("addTeacherController", function ($scope, $http, schoolId, scope, dialog) {
    
    $scope.addTeacher = function (teacher) {
        teacher.SchoolId = schoolId;        
        $http.post('/account/addteacher?token=' + SecurityManager.generate(), teacher).then(function () {
            $http.get('/school/getall?token=' + SecurityManager.generate()).then(function (data) {
                scope.schools = data.data;
                dialog.close();
            }, function (data) {
            })
        }, function () { });
    }

});