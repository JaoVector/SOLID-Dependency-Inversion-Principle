
using DIP.Classes;
using DIP.Enums;

var violao = new SetorVioloes();

violao.Adiciona(new Violao() { Nome = "Kaiju", Marcas = Marcas.Seizi, ViolaoTipo = ViolaoTipo.Aco });
violao.Adiciona(new Violao() { Nome = "Neo Tokyo", Marcas = Marcas.Seizi, ViolaoTipo = ViolaoTipo.Eletroacustico });
violao.Adiciona(new Violao() { Nome = "Mirai", Marcas = Marcas.Seizi, ViolaoTipo = ViolaoTipo.Eletroacustico });
violao.Adiciona(new Violao() { Nome = "Neo Akira", Marcas = Marcas.Seizi, ViolaoTipo = ViolaoTipo.Aco });

var quantidades = new EstatisticasVioloes(violao);
Console.WriteLine($"Quantidade de Violoes de Aço da Seizi: {quantidades.ContaQuantidadeVioloes(Marcas.Seizi, ViolaoTipo.Aco)}");
Console.WriteLine($"Quantidade de Violoes de Eletroacustico da Seizi: {quantidades.ContaQuantidadeVioloes(Marcas.Seizi, ViolaoTipo.Eletroacustico)}");