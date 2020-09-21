using System;

class doença {

// Declaraçao dos atributos da classe
  private string nome;
  private string sintoma1;
  private string sintoma2;
  private string sintoma3;

  private string tratamento;

  private string prevencao1;
  private string prevencao2;


//Sets
  public void PegaNome (string NovoNome){
    nome = NovoNome;
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

  public void PegaTratamento (string NovoTratamento){
    tratamento = NovoTratamento;
  }

  public void PegaPrevencao1 (string NovaPrevenção){
    prevencao1 = NovaPrevenção;
  }

  public void PegaPrevencao2 (string NovaPrevenção){
    prevencao2 = NovaPrevenção;
  }

//Gets
  public string NomeAtual(){
    return nome;
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

  public string TratamentoAtual(){
    return tratamento;
  }

  public string Prevençao1Atual(){
    return prevencao1;
  }

  public string Prevençao2Atual(){
    return prevencao2;
  }


//Métodos
  public string CompararSintoma (string s1 , string s2 , string s3){

    if( (sintoma1 == s1 || sintoma1 == s2 || sintoma1 == s3) && (sintoma2 == s1 || sintoma2 == s2 || sintoma2 == s3) && (sintoma3 == s1 || sintoma3 == s2 || sintoma3 == s3) ){ // compara os sintomas enviados com os sintomas definidos da doenca

      return "Sintomas se encaixam com esta doenca";
    }

    else {
      return "Esta doenca nao se encaixa aos sintomas";
    }
  }










}