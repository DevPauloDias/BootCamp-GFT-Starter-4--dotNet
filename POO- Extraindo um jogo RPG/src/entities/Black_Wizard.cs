namespace POO__Extraindo_um_jogo_RPG.src.entities
{
    public class Black_Wizard : Hero
    {
         public  Black_Wizard(string name, int level){
             this.name= name;
            this.level= level;
            heroType= "Black_Wizard"; 
            hp= 325;          
            Mp= 474;

        }
        public Black_Wizard(){}

        public override string attack(){
            powerAttack= 5;
             return this.name + $" Attacked with his Black Magic! Damage to enemy: -{powerAttack} HP";
        }
    }
}