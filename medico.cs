using System;

class medico {

//Declaraçao dos atributos da classe
  private string nome;
  private string contato;
  private string cidade;

//sets  
   public void PegaNome (string NovoNome){
    nome = NovoNome;
  }

  public void PegaContato (string NovoContato){
    contato = NovoContato;
  }

  public void PegaCidade (string NovaCidade){
    cidade = NovaCidade;
  }

//Gets
  public string NomeAtual(){
    return nome;
  }

  public string ContatoAtual(){
    return contato;
  }

  public string CidadeAtual(){
    return cidade;
  }
//Metodo
  public void MedicoProximo(string c1){
    if(c1 == cidade){
      Console.WriteLine("O Médico {0} é da sua cidade, ligue para o numero {1}", nome, contato);
    }
    else Console.WriteLine("Nao existem Medicos cadastrados na sua cidade");
  }
}  