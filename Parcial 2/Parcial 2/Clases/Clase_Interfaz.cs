using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.Clases
{
    class Clase_Interfaz : InterfacePromedio
    {
        public string[,] Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            string[,] Alumn = new string[1, 2];

            int Actual;
            int Mayor = 0;
            int TotalFilas = matriz.GetLength(0);
            int filasSecc = TotalFilas;
            int TotalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < TotalFilas; fila++)
            {

                if (matriz[fila, EnumColumnas.Seccion] == seccion)
                {

                    Actual = Convert.ToInt32(matriz[fila, EnumColumnas.Par1])
                            + Convert.ToInt32(matriz[fila, EnumColumnas.Par2])
                            + Convert.ToInt32(matriz[fila, EnumColumnas.Par3]);



                    if (Mayor > Actual)
                    {
                        Alumn[0, 1] = Mayor.ToString();

                    }
                    else
                    {
                        Alumn[0, 0] = matriz[fila, EnumColumnas.Nombre];
                        Alumn[0, 1] = Actual.ToString();
                        Mayor = Actual;
                    }
                }
            }

            return Alumn;
        }

        public string nombre_nota_mayor(string[,] matriz)
        {
            string nombre = "";

            int actual;
            int mayor = 0;
            int TotalFilas = matriz.GetLength(0);
            int filasSecc = TotalFilas;
            int TotalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < TotalFilas; fila++)
            {

                int J1 = Convert.ToInt32(matriz[fila, EnumColumnas.Par1]);
                int J2 = Convert.ToInt32(matriz[fila, EnumColumnas.Par2]);
                int J3 = Convert.ToInt32(matriz[fila, EnumColumnas.Par3]);

                actual = (J1 + J2 + J3) / 3;

                if (actual > mayor)
                {
                    nombre = matriz[fila, EnumColumnas.Nombre];
                    mayor = actual;
                }
            }

            return nombre;
        }

        public string nombre_nota_mayor(string[,] matriz, string seccion)
        {
            string nombre = "";

            int actual;
            int mayor = 0;
            int TotalFilas = matriz.GetLength(0);
            int filasSecc = TotalFilas;
            int TotalColumnas = matriz.GetLength(1);


            for (int fila = 1; fila < TotalFilas; fila++)
            {
                if (matriz[fila, EnumColumnas.Seccion] == seccion)
                {
                    int J1 = Convert.ToInt32(matriz[fila, EnumColumnas.Par1]);
                    int J2 = Convert.ToInt32(matriz[fila, EnumColumnas.Par2]);
                    int J3 = Convert.ToInt32(matriz[fila, EnumColumnas.Par3]);

                    actual = (J1 + J2 + J3) / 3;

                    if (actual > mayor)
                    {
                        nombre = matriz[fila, EnumColumnas.Nombre];
                        mayor = actual;
                    }
                }

            }

            return nombre;
        }

        public int promedio_general_seccion(string[,] matriz,  string seccion)
        {
            int Acumulado = 0;
            int Prom;
            int TotalFilas = matriz.GetLength(0);
            int filasSecc = TotalFilas;
            int TotalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < TotalFilas; fila++)
            {
                if (matriz[fila, EnumColumnas.Seccion] == seccion)
                {
                    Acumulado = Acumulado
                        + Convert.ToInt32(matriz[fila, EnumColumnas.Par1])
                        + Convert.ToInt32(matriz[fila, EnumColumnas.Par2])
                        + Convert.ToInt32(matriz[fila, EnumColumnas.Par3]);
                }
                else
                {
                    filasSecc--;
                }

            }

            Prom = (Acumulado / (filasSecc - 1)) / 3;
            return Prom;
        }

        public int promedio_por_parcial(string[,] matriz, int columna_parcial)
        {
            int Acumulado = 0;
            int Prom;
            int TotalFilas = matriz.GetLength(0);
            int TotalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < TotalFilas; fila++)
            {
                Acumulado = Acumulado + Convert.ToInt32(matriz[fila, columna_parcial]);
            }
            Prom = Acumulado / (TotalFilas - 1);
            return Prom;
        }

        public int promedio_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int Acum = 0;
            int Prom;
            int TotalFilas = matriz.GetLength(0);
            int filasSecc = TotalFilas;
            int TotalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < TotalFilas; fila++)
            {
                if (matriz[fila, EnumColumnas.Seccion] == seccion)
                {
                    Acum = Acum + Convert.ToInt32(matriz[fila, columna_parcial]);


                }
                else
                {
                    filasSecc--;
                }

            }
            Prom = Acum / (filasSecc - 1);
            return Prom;

        }

        
    }
}
