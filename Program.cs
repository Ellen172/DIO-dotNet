// carregando classes
using DioDotNet.models;

Pessoa pessoa1 = new Pessoa();
Pessoa pessoa2 = new Pessoa();

pessoa1.Nome = "João";
pessoa1.Idade = 45;

pessoa2.Nome = "Maria";
pessoa2.Idade = 36;

pessoa1.Apresentar();
pessoa2.Apresentar();