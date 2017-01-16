schoolsModule.controller("listClassesController", function ($scope, ngDialog, $http) {

    $http.get('/class/getallforuser?token=' + SecurityManager.generate()).then(function (data) {
        $scope.classes = data.data;
        console.log(data.data);
    }, function (data) {
    })

    
    $scope.open = function () {
        ngDialog.open({
            templateUrl: '/app/views/dashboard/classes/add.html',
            controller: 'addClassController'            
        })
    }

    $scope.openAddingStudent = function (classId) {
        ngDialog.open({
            templateUrl: '/app/views/dashboard/students/add.html',
            controller: 'addStudentController',
            resolve: {
                classId: function () {
                    return classId;
                }
            }
        })
    }

    $scope.openAddingScore = function (studentId) {
        ngDialog.open({
            templateUrl: '/app/views/dashboard/scores/add.html',
            controller: 'addScoreController',
            resolve: {
                studentId: function () {
                    return studentId;
                }
            }
        })
    }

});