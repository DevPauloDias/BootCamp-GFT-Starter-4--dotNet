namespace types_CSharp
{
    public class Pessoa
    {
       public string nome;
        public int idade;
       public string documento;

       public Pessoa Clone(){

                return new Pessoa(){
                        nome= this.nome,
                        idade= this.idade,
                        documento= this.documento
                 };

            }

        // public Pessoa(string nome, int idade, string documento){
        //     this.nome= nome;
        //     this.idade= idade;
        //     this.documento= documento;
        // }

    }
}