using Parcial_2.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo arch = new ClsArchivo();
            OpenFileDialog msj = new OpenFileDialog();
            msj.Title = "Porfa, Selecciona tu archivo plano";
            msj.InitialDirectory = @"C:\Users\Usuario\Documents\Archivo Plano";
            msj.Filter = "Archivo Plano (*.csv)|*.csv";

            if (msj.ShowDialog() == DialogResult.OK)
            {
                var archivo = msj.FileName;
                string resultado = arch.LeerTodoArchivo(archivo);
                ArregloNotas = arch.LeerArchivo(archivo);
                textBoxArchivo.Text = resultado;
            }
        }

        private void buttonPromedioporParcial_Click(object sender, EventArgs e)
        {
            Clase_Interfaz pro = new Clase_Interfaz();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {
                string[] DatosUnitarios = linea.Split(';');

                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par3] = DatosUnitarios[4];
                NumeroLinea++;
            }
            int Prom1 = pro.promedio_por_parcial(ArregloDosDimensiones, 2);
            int Prom2 = pro.promedio_por_parcial(ArregloDosDimensiones, 3);
            int Prom3 = pro.promedio_por_parcial(ArregloDosDimensiones, 4);
            listBoxResultado.Items.Add($"Promedio de Tercer Parcial: {Prom3}");
            listBoxResultado.Items.Add($"Promedio de Segundo Parcial: {Prom2}");
            listBoxResultado.Items.Add($"Promedio de Primer Parcial: {Prom1}");
        }

        private void buttonPromedioporSeccion_Click(object sender, EventArgs e)
        {
            Clase_Interfaz promedio = new Clase_Interfaz();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;



            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }
            int promedioSAP1 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.Par1, "A");
            int promedioSAP2 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.Par2, "A");
            int promedioSAP3 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.Par3, "A");
            int promedioSBP1 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.Par1, "B");
            int promedioSBP2 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.Par2, "B");
            int promedioSBP3 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.Par3, "B");
            int promedioSCP1 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.Par1, "C");
            int promedioSCP2 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.Par2, "C");
            int promedioSCP3 = promedio.promedio_por_seccion(ArregloDosDimensiones, EnumColumnas.Par3, "C");


            listBoxResultado.Items.Add($"Promedio Sección A, Parcial 1: {promedioSAP1}");
            listBoxResultado.Items.Add($"Promedio Sección A, Parcial 2: {promedioSAP2}");
            listBoxResultado.Items.Add($"Promedio Sección A, Parcial 3: {promedioSAP3}");
            listBoxResultado.Items.Add($"Promedio Sección B, Parcial 1: {promedioSBP1}");
            listBoxResultado.Items.Add($"Promedio Sección B, Parcial 2: {promedioSBP2}");
            listBoxResultado.Items.Add($"Promedio Sección B, Parcial 3: {promedioSBP3}");
            listBoxResultado.Items.Add($"Promedio Sección C, Parcial 1: {promedioSCP1}");
            listBoxResultado.Items.Add($"Promedio Sección C, Parcial 2: {promedioSCP2}");
            listBoxResultado.Items.Add($"Promedio Sección C, Parcial 3: {promedioSCP3}");


        }

        private void buttonPromedioGeneralSeccion_Click_1(object sender, EventArgs e)
        {
            Clase_Interfaz gen = new Clase_Interfaz();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            int promedioGeneralA = gen.promedio_general_seccion(ArregloDosDimensiones, "A");
            int promedioGeneralB = gen.promedio_general_seccion(ArregloDosDimensiones, "B");
            int promedioGeneralC = gen.promedio_general_seccion(ArregloDosDimensiones, "C");

            listBoxResultado.Items.Add($"Promedio General Sección A: {promedioGeneralA}");
            listBoxResultado.Items.Add($"Promedio General Sección B: {promedioGeneralB}");
            listBoxResultado.Items.Add($"Promedio General Sección C: {promedioGeneralC}");
        }

        private void buttonClasificarAlumnos_Click(object sender, EventArgs e)
        {
            Clase_Interfaz Clas = new Clase_Interfaz();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            string[,] alumnoClasificado = Clas.Clasificar_Alumnos(ArregloDosDimensiones, "C");
            string nombre = alumnoClasificado[0, 0];
            string nota = alumnoClasificado[0, 1];

            
            listBoxResultado.Items.Add($"Nombre: {nombre}; Sumatoria de los parciales: {nota}");
        }

        private void buttonNotaMayor_Click(object sender, EventArgs e)
        {
            Clase_Interfaz NotM = new Clase_Interfaz();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            string mayor = NotM.nombre_nota_mayor(ArregloDosDimensiones);

            listBoxResultado.Items.Add($"Alumno con mayor promedio: {mayor} Felicidades!!!!");
          
        }

        private void buttonNotaMayorGeneral_Click(object sender, EventArgs e)
        {
            Clase_Interfaz NotmS = new Clase_Interfaz();
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;

            foreach (string linea in ArregloNotas)
            {

                string[] DatosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Correlativo] = DatosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Nombre] = DatosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par1] = DatosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par2] = DatosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Par3] = DatosUnitarios[4];
                ArregloDosDimensiones[NumeroLinea, EnumColumnas.Seccion] = DatosUnitarios[5];
                NumeroLinea++;
            }

            string mayor = NotmS.nombre_nota_mayor(ArregloDosDimensiones, "C");
            string mayorA = NotmS.nombre_nota_mayor(ArregloDosDimensiones, "A");
            string mayorB = NotmS.nombre_nota_mayor(ArregloDosDimensiones, "B");
            string mayorD = NotmS.nombre_nota_mayor(ArregloDosDimensiones, "D");


            listBoxResultado.Items.Add($"Alumno con mayor promedio de la Seccion A ");
            listBoxResultado.Items.Add($"Nombre: {mayorA}");
            listBoxResultado.Items.Add($"Alumno con mayor promedio de la Seccion B ");
            listBoxResultado.Items.Add($"Nombre: {mayorB}");
            listBoxResultado.Items.Add($"Alumno con mayor promedio de la Seccion C ");
            listBoxResultado.Items.Add($"Nombre: {mayor}");
            listBoxResultado.Items.Add($"Alumno con mayor promedio de la Seccion D ");
            listBoxResultado.Items.Add($"Nombre: {mayorD}");
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
        }
    }

}









