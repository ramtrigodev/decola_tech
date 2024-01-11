using exemplo_poo.Models;
/*
Pessoa p1 = new Pessoa();
p1.Nome = "Ramon Trigo";
p1.Idade = "39";

p1.Apresentar();
*/

ContaCorrente c1 = new ContaCorrente(123,1000);
c1.ExibirSaldo();
c1.Sacar(500);
c1.ExibirSaldo();