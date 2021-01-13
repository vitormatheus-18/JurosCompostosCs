using System; //Biblioteca utilizada
 class JurosCompostos {
    static void Main(string[] args) {
     double CapitalInicial, TaxaJuros, montante, JurosMensal, JurosTotal; 
     int meses;
     
      Console.WriteLine("\n Qual o capital inicial?"); //Recebe o valor para que seja possível realizar o cálculo 
      CapitalInicial = Convert.ToDouble (Console.ReadLine ()); //Faz a conversão do valor recebido 

      Console.WriteLine("\n Qual a taxa de Juros?"); //Recebe o valor de taxa que está presente na fórmula de Juros 
      TaxaJuros = Convert.ToDouble (Console.ReadLine ()); 

      Console.WriteLine("\n Digite a quantidade de meses:"); //Recebe o valor de tempo que está presente na fórmula de Juros 
      meses = Convert.ToInt16 (Console.ReadLine ());

      montante = CapitalInicial;
      JurosTotal = 0;
      for (int i = 1; i <= meses; i++)
      {
        CapitalInicial = montante; //Realiza o cálculo presente na fórmula de Juros compostos: S = P ( 1 + i)^n
        montante = CapitalInicial*(TaxaJuros/100+1);
        JurosMensal = montante - CapitalInicial; 
        JurosTotal = JurosTotal + JurosMensal;
        
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine( i + "º Mês:" + "Capital = " + CapitalInicial + "  -Juros mensal = " + JurosMensal + "  -Juros total = " + JurosTotal + "  -Montante = " + montante + string.Format("{0:N2}"));
       
      }
      Console.ReadKey();

    }

  }

