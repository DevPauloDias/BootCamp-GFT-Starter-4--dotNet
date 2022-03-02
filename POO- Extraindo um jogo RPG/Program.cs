using System;
using static System.Console;
using POO__Extraindo_um_jogo_RPG.src.entities;

namespace POO__Extraindo_um_jogo_RPG
{
    class Program
    {
       
        static void Main(string[] args)
        {

          White_Wizard teste= new White_Wizard("Alisha",21);
          Clear();
          WriteLine(teste.attack());
          WriteLine(teste.attack(30));
          ReadKey();
           choose_caracter();

        }

         static void choose_caracter(){

            string introduce;
          
            int choose; 
            Clear();

            WriteLine(" \n ----------------------------------- \n");
            WriteLine("      =  Welcome to Game = \n");
            WriteLine(" \n ----------------------------------- \n");
            WriteLine("  ****  Choose your Hero! **** \n");
            WriteLine($@" [1] - Arus = The Knight hero!");
            WriteLine($@" [2] - Jennica = The White Wizard!");
            WriteLine($@" [3] - Totapa = The Black Wizard!");
            WriteLine($@" [4] - Wedge = The Black Wizard!");
             choose= int.Parse(ReadLine());


              if(choose == 1){
                 Knight Arus= new Knight( "Arus",23);
                  WriteLine($"You choose the caracter {Arus.name}"); 
                  ReadKey();  
                  
                 introduce= Arus.Introduce(Arus);
                 WriteLine(introduce);
                 ReadKey(); 
                 WriteLine(" Continue....");
                

            }else if (choose ==2){

                White_Wizard Jennica= new White_Wizard("Jennica", 23);
                  WriteLine($"You choose the caracter {Jennica.name}"); 
                   ReadKey();
                   introduce= Jennica.Introduce(Jennica);
                 WriteLine(introduce); 
                 ReadKey();  
                 WriteLine(" Continue....");
            } else if(choose == 3){
                Black_Wizard Topapa= new Black_Wizard("Topapa", 23);
                  WriteLine($"You choose the caracter {Topapa.name}"); 
                   ReadKey();
                   introduce= Topapa.Introduce(Topapa);
                 WriteLine(introduce); 
                 ReadKey();  
                 WriteLine(" Continue....");


            }else if(choose ==4){
                Ninja Wedge= new Ninja("Wedge", 23);
                  WriteLine($"You choose the caracter {Wedge.name}"); 
                   ReadKey();
                   introduce= Wedge.Introduce(Wedge);
                 WriteLine(introduce); 
                 ReadKey();  
                 WriteLine(" Continue....");

            }else{
                WriteLine(" -- Choose a value Hero... --");
            }
            
        }
      
    }
}
