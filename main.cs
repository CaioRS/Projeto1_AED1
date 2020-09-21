using System;

class MainClass {

  
  public static void Main (string[] args) {
   /* Aplicativo com objetivo de começar um atendimento entre paciente e medico que estão impossibilitados de ir a UPA devido a pandemia.*/
    int menu = 0;
    string texto;
    int numero;
    
    //declaração e iniciação do paciente
      paciente paciente1 = new paciente();
      paciente1.PegaNome("CAIO");
      paciente1.PegaIdade(25);
      paciente1.PegaContato("99771-8198");
      paciente1.PegaCidade("Serra");
      paciente1.PegaSintoma1("Febre");
      paciente1.PegaSintoma2("Tosse");
      paciente1.PegaSintoma3("Falta de Ar");

    //declaração e iniciação da doença1
      doença doença1 = new doença();
      doença1.PegaNome("COVID-19");
      doença1.PegaSintoma1("Febre");
      doença1.PegaSintoma2("Tosse");
      doença1.PegaSintoma3("Falta de Ar");
      doença1.PegaTratamento("Até o momento, não há vacinas ou medicamentos específicos para a COVID-19");
      doença1.PegaPrevencao1("LAVE as mãos com frequência");
      doença1.PegaPrevencao2("Utilize alcool em gel nas mãos");

    //declaração e iniciação da doenca2
      doença doença2 = new doença();
      doença2.PegaNome("GRIPE");
      doença2.PegaSintoma1("Febre");
      doença2.PegaSintoma2("Tosse");
      doença2.PegaSintoma3("Espirro");
      doença2.PegaTratamento("Medicamentos que controlam a tempratura corporal e aliviam dores de cabeça podem ajudar nos sintomas que desaparecem em até 10 dias");
      doença2.PegaPrevencao1("Tomar a vacina contra Gripe");
      doença2.PegaPrevencao2("Tomar bastante liquido e regime rico em vitamina C");
    //declaração e iniciação do medico
      medico medico1 = new medico();
      medico1.PegaNome("Dra Karla");
      medico1.PegaContato("99791-7298");
      medico1.PegaCidade("Serra");
    
    //declaração e iniciação da UPA
      upa upa1 = new upa();
      upa1.PegaCidade("Serra");
      upa1.PegaContato("3341-2320");
      upa1.PegaBairro("Barcelona");

    
    //menu de inicio do aplicativo
    do{
      Console.Clear(); 
      Console.WriteLine("Menu de Opçoes:");
      Console.WriteLine("Digite 1 para Cadastro do paciente");
      Console.WriteLine("Digite 2 para visualizar doencas");
      Console.WriteLine("Digite 3 para visualizar medico mais Proximo");
      Console.WriteLine("Digite 4 para visualizar UPA mais proxima");
      Console.WriteLine("Digite 0 para encerrar");
      Console.Write("Operação Escolhida :    ");
      menu = int.Parse(Console.ReadLine());
    
      while (menu != 1 && menu != 2 && menu != 3 && menu != 4 && menu != 0){
        Console.Write ("Numero digitado incorreto, escolha entre as operaçoes:  ");
        menu = int.Parse(Console.ReadLine());
      }

      switch (menu){
        case 1:
          Console.Clear();      
          Console.WriteLine("Menu de Opçoes:");
          Console.WriteLine("Digite 1 para alterar paciente");
          Console.WriteLine("Digite 2 para visualizar paciente");
          menu = int.Parse(Console.ReadLine());
          while (menu != 1 && menu != 2){
            Console.Write ("Numero digitado incorreto, escolha entre as operaçoes:  ");
            menu = int.Parse(Console.ReadLine());
          }
          if(menu==1){
            Console.WriteLine("Digite o nome da Pessoa: ");
            texto = Console.ReadLine();
            paciente1.PegaNome(texto);

            Console.WriteLine("Digite a idade da Pessoa: ");
            numero = int.Parse(Console.ReadLine());
            paciente1.PegaIdade(numero);

            Console.WriteLine("Digite o Contato da Pessoa: ");
            texto = Console.ReadLine();
            paciente1.PegaContato(texto);

            Console.WriteLine("Digite a CIDADE da Pessoa: ");
            texto = Console.ReadLine();
            paciente1.PegaCidade(texto);

            Console.WriteLine("Digite o sintoma 1 da Pessoa: ");
            texto = Console.ReadLine();
            paciente1.PegaSintoma1(texto);

            Console.WriteLine("Digite o sintoma 2 da Pessoa: ");
            texto = Console.ReadLine();
            paciente1.PegaSintoma2(texto);

            Console.WriteLine("Digite o sintoma 3 da Pessoa: ");
            texto = Console.ReadLine();
            paciente1.PegaSintoma3(texto);
          }
          if(menu==2){
            Console.Clear();  
            Console.WriteLine("Nome: {0}", paciente1.NomeAtual());
            Console.WriteLine("Idade: {0}", paciente1.IdadeAtual());
            Console.WriteLine("Contato: {0}", paciente1.ContatoAtual());
            Console.WriteLine("Cidade:  {0}", paciente1.CidadeAtual());
            Console.WriteLine("Sintomas:  {0}, {1} , {2}", paciente1.Sintoma1Atual(),paciente1.Sintoma2Atual(),paciente1.Sintoma3Atual());
            Console.ReadLine();
            Console.Clear(); 
          }
          break; 
        
        case 2:
          Console.Clear();
          Console.WriteLine("Menu de Opçoes:");
          Console.WriteLine("Digite 1 para Comparar os sintomas com o paciente");
          Console.WriteLine("Digite 2 para visualizar tratamento e prevencao");
          menu = int.Parse(Console.ReadLine());
          while (menu != 1 && menu != 2){
            Console.Write ("Numero digitado incorreto, escolha entre as operaçoes:  ");
            menu = int.Parse(Console.ReadLine());
          }
          Console.Clear();
          if(menu==1){
            //Comparaçao com A doenca 1
            Console.WriteLine("COVID-19 : {0}", doença1.CompararSintoma(paciente1.Sintoma1Atual(), paciente1.Sintoma2Atual(), paciente1.Sintoma3Atual()));
            //comparacao com a doenca 2
            Console.WriteLine("Gripe : {0}", doença2.CompararSintoma(paciente1.Sintoma1Atual(), paciente1.Sintoma2Atual(), paciente1.Sintoma3Atual()));
            Console.ReadLine();
          }
          if(menu ==2){
            Console.Clear();
            Console.WriteLine("COVID-19");
            Console.WriteLine("Tratamentos: {0}", doença1.TratamentoAtual());
            Console.WriteLine("Prevencao: {0} , {1}", doença1.Prevençao1Atual(), doença1.Prevençao2Atual());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("GRIPE");
            Console.WriteLine("Tratamentos: {0}", doença2.TratamentoAtual());
            Console.WriteLine("Prevencao: {0} , {1}", doença2.Prevençao1Atual(), doença2.Prevençao2Atual());
            Console.ReadLine();
          }
          break; 
        
        case 3:
          Console.Clear();
          medico1.MedicoProximo(paciente1.CidadeAtual());
          Console.ReadLine();
          break; 
        
        case 4:
          Console.Clear();
          upa1.UpaProxima(paciente1.CidadeAtual());
          Console.ReadLine();
          break;
        
        case 0:
          Console.Clear();
          Console.WriteLine("Fique bem e se cuide, até a próxima !!!");
          Console.ReadLine();
          menu = 0;
          break;
      }

    }while(menu!=0);

  }
}