﻿using exemplo_poo.interfaces;
using exemplo_poo.Models;
/*
Pessoa p1 = new Pessoa();
p1.Nome = "Ramon Trigo";
p1.Idade = "39";

p1.Apresentar();


ContaCorrente c1 = new ContaCorrente(123,1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();


Aluno a1 = new Aluno ();
a1.Nome = "Ramon Trigo";
a1.Idade = 39;
a1.Email = "ramtrigo@hotmail.com";
a1.Nota = 10;
a1.Apresentar();


Corrente c = new Corrente ();
c.Creditar(500);
c.ExibirSaldo();
*/
ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3,9));