schoolsModule.controller("listSchoolsController", function ($scope, $http, ngDialog) {       
    
        $http.get('/school/getall?token=' + SecurityManager.generate()).then(function (data) {
            $scope.schools = data.data;
        }, function (data) {            
        })
    
        $scope.open = function (schoolId) {
            ngDialog.open({
                templateUrl: '/app/views/admin/teachers/add.html',
                controller: 'addTeacherController',
                resolve: {
                    schoolId: function () {
                        return schoolId;
                    }
                }
            })
        }

        $scope.openAddingSchool = function () {
            ngDialog.open({
                templateUrl: '/app/views/admin/schools/add.html',
                controller: 'addSchoolController'                
            })
        }
        

});