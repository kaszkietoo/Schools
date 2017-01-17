schoolsModule.controller("addSchoolController", function ($scope, $http, scope, dialog) {

    $scope.addSchool = function (school) {       

        $http.post('/school/add?token=' + SecurityManager.generate(), school).then(function (data) {

            $http.get('/school/getall?token=' + SecurityManager.generate()).then(function (data) {
                scope.schools = data.data;
                dialog.close();
            }, function (data) {
            })

        }, function () {
           
        })
    }
    
});