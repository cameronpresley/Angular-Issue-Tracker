bugTrackerApp.controller('addIssueController', function($scope) {
    $scope.issue = {}
    $scope.addIssue = function(issue, newIssueForm) {
        if (newIssueForm.$valid) {
            alert(issue.title + " and " + issue.description);
        }
    }
});
