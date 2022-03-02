namespace POO__Extraindo_um_jogo_RPG.src.entities
{
    public class White_Wizard : Hero
    {
        public White_Wizard(string name, int level){
             this.name= name;
            this.level= level;
            heroType= "White_Wizard"; 
            hp= 325;          
            Mp= 474;

        }
        public White_Wizard(){}

        public override string attack(){
            powerAttack= 5;
             return this.name + $" Attacked with his magic! Damage to enemy: -{powerAttack} HP";
        }

        public string attack(int bonus){
            return this.name + $" Lance a Super Attack, with a bonus of {bonus} ";
        }
        
    }
}