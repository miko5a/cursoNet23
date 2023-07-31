using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjmploFuncAction
{
    internal class Ejemplo
    {
        private readonly  Action<string> _action;
        public Action<int> AccionProperty { get; set; }
        public void EjemploAction()
        {
            // LLamar a TestAction pasandole metodo como parametro
            TestAction(AccionMetodo, 5);

            // Llamar a TestAction escribiendo la expresion lambda
            // como parametro entre los dos parentesis

            TestAction((x) => Console.WriteLine($"En el metodo Accion {x}"), 1);

            //1-Crear una variable que almacene la accion
            // 2-Llamar a TestAction pasandole la variable y el valor1

            Action<int> accion = (y) => 
            {
                Console.WriteLine($"En el metodo Accion {y}");
            };

            TestAction(accion, 3);


            List<Action<int>> listaactions = new List<Action<int>>();

            listaactions.Add(accion);
            listaactions.Add(AccionMetodo);

            foreach (var elementoAccion in listaactions)
            {
                elementoAccion(1);
            }
        }

        // Metodo que recibe un Action<int> y un int
        //public void TestAction(.....)
        //

        public void TestAction (Action<int> accion, int numero)
        {
            accion(numero);
        }

        public void AccionMetodo(int numero)
        {
            Console.WriteLine($"En el metodo Accion {numero}");
        }


        internal void EjemploFunc()
        {
            // Expresion Lambda mediante Func<>

            Func<string> holaMundoExpresion =

                // Parametros
                ()
                // Operador Lambda
                =>
                //Delegado /Metodo anonimo / Expresion
                "Hola Mundo!!";

            Console.WriteLine(holaMundoExpresion());


            Func<string> holaMundoBloque = () =>
            {
                var cadena = "Hola";
                return cadena;
            };

            Console.WriteLine(holaMundoBloque());

            // Crear una expresion lamda sume dos numero
            // Console.WriteLine(sumar(10, 20));

            Func<int, int, int> sumarValores =

                // Parametros
                (a, b)
                // Operador Lambda
                =>
                // Delegado
                {
                    return a + b;
                };

            Console.WriteLine(sumarValores(10, 20));

        }
    }
}
