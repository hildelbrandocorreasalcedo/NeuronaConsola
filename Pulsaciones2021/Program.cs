using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulsaciones2021
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] X1 = new int[] { 1, 0 };
            int[] X2 = new int[] { 1, 0 };

            //int numero = X2.Length;
            //Console.WriteLine($"\n Cantidad de patrones es: {X2.Length}");

            var W11 = -1;
            var W21 = -1;

            var ErrorMax = 0;
            
            var YR1 = 0;
           
            var Elineal1 = 0;
            var Elineal2 = 0;
            var EP1 = 0;
            var EP2 = 0;
            int RA = 1;

            var YR = 1;
            int[] YD1 = new int[2];
            YD1[0] = 1;
            YD1[1] = 0;

            var Soma = 0;

            float ERMS = 0;
            int iteraciones = 1;
            //for (int j = 1; j <= numero; j++)
            //{
            //}
            Console.Write("********************************Ejercicio de Neurona ******************************* ");

            // SI ERMS<= ERROR MAXIMO PERMITIDO(CONDICION PRINCIPAL PARA CULMINAR EL
            //ENTRENAMIENTO DE UNA RED NEURONAL)
            do
            {
                Console.Write($"\n * *******************                iteracion {iteraciones}                          *********************** ");
                Console.WriteLine($"\n Patron 1       X1: { X1[0] }");
                Console.WriteLine($"\n Patron 1       X2: { X2[0] }");

                Soma = (X1[0] * W11 + X2[0] * W21);

                Console.WriteLine($"\nPRIMERO SE CALCULA LA SALIDA DE LA FUNCION SOMA");
                Console.WriteLine($"\n Soma es: {Soma}");

                Console.WriteLine($"\n APLICANDO LA FUNCION DE ACTIVACION RAMPA");
                Console.WriteLine($"\n SE CALCULA LA SALIDA DE LA RED NEURONAL");

                if (Soma < 0)
                {
                    YR1 = 0;
                }
                if ((Soma >= 0) && (Soma <= 1))
                {
                    YR1 = X1[0];
                }
                if (Soma > 1)
                {
                    YR1 = 1;
                }
                Console.WriteLine($"\n El resultado de YR es: {YR1}");

                Console.WriteLine($"\n CALCULAR EL ERROR QUE SE PRODUCE A LA SALIDA DE LA RED");
                Console.WriteLine($"Elineal = (YD)SALIDA DESEADA –(YR)SALIDA DE LA RED");
                Elineal1 = YD1[0] - YR1;

                Console.WriteLine($"\n El resultado de Elineal es: {Elineal1}");

                Console.WriteLine($"\n CALCULAR EL ERROR POR PATRON");
                Console.WriteLine($"\nEP =∑| EL |/ NUMERO DE SALIDAS");


                EP1 = Elineal1 / YR;

                Console.WriteLine($"\n El resultado de Error por patron es: {EP1}");


                Console.WriteLine($"\nREALIZAR AJUSTE DE PESOS SINAPTICOS");
                Console.WriteLine($"\nAPLICANDO EL ALGORITMO DE ENTRENAMIENTO: REGLA DELTA");
                Console.WriteLine($"PESO NUEVO = PESO ACTUAL + RATA DE APRENDIZAJE*ERROR LINEAL* ENTRADA");

                W11 = W11 + RA * Elineal1 * X1[0];

                //W11 = (-1) + 1 * 1 * 1
                //W11 = 0
                W21 = W21 + RA * Elineal1 * X2[0];
                //W21 = (-1) + 1 * 1 * 1
                //W21 = 0

                Console.WriteLine($"\n El resultado de PESO NUEVO W11 es: {W11}");
                Console.WriteLine($"\n El resultado de PESO NUEVO W21 es: {W21}");

                //*************************************************************************************************************************************

                Console.WriteLine($"\n Patron 2      X1: { X1[1] }");
                Console.WriteLine($"\n Patron 2      X2: { X2[1] }");

                Soma = (X1[1] * W11 + X2[1] * W21);

                Console.WriteLine($"\nPRIMERO SE CALCULA LA SALIDA DE LA FUNCION SOMA");
                Console.WriteLine($"\n Soma es: {Soma}");

                Console.WriteLine($"\n APLICANDO LA FUNCION DE ACTIVACION RAMPA");
                Console.WriteLine($"\n SE CALCULA LA SALIDA DE LA RED NEURONAL");

                if (Soma < 0)
                {
                    YR1 = 0;
                }
                if ((Soma >= 0) && (Soma <= 1))
                {
                    YR1 = X1[1];
                }
                if (Soma > 1)
                {
                    YR1 = 1;
                }
                Console.WriteLine($"\n El resultado de YR es: {YR1}");

                Console.WriteLine($"\n CALCULAR EL ERROR QUE SE PRODUCE A LA SALIDA DE LA RED");
                Console.WriteLine($"Elineal = (YD)SALIDA DESEADA –(YR)SALIDA DE LA RED");
                Elineal2 = YD1[1] - YR1;

                Console.WriteLine($"\n El resultado de Elineal es: {Elineal2}");

                Console.WriteLine($"\n CALCULAR EL ERROR POR PATRON");
                Console.WriteLine($"\nEP =∑| EL |/ NUMERO DE SALIDAS");


                EP2 = Elineal2 / YR;

                Console.WriteLine($"\n El resultado de Error por patron es: {EP2}");

                Console.WriteLine($"\nREALIZAR AJUSTE DE PESOS SINAPTICOS");
                Console.WriteLine($"\nAPLICANDO EL ALGORITMO DE ENTRENAMIENTO: REGLA DELTA");
                Console.WriteLine($"PESO NUEVO = PESO ACTUAL + RATA DE APRENDIZAJE*ERROR LINEAL* ENTRADA");

                W11 = W11 + RA * Elineal2 * X1[0];

                //W11 = (-1) + 1 * 1 * 1
                //W11 = 0
                W21 = W21 + RA * Elineal2 * X2[0];
                //W21 = (-1) + 1 * 1 * 1
                //W21 = 0

                Console.WriteLine($"\n El resultado de PESO NUEVO W11 es: {W11}");
                Console.WriteLine($"\n El resultado de PESO NUEVO W21 es: {W21}");

                Console.WriteLine($"\n CALCULAMOS EL ERROR ERMS(ERROR DE LA ITERACION)");
                Console.WriteLine($"\n ERMS =∑EP / NUMERO DE PATRONES");

                Console.WriteLine($"\n EP1: {EP1}");
                Console.WriteLine($"\n EP2: {EP2}");

                ERMS = (EP1 + EP2);
                ERMS = ERMS / 2;

                Console.WriteLine($"\n El resultado de EL ERROR ERMS(ERROR DE LA ITERACION) es: {ERMS}");
                iteraciones++;
            } while (iteraciones <= 10 && ERMS > ErrorMax);


            Console.ReadKey();
        }
    }
}
