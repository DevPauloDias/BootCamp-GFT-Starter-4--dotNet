using System;
using static System.Console;
using POO__Extraindo_um_jogo_RPG.src.entities;

namespace POO__Extraindo_um_jogo_RPG
{
class Program
{
    
    static void Main(string[] args)
    {

      
        Hero caracter= choose_caracter();
        if(caracter.name != "Nenhum"){
           startGame(caracter);

        }else{
          WriteLine(" Escolha inválida!!! Encerrando o programa...");
        }
       

    }

    static void startGame(Hero caracter){
       WriteLine($@"
         ****************************************
                ##  Boa escolha! ##
        

            -- Pronto para começar? [S/N]
        ** **************************************");

        string init= ReadLine();

        if(init.ToUpper() =="S"){
          Clear();
          WriteLine(@" 

                  =============================================
                      Seu primeiro desafio é derrotar Tauros!
                  =============================================
          
          
         [Tauros] -- Mostre-me suas habilidades! ");

         WriteLine("\n \n [Pressione M para mostrar suas habilidades.]");
          string showHabilits = ReadLine();

          if(showHabilits.ToUpper() == "M"){
            WriteLine(" ********************************* \n");

              WriteLine("   "+ caracter.attack());
            WriteLine("\n *********************************\n");

              ReadKey();

             
              WriteLine(@"           
                            
           [Tauros] -  kkkk, esperava mais de você, com essas habilidades não derrota niguém.
            -- Ainda assim, quero ver até onde pode ir... Se prepare para a batalha! -- 
              ");
              WriteLine("\n ************************************\n\n");
              WriteLine("\n -- Iniciar batalha? [S/N]\n");
              ReadKey();
            WriteLine(" ************************************");
            WriteLine("\n \n  Versão demo encerrada...\n");
            WriteLine(" ************************************\n\n");

          }else{
            WriteLine(" ************************************\n\n");
            WriteLine(@" Entendo, você não quer mostrar seu potencial...
            -- Porém, você não tem escolha. Se prepare para a batalha! --");
            WriteLine(" ************************************\n\n");
            ReadKey();

            WriteLine("\n  -- Versão demo encerrada...-- ");
          }

        

        }


      
    }

         static Hero choose_caracter(){

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
                 Clear(); 
                
                 return Arus;
                

            }else if (choose ==2){

                White_Wizard Jennica= new White_Wizard("Jennica", 23);
                  WriteLine($"You choose the caracter {Jennica.name}"); 
                   ReadKey();
                   introduce= Jennica.Introduce(Jennica);
                 WriteLine(introduce); 
                 ReadKey(); 
                  Clear();  
                
                 return Jennica;
            } else if(choose == 3){
                Black_Wizard Topapa= new Black_Wizard("Topapa", 23);
                  WriteLine($"You choose the caracter {Topapa.name}"); 
                   ReadKey();
                   introduce= Topapa.Introduce(Topapa);
                 WriteLine(introduce); 
                 ReadKey();  
                  Clear(); 
                
                 return Topapa;


            }else if(choose ==4){
                Ninja Wedge= new Ninja("Wedge", 23);
                  WriteLine($"You choose the caracter {Wedge.name}"); 
                   ReadKey();
                   introduce= Wedge.Introduce(Wedge);
                 WriteLine(introduce); 
                 ReadKey(); 
                  Clear();  
              
                 return  Wedge;

            }
            Hero hero= new Hero();
            hero.name= "Nenhum";
              return hero;           
            
        }
      
    }
}
