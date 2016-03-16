/**
 * Created by Cameron on 3/12/2016.
 */
bugTrackerApp.controller('dashboardController', function($scope, $resource) {
   var issue = $resource('http://localhost:8081/issues/:id');

    issue.query().$promise.then(function(issues) {
        $scope.issues = issues;
        console.log('issues are ' + issues);
    }, function(errResponse) {
        console.log(errResponse);
    })
});

