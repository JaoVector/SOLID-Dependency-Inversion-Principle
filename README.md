# SOLID Dependency Inversion Principle
Este projeto tem o objetivo de implementar o Quinto princípio de SOLID.

## O que é DIP?
Quando se desenvolve uma aplicação se faz necessária a divisão dos blocos de código por módulos, os módulos podem ser classificados em alto nível e baixo nível.

Os módulos de alto nível possuem uma complexidade maior de código, e suas operações são detalhadas, diferentemente dos módulos de baixo nível, que possuem operações simples e específicas para serem utilizadas pela aplicação. Assim os módulos de alto nível são os que cuidam de orquestrar os de baixo nível.

Agora o princípio de inversão de dependência aborda a ideia de que os módulos de alto nível devem conter a lógica mais complexa e inalterada, não dependendo dos módulos de baixo nível, trazendo assim um desacoplamento, e também que ambos os módulos devam depender de abstrações.

Essas abstrações vão ser importantes no momento da estruturação do código, pois elas vão possuir os detalhes para ser feito o desacoplamento entre os módulos de baixo e alto nível.

## Para mais detalhes acesse o artigo abaixo:
[Artigo Dependency Inversion Principle](https://medium.com/@JoaoVictorCarneiroAureliano/dependency-inversion-principle-dip-84dec0323ec7)
