using static System.Console;

namespace POO__Extraindo_um_jogo_RPG.src.entities
{
    
     public abstract class Hero
    {
        public string name;
        public int level;
       public string heroType;
       public int hp;
       public int Mp;
       public int powerAttack;

        public Hero(string name, int level, string heroType){
            this.name= name;
            this.level= level;
            this.heroType= heroType;                
        }  

        public Hero(){

        }     

        public override string  ToString(){
            return this.name + " "+ this.level + " "+ this.heroType;
        }

        public  virtual string attack(){
            
            return this.name + " Atacou ";
        }

        public  string Introduce(Knight caracter){

            return $" \n Hi!! My name's {caracter.name}, i'm a {caracter.heroType}. Let's go to the Next Challeng!!! \n --------------------------------------------------------------------------- \n";
            
        }
         public  string Introduce(Black_Wizard caracter){

            return $" \n Hi!! My name's {caracter.name}, i'm a {caracter.heroType}. Let's go to the Next Challeng!!! \n --------------------------------------------------------------------------- \n";
            
        }
        public  string Introduce(Ninja caracter){

            return $" \n Hi!! My name's {caracter.name}, i'm a {caracter.heroType}. Let's go to the Next Challeng!!! \n --------------------------------------------------------------------------- \n";
            
        }
        public  string Introduce(White_Wizard caracter){

            return $" \n Hi!! My name's {caracter.name}, i'm a {caracter.heroType}. Let's go to the Next Challeng!!! \n --------------------------------------------------------------------------- \n";
            
        }

    }
    
}