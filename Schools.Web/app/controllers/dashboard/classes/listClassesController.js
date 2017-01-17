schoolsModule.controller("listClassesController", function ($scope, ngDialog, $http) {

    $http.get('/class/getallforuser?token=' + SecurityManager.generate()).then(function (data) {
        $scope.classes = data.data;        
    }, function (data) {
    })

    
    $scope.open = function () {
        ngDialog.open({
            templateUrl: '/app/views/dashboard/classes/add.html',
            controller: 'addClassController',
            resolve: {                
                dialog: function () {
                    return ngDialog;
                },
                scope: function () {
                    return $scope;
                }
            }
        })
    }

    $scope.openAddingStudent = function (classId) {
        ngDialog.open({
            templateUrl: '/app/views/dashboard/students/add.html',
            controller: 'addStudentController',
            resolve: {
                classId: function () {
                    return classId;
                },
                dialog: function () {
                    return ngDialog;
                },
                scope: function () {
                    return $scope;
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
                },
                dialog: function () {
                    return ngDialog;
                },
                scope: function () {
                    return $scope;
                }
            }
        })
    }

});