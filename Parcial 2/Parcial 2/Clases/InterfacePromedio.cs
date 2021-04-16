﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2.Clases
{
    interface InterfacePromedio
    {
        /// <summary>
        /// retorna el promedio en base a una columna especifica
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <returns></returns>
        int promedio_por_parcial(string[,] matriz, int columna_parcial);

        /// <summary>
        /// retorna el promedio de un parcial en especial y una seccion especial
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedio_por_seccion(string[,] matriz, int columna_parcial, string seccion);

        /// <summary>
        /// saca el promedio general de todos los alumnos por seccion
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedio_general_seccion(string[,] matriz,  string seccion);
        /// <summary>
        /// retorna una matriz de 2 columnas con el nombre y la otra columna es la sumatoria del parcial del 1 al 3
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        string[,] Clasificar_Alumnos(string[,] matriz, string seccion);

        /// <summary>
        /// busca el mejor promedio general o por seccion
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns></returns>
        string nombre_nota_mayor(string[,] matriz);

        string nombre_nota_mayor(string[,] matriz, string seccion);



    }
}

