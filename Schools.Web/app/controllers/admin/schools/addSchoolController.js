schoolsModule.controller("addSchoolController", function ($scope, $http) {    

    $scope.addSchool = function (school) {       

        $http.post('/school/add?token=' + SecurityManager.generate(), school).then(function (data) {

        }, function () {
           
        })
    }
    
});