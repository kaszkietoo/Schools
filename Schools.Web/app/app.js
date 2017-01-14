var schoolsModule = angular.module("schools", ['ui.router', 'ngDialog']);

schoolsModule.config(function ($stateProvider) {
    var loginState = {
        name: 'login',
        url: '/home/login',
        templateUrl: '/app/views/home/login.html'        
    };

    var aboutState = {
        name: 'about',
        url: '/home/about',
        templateUrl: '/app/views/home/about.html'
    };

    var schoolListState = {
        name: 'schools',
        url: '/admin/schools',
        templateUrl: '/app/views/admin/schools/list.html'        
    };

    var addSchoolsState = {
        name: 'addSchool',
        url: '/admin/schools/add',
        templateUrl: '/app/views/admin/schools/add.html'        
    };

    var confirmAccountState = {
        name: 'confirmAccount',
        url: '/account/confirm:code',
        templateUrl: '/app/views/account/confirm.html'
    };

    $stateProvider.state(loginState);
    $stateProvider.state(aboutState);
    $stateProvider.state(schoolListState);
    $stateProvider.state(addSchoolsState);
    $stateProvider.state(confirmAccountState);
});