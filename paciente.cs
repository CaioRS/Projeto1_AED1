using System;

class paciente {

//Declaraçao dos atributos da classe
  private string nome;
  private int idade;
  private string contato;
  private string cidade;
  private string sintoma1;
  private string sintoma2;
  private string sintoma3;

//sets  
   public void PegaNome (string NovoNome){
    nome = NovoNome;
  }

  public void PegaIdade (int NovaIdade){
    idade = NovaIdade;
  }

  public void PegaSintoma1 (string NovoSintoma){
    sintoma1 = NovoSintoma;
  }
  
  public void PegaSintoma2 (string NovoSintoma){
    sintoma2 = NovoSintoma;
  }

  public void PegaSintoma3 (string NovoSintoma){
  sintoma3 = NovoSintoma;
  }

  public void PegaContato (string NovoContato){
    contato = NovoContato;
  }

  public void PegaCidade (string NovaCidade){
    cidade = NovaCidade;
  }

//gets
  public string NomeAtual(){
    return nome;
  }

  public int IdadeAtual(){
    return idade;
  }

  public string ContatoAtual(){
    return contato;
  }

  public string CidadeAtual(){
    return cidade;
  }

  public string Sintoma1Atual(){
    return sintoma1;
  }

  public string Sintoma2Atual(){
    return sintoma2;
  }

  public string Sintoma3Atual(){
    return sintoma3;
  }

//Método
}