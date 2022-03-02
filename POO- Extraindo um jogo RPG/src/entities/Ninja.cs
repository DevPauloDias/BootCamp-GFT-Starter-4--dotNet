namespace POO__Extraindo_um_jogo_RPG.src.entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level){

             this.name= name;
            this.level= level;
            this.heroType= "Ninja";  
            hp= 292;
            Mp= 89;
        }
        public override string attack(){
            powerAttack= 6;
            return $"{this.name} Attacked with his sword! Damage to Enemy: -{powerAttack} HP";
        }
    }
}