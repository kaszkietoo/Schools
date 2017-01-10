var schoolsModule = angular.module("schools", ['ui.router']);

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

    $stateProvider.state(loginState);
    $stateProvider.state(aboutState);
});