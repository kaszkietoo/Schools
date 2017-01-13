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
        templateUrl: '/app/views/admin/schools/list.html',
        params: { needsAdmin: true }
    };

    var addSchoolsState = {
        name: 'addSchool',
        url: '/admin/schools/add',
        templateUrl: '/app/views/admin/schools/add.html',
        params: { needsAdmin: true }
    };

    $stateProvider.state(loginState);
    $stateProvider.state(aboutState);
    $stateProvider.state(schoolListState);
    $stateProvider.state(addSchoolsState);
});