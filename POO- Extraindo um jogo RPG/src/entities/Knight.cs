namespace POO__Extraindo_um_jogo_RPG.src.entities
{
    public class Knight : Hero
    {    
     
        public Knight(string name, int level){
             this.name= name;
            this.level= level;
            this.heroType= "Knight";  
            hp= 469;
            Mp= 72;
        }
      
        public override string attack(){
            powerAttack= 8;
            return $"{this.name} Attacked with his sword! Damage to Enemy: -{powerAttack} HP";
        }

        
    }
}