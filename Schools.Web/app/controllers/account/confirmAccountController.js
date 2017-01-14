schoolsModule.controller("confirmAccountController", function ($scope, $state, $http) {  
    
    var code = $state.params.code.substring(1);
    var decodedCode = atob(code);
    var splitted = decodedCode.split(':');    
    

    $scope.addPassword = function (password) {      
        
        var confirmationCode = splitted[1];
        $http.post('/account/confirm', { code: confirmationCode, username: splitted[0], hashedPassword: SecurityManager.getHashedPassword(password.password) } ).then(function () { }, function () { });
    }

});