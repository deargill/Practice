using MyLibraryClass;

CoffeeMachine coffeeMachine = CoffeeMachine.getState();

coffeeMachine.addWater();
coffeeMachine.addCoffeeBeans();

coffeeMachine.makeCoffee();

coffeeMachine.coffeeMachineState();