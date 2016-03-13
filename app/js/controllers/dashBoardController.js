/**
 * Created by Cameron on 3/12/2016.
 */
var bugTrackerApp = angular.module('bugTrackerApp', []);

bugTrackerApp.controller('issueController', function($scope) {
   $scope.issues = [
       {'title': 'First Issue', 'description':'Sample First Description'},
       {'title': 'Second Issue', 'description':'Sample Second Description'},
       {'title': 'Third Issue', 'description':'Sample Third Description'},
   ];
});