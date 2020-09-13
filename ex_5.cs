using System;

class NovaConta{

    public string nome;
    public int conta;
    public double saldo = 0.0;

    public void Atributos(string novoNome,int numConta) {
      nome = novoNome;
      conta = numConta;
    }

    public string AlteraNome (string NovoNome) {
      if (nome != NovoNome){
        nome = NovoNome;
        return "Nome alterado com sucesso!";
      } else {
        return "Mesmo nome detectado!";
      }
    }

    public int Saque(double NovoSaque) {
      if(saldo - NovoSaque < 0) {
        return 0;
      } else {
        saldo = saldo - NovoSaque;
        return 1;
      }
    }

    public int Deposito(double NovoDeposito) {
      saldo = saldo + NovoDeposito;
      return 1;
    }
  }

class MainClass {
  public static void ExibeMenu() {
    Console.WriteLine("Opções");
    Console.WriteLine("1 - Alteração cadastral");
    Console.WriteLine("2 - Saque");
    Console.WriteLine("3 - Depósito");
  }

  public static void Operacoes () {
    NovaConta Novo = new NovaConta();
    Novo.Atributos("Daniel",0001);

    string operacao = "s";
    int opcao = 0;
    double value = 0.0;
    string NovoNome = "";

    while (operacao == "s") {
      int result = 3;
      double NovoSaque = 0.0;
      double NovoDeposito = 0.0;

      Console.WriteLine("Escolha uma opção");
      ExibeMenu();
      opcao = int.Parse(Console.ReadLine());
      if (opcao == 1) {
        Console.WriteLine("Digite o novo nome:");
        NovoNome = Console.ReadLine();
        Novo.AlteraNome(NovoNome);
        if (result == 1) {
          Console.WriteLine("Nome alterado com sucesso!");
        }
      } else if (opcao == 2) {
        Console.WriteLine("Digite o Valor a ser sacado:");
        if (!double.TryParse(Console.ReadLine(), out NovoSaque)) {}
        result = Novo.Saque(NovoSaque);
        if (result == 1) {
          Console.WriteLine("Saque realizado com sucesso!");
        } else {
          Console.WriteLine("Saldo insuficiente!");
        }
      } else if ( opcao == 3) {
        Console.WriteLine("Digite o Valor a ser depositado:");
        if (!double.TryParse(Console.ReadLine(), out NovoDeposito)) {}
        result = Novo.Deposito(NovoDeposito);
        if (result == 1) {
          Console.WriteLine("Depósito realizado com sucesso!");
        } else {
          Console.WriteLine("Erro!");
        }
      } else {
        Console.WriteLine("Opção Inválida!");
      }

      Console.WriteLine("Deseja realizar outra operacao? Digite s para continuar ou qualquer tecla para sair.");
      operacao = Console.ReadLine();
    }

    Console.WriteLine("Nome: {}",Novo.nome);
    Console.WriteLine("Conta: {}",Novo.conta);
    Console.WriteLine("Saldo Final:{}",Novo.saldo);
  }

  public static void Main () {
    Operacoes();
  }

}