using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Evaluacion_IM
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void button2_Click(object sender, EventArgs e)
      {
          try
          {
              float suma = float.Parse(txtNumero1.Text)+ float.Parse(txtNumero2.Text)+ float.Parse(txtNumero3.Text);
              lblRespuesta.Text = (suma/3).ToString();
          }
          catch (Exception ex) {
              lblRespuesta.Text = "Error al calcular";
          }

      }

      private void lblRespuesta_Click(object sender, EventArgs e)
      {

      }

      private void button1_Click(object sender, EventArgs e)
      {
          int suma = 0;
          for (int i = 1; i <= 10; i++ )
          {
              suma = suma + i;
          }
          lblRespuesta2.Text = suma.ToString();
      }

      private void button3_Click(object sender, EventArgs e)
      {
          String filePath = "";
          String textRead = "";          
          string sPattern = "[0-9]+(\\.[0-9]{1,2})?";
          if (openFileDialog1.ShowDialog() == DialogResult.OK)
          {
              filePath = openFileDialog1.FileName;
              var fileStream = openFileDialog1.OpenFile();              
              using (System.IO.StreamReader reader = new System.IO.StreamReader(fileStream))
              {
                  textRead = reader.ReadToEnd();
                  foreach (Match match in Regex.Matches(textRead, sPattern, RegexOptions.IgnoreCase)){
                      txtLecturaArchivo.Text = txtLecturaArchivo.Text + Environment.NewLine + match.Value;                      
                   }
                  
              }
          }
      }

      private void btnBuscarEmpresa_Click(object sender, EventArgs e)
      {
          try
          {
              conexion conect = new conexion();
              conect.openConexion();
              String consulta = "";

              if (txtNombre.Text != String.Empty && txtCodigo.Text != String.Empty)
              {
                  consulta = "select * from TblEmpresas where EmpresaId = " + Int32.Parse(txtCodigo.Text) + " and Nombre = '" + txtNombre.Text + "'";
              }
              else
                  if (txtNombre.Text != String.Empty)
                  {
                      consulta = "select * from TblEmpresas where Nombre = '" + txtNombre.Text + "'";
                  }
                  else
                      if (txtCodigo.Text != String.Empty)
                      {
                          consulta = "select * from TblEmpresas where EmpresaId = " + Int32.Parse(txtCodigo.Text);
                      }

              SqlCommand sqlcommand = new SqlCommand(consulta, conect.conection);
              SqlDataAdapter adaptador = new SqlDataAdapter();
              adaptador.SelectCommand = sqlcommand;
              DataTable table = new DataTable();
              adaptador.Fill(table);
              gvEmpresas.DataSource = table;
          }catch(Exception ex){
              MessageBox.Show("Ingrese por lo menos un valor");
          }
      }

   }
}
