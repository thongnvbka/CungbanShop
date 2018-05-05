var myapp = angular.module('myModule', []);

myapp.controller("myController", myController);


myapp.service('Validator', Validator);
myController.$inject = ['$scope', 'Validator'];


function myController($scope, Validator) {

    $scope.mess = Validator.CheckNumber(10);
}

function Validator($window)
{
    function CheckNumber(input) {
        return
        {
            CheckNumber: CheckNumber
        }
        if (input % 2 == 0)
        {
            return ('this is even');
        }
        else
        {
            return ('this is odd');
        }
       
    }
}