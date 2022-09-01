using trilha_net_explorando_desafio_hotelaria.Models;

Console.WriteLine("-----------------------------");
Console.WriteLine("-                           -");
Console.WriteLine("-   SISTEMA DE HOTELARIA    -");   
Console.WriteLine("-                           -");
Console.WriteLine("-----------------------------");
Console.WriteLine("");
Console.WriteLine("");

// ADICIONANDO O NUMERO DE HOSPEDES
int numeroDeHospedes = 0;
Console.WriteLine("Insira o número de hóspedes:");
numeroDeHospedes = Convert.ToInt32(Console.ReadLine());
Console.Clear();

List<Pessoa> hospede = new List<Pessoa>();

for (int i = 0; i < numeroDeHospedes; i++)
{
    string nomeHospede = "";
    Console.WriteLine("Digite o nome do hóspede:");
    nomeHospede = Console.ReadLine();

    hospede.Add(new Pessoa(nomeHospede));
    Console.Clear();
}


// ADICIONANDO SUITE

string tipoDaSuite = "";
int capacidade = 0;
decimal valorDiaria = 0;

Console.WriteLine("Insira os dados da Suíte:");

Console.WriteLine("Tipo da Suíte:");
tipoDaSuite = Console.ReadLine();
Console.Clear();

Console.WriteLine("Capacidade da Suíte:");
capacidade = Convert.ToInt32(Console.ReadLine());
Console.Clear();

Console.WriteLine("Valor Diário da Suíte:");
valorDiaria = Convert.ToDecimal(Console.ReadLine());
Console.Clear();

Suite suite = new Suite(tipoSuite: tipoDaSuite, capacidade: capacidade, valorDiaria: valorDiaria);


// CRIANDO RESERVA

int diasReservados = 0;
Console.WriteLine("Insira o número de dia(s) reservados");
diasReservados = Convert.ToInt32(Console.ReadLine());

Reserva reserva = new Reserva(diasReservados: diasReservados);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospede);

Console.WriteLine("RESERVA CRIADA COM SUCESSO");

//MENU

string opcao = string.Empty;
bool exibirMenu = true;

Console.WriteLine("");

while (exibirMenu)
{
     Console.Clear();
     Console.WriteLine("Digite a sua opção:");
     Console.WriteLine("1 - Verifica numero de Hóspedes");
     Console.WriteLine("2 - Calcular o Valor Total:");
     Console.WriteLine("3 - Encerrar");

     switch (Console.ReadLine())
     {
         case "1" :
             Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
             break;
         case "2" :
             Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
             break;
         case "3" :
             exibirMenu = false;
             break;
         default:
             Console.WriteLine("Opção inválida");
             break;
     }
     Console.WriteLine("Pressione uma tecla para continuar");
     Console.ReadLine();

 }

 Console.WriteLine("O programa se encerrou");