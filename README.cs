namespace CP1
{
  internal class Program
  {
    public static void Main(string[] args)
    {	
	  int main(){

	    char operacion;
 	    float num1, num2;
	    bool seguir;
	    do{
      
          Console.WriteLine("Ingrese la operacion a relaizar: |+| |-| |*| |/| |S(salir)|");
          Console.ReadLine();
      
          Console.WriteLine("Ingrese los numeros a operar: ");
          Console.WriteLine("Introdcuce el primer numero que deseas operar:");
          num1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Introdcuce el segundo numero que deseas operar:");
          num2 = Convert.ToInt32(Console.ReadLine());
        
          switch(operacion){
        
           case "+":
           Console.WriteLine(num1+num2);
           break;
        
           case "-":
           Console.WriteLine(num1-num2);
           break;
        
           case "*":
           Console.WriteLine(num1*num2);
           break;
        
           case "/":
           Console.WriteLine(num1/num2);
           break;
          }
	  }while(seguir);
	
	  return 0;
    }
  }
}
