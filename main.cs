using System;

class Pessoa {

   public string nome;
   public int idade;
   public double peso,altura,teste,pesoNovo,pesoAtual;
 
   public void Envelhece(double idade,double altura) {  
    if (idade < 21){
      altura = altura + 0.5;      
    }
    idade +=1;   
    Console.WriteLine("Idade :  {0} \nAltura: {1}" ,idade , altura);
 
  }
   public double Engorda(double pesoNovo,double pesoAtual) {
      peso = pesoAtual + pesoNovo;
      return peso;    
  }
    public double Emagrece(double pesoNovo,double pesoAtual) {
      peso = pesoAtual - pesoNovo;
      return peso;    
  }
    
   //FUNÇÃO MOSTRAR O NOVO RESULTADO
   public void Exibir(string nome, int idade, double peso,double altura){
    Console.WriteLine("Nome: {0}, idade: {1}, peso: {2}, altura: {3}", nome, idade, peso, altura);
    Console.WriteLine("---------1 ano se passou----------");
    Console.WriteLine("Nome:"+ nome);
    Envelhece(idade,altura);
    Console.WriteLine("Peso atual: " + Emagrece(10,peso));

  }

  public static void Main (string[] args) {
    Pessoa Entrada = new Pessoa(); 
    Entrada.Exibir("Daniel",24,80,1.74);
  }

}