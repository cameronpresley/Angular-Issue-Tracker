/**
 * Created by Cameron on 3/12/2016.
 */
bugTrackerApp.controller('dashboardController', function($scope) {
   $scope.issues = [
       {'title': 'First Issue', 'description':'Sample First Description'},
       {'title': 'Second Issue', 'description':'Sample Second Description'},
       {'title': 'Third Issue', 'description':'Sample Third Description'},
   ];
});

