using System;

namespace Praticando_C_
{
    class Program
    {
       static Aluno[] alunos= new Aluno[5];
       static int indiceAluno= 0; 

        static void Main(string[] args)
        {

            int opcUsuario= Menu(); 
                      


            while(opcUsuario != 4 ){

                switch(opcUsuario){

                    case 1 : 
                        Cadastrar();
                    break;

                    case 2 : 
                        Listar();
                    
                    break;

                    case 3:
                        Media();

                    break;  

                    default: 
                    throw new ArgumentOutOfRangeException();    
                    
                }
                Console.WriteLine("------------------------\n");

             opcUsuario= Menu();
            }
        }

        static void Cadastrar(){
            Aluno aluno = new Aluno();

            Console.WriteLine("Informe o nome do novo aluno:");
            aluno.nome= Console.ReadLine();

            Console.WriteLine("Informe a nota do aluno: ");
           if( decimal.TryParse(Console.ReadLine(), out decimal nota)){
                aluno.nota= nota;
           }else {
               throw new ArgumentException(" Valor da nota deve ser decimal");
           }
            
            alunos[indiceAluno]= aluno; 
            
            indiceAluno++;

            Console.WriteLine(" \n - Aluno cadastrado com sucesso! -\n ");

            Console.ReadKey();       

        }


         static void Listar(){

            Console.Clear();

            for (int cont=0; cont < alunos.Length; cont ++)
            {
                if (alunos[cont] != null)
                {
                    

                    Console.WriteLine($"\n Aluno: {alunos[cont].nome} -  Nota: {alunos[cont].nota}\n");
                }
                
            }
            Console.ReadKey();

            
        }

        static void Media(){

            decimal somaNotas=0;

            for(int cont=0; cont < alunos.Length; cont++){

                if(alunos[cont] !=null){
                    somaNotas= alunos[cont].nota;
                }
               
            }

            decimal media = somaNotas/ alunos.Length;

            Console.WriteLine(media);
        }

        static void Sair(){
            Console.WriteLine(" Encerreando o programa...");
            
        }
        static int  Menu(){
            Console.Clear();
            Console.WriteLine("------------------------------- \n");
            Console.WriteLine(" Informe a opção desejada:");
            Console.WriteLine(" 1- Cadastrar aluno ");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Média geral");
            Console.WriteLine("4 - sair");
            Console.WriteLine("\n------------------------------- \n");

            int opcUsuario= int.Parse(Console.ReadLine());

            return opcUsuario;

        }
    }
}
