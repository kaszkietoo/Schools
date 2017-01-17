schoolsModule.controller("addSchoolController", function ($scope, $http) {

    $scope.addSchool = function (school) {       

        $http.post('/school/add?token=' + SecurityManager.generate(), school).then(function (data) {

            $http.get('/school/getall?token=' + SecurityManager.generate()).then(function (data) {
                scope.schools = data.data;
            }, function (data) {
            })

        }, function () {
           
        })
    }
    
});