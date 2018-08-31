using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_19_orientacao_a_objetos_permissoes_e_agrupam
{
    class Program
    {

        /*sealed class Animal                                       // classe selada, nenhuma outra classe pode herdar dela.
        {
            public string teste;

            public sealed string teste2()
            {
                return "";
            }

        }

        class Macaco : Animal
        {
            public string teste2()
            {
                return "sss";
            }
        }*/

        partial class Animal
        {
            public string teste;
            partial void tt();
            //public partial void tt();      // nao pode deixar como publico, tem que ser private
        }

        partial class Animal
        {
            public string teste2;
            partial void tt()
            {
                Console.WriteLine("testeee");
            }
        }





        static void Main(string[] args)
        {
            var a = new Animal();
            a.teste = "dfdfs";
            a.teste2 = "dsadsa";
        }
    }
}
