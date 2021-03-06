using System;
using static System.Console;


namespace types_CSharp
{
    class Program
    {

        static void demo1_referenceType(){

             Pessoa p1= new Pessoa();
             p1.nome= "paulo";
             p1.idade= 22;
             p1.documento= "2345";
            
            WriteLine($"\n Dados atuais: \n Nome: {p1.nome}");
             WriteLine(" ------------------------------------\n");
            ReadKey();
            Clear();

            // Passagem por referência da instância de p1
            Pessoa p2 = p1;

            alterarNome(p1);
             Clear();
             
            WriteLine($@" Novos dados: 

                Nome: {p1.nome}
                Nome: {p2.nome}");
            // Os nomes printados são iguais pois a referência da instância é a mesma (armazenada na heap)
           ReadKey();
            

        }
       
       
       static void demo2_valueType(){

           Pessoa p1= new Pessoa();
             p1.nome= "paulo";
             p1.idade= 22;
             p1.documento= "2345";
           

            WriteLine($"\n Dados atuais: \n Nome: {p1.nome}");
             WriteLine(" ------------------------------------\n");
            ReadKey();
            Clear();

            // Passa p1 por valor e não como referência
            Pessoa p2 = p1.Clone();

            alterarNome(p1);
             Clear();
             
            WriteLine($@" Novos dados: 

                Nome: {p1.nome}
                Nome: {p2.nome}");
                // Os nomes printados são diferentes pois a referencia da instância não é a mesma
           
           ReadKey();          

       }
      
      
       static void demo3_struct_valueType(){
           structPessoa p1= new structPessoa{

                documento= "123",
                nome= "ricardo",
                idade= 22
            };

            WriteLine($"O nome atual de p1 é: {p1.nome}");

            var p2= p1;
            
            p1= alterarNome(p1);

            WriteLine($@"
                 O nome de p1 é: {p1.nome}
                 O nome de p2 é: {p2.nome}");


       }
        
       static void alterar_array(string[] nomes, string nome, string novoNome){
           for( int i=0; i < nomes.Length; i++){
               if(nomes[i] == nome){
                   nomes[i]= novoNome;
               }
           }
       }
        static void Main(string[] args)
        {
            var nomes= new string[] {"paulo", "felipe"," Maria", "Beatriz"};

            WriteLine($@" 
               Lista atual:
            {string.Join(",\n", nomes)}");

            WriteLine($" Digite o nome a ser substituido:");
            string nome= ReadLine();
            Clear();
            WriteLine(" Informe o novo nome:");
            string novoNome= ReadLine();

            alterar_array(nomes, nome, novoNome);


            Clear();

            WriteLine($@"lista modificada:
            {string.Join(",\n", nomes)}");

        }
        static void  alterarNome(Pessoa p1){
            WriteLine("Informe o novo nome: ");
            p1.nome = ReadLine();            

            WriteLine(" --------------------------------\n");

        }
        static structPessoa  alterarNome(structPessoa p1){
            WriteLine("Informe o novo nome: ");
            p1.nome = ReadLine();            

            WriteLine(" --------------------------------\n");
            return p1;

        }
    }
}
