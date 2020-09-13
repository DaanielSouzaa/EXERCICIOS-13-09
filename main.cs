using System;

class NovaConta{

    public string nome;
    public int conta;
    public double saldo = 0.0;

    public string AlteraNome (string novoNome) {
      if (nome != novoNome){
        nome = novoNome;
        return "Nome alterado com sucesso!";
      } else {
        return "Mesmo nome detectado!";
      }
    }

    public int Saque(double novoSaque) {
      if(saldo - novoSaque < 0) {
        return 0;
      } else {
        saldo = saldo - novoSaque;
        return 1;
      }
    }

    public int Deposito(double novoDep) {
      saldo = saldo + novoDep;
      return 1;
    }
  }

class MainClass {

  public void Operacoes () {
    NovaConta Novo = new NovaConta();
    Console.WriteLine(Novo.saldo);
  }

}