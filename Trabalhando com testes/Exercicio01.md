# Trabalhando com testes

1. Quais os principais frameworks que podemos usar no desenvolvimento de testes?
Basicamente os testes são feitos através de frameworks de testes e de mocking (que evitam a criação de classes "fake").
Dos frameworks de teste, os mais famosos são XUnit e NUnit. A Microsoft também mantém o MSTest. Todos seguem uma sintaxe básica muito semelhante, 
mudando apenas a nomenclatura de alguns atributos. Conforme o uso se especializa, a diferença entre eles aumenta.
Para mocking, temos o Moq e NSubstitute. Ambos são muito parecidos.

2. Escolha dois frameworks e faça testes unitários para pelo menos dois exercícios em cada framework.
Foram feitos testes utilizando o XUnit e o MSTest
- XUnit
+ ./"Utilizando POO"/exercicio03/ContaBancariaXUnitTest

- MSTest
+ ./"Utilizando POO"/exercicio04/SalaDeEstar.Test
+ ./trabalhado-no-console/exercicio04/AlunoMSTest