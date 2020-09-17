using System;

class upa {

//Declaraçao dos atributos da classe
  private string bairro;
  private string contato;
  private string cidade;

//sets  
   public void PegaBairro (string NovoBairro){
    bairro = NovoBairro;
  }

  public void PegaContato (string NovoContato){
    contato = NovoContato;
  }

  public void PegaCidade (string NovaCidade){
    cidade = NovaCidade;
  }

//Gets
  public string BairroAtual(){
    return bairro;
  }

  public string ContatoAtual(){
    return contato;
  }

  public string CidadeAtual(){
    return cidade;
  }
//Metodo
  public void UpaoProxima(string c1){
    if(c1 == cidade){
      Console.WriteLine("A upa no bairro{0} fica na sua cidade, ligue para o numero {1}", bairro, contato);
    }
  }

}  