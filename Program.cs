//var calc=new Calculadora(); error

Console.WriteLine(Calculadora.Sumar(4,4));
Console.WriteLine(Calculadora.Sumar(2,3)); 
Console.BackgroundColor=ConsoleColor.DarkGreen;
var obj1=new ClaseNormal();
Console.WriteLine(obj1.Sumar(4,4));
var obj2=new ClaseNormal();
Console.WriteLine(obj2.Sumar(2,3));
Console.BackgroundColor=ConsoleColor.Black;
Console.WriteLine(Math.Exp(2));

static class Calculadora{
    public static bool Operacion;
    static Calculadora(){
        Operacion=true;
        var i=1+3;
        var resultado=i *2;
    }
    public static int Sumar(int a, int b){
        if(Operacion==true){
            Operacion=false;
            return a * b;
        } 
        else{
            return a + b;
        }
            
    }
}


public class ClaseNormal{
    public bool Operacion{get;set;}
    public ClaseNormal( ){
        //Inicializacion
        Operacion=true; 
    }

    public int Sumar(int a,int b){
        if(Operacion==true){
            Operacion=false;
            return a * b;
        } 
        else{
            return a + b;
        }
    }
}