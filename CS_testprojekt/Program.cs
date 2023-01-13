using System;
using CS_testprojekt;
using CS_testprojekt.Dice;



var calc = new Calculator();

var addResult = calc.Add(1, 2);
var multiplyResult = calc.Multiply(5, 44);


Console.WriteLine($"Tjenare, din +uträkning blev: {addResult}");
Console.WriteLine($"Tjenare, din *uträkning blev: {multiplyResult}");

// Testa randomvärdena


Dice r = new Dice(3,"hej");

        int total = Dice.totalThrows;

            Dice.totalThrows = 33;

Console.WriteLine($"random siffra: {Dice.trowDice(3,6)}");
