namespace Evaluacion_IM
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNumero3 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRespuesta2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLecturaArchivo = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gvEmpresas = new System.Windows.Forms.DataGridView();
            this.btnBuscarEmpresa = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblRespuesta);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txtNumero3);
            this.panel2.Controls.Add(this.txtNumero2);
            this.panel2.Controls.Add(this.txtNumero1);
            this.panel2.Location = new System.Drawing.Point(13, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 197);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(51, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Promedio de 3 numeros";
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Location = new System.Drawing.Point(87, 163);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(58, 13);
            this.lblRespuesta.TabIndex = 2;
            this.lblRespuesta.Text = "Respuesta";
            this.lblRespuesta.Click += new System.EventHandler(this.lblRespuesta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Numero 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Numero 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero 1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Calcular promedio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNumero3
            // 
            this.txtNumero3.Location = new System.Drawing.Point(90, 104);
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(100, 20);
            this.txtNumero3.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(90, 71);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 0;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(90, 37);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblRespuesta2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(240, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 197);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Calcular la suma de los numeros del 1 al 10";
            // 
            // lblRespuesta2
            // 
            this.lblRespuesta2.AutoSize = true;
            this.lblRespuesta2.Location = new System.Drawing.Point(81, 108);
            this.lblRespuesta2.Name = "lblRespuesta2";
            this.lblRespuesta2.Size = new System.Drawing.Size(58, 13);
            this.lblRespuesta2.TabIndex = 2;
            this.lblRespuesta2.Text = "Respuesta";
            this.lblRespuesta2.Click += new System.EventHandler(this.lblRespuesta_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular suma";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtLecturaArchivo);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(464, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 197);
            this.panel3.TabIndex = 2;
            // 
            // txtLecturaArchivo
            // 
            this.txtLecturaArchivo.Location = new System.Drawing.Point(48, 92);
            this.txtLecturaArchivo.Multiline = true;
            this.txtLecturaArchivo.Name = "txtLecturaArchivo";
            this.txtLecturaArchivo.Size = new System.Drawing.Size(145, 84);
            this.txtLecturaArchivo.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(73, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Leer Archivo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(46, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Leer numero desde archivo";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos TXT (*.txt)|*.txt";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.gvEmpresas);
            this.panel4.Controls.Add(this.btnBuscarEmpresa);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtNombre);
            this.panel4.Controls.Add(this.txtCodigo);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(13, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(685, 151);
            this.panel4.TabIndex = 3;
            // 
            // gvEmpresas
            // 
            this.gvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmpresas.Location = new System.Drawing.Point(226, 11);
            this.gvEmpresas.Name = "gvEmpresas";
            this.gvEmpresas.Size = new System.Drawing.Size(434, 115);
            this.gvEmpresas.TabIndex = 8;
            // 
            // btnBuscarEmpresa
            // 
            this.btnBuscarEmpresa.Location = new System.Drawing.Point(22, 103);
            this.btnBuscarEmpresa.Name = "btnBuscarEmpresa";
            this.btnBuscarEmpresa.Size = new System.Drawing.Size(147, 23);
            this.btnBuscarEmpresa.TabIndex = 7;
            this.btnBuscarEmpresa.Text = "Buscar Empresa";
            this.btnBuscarEmpresa.UseVisualStyleBackColor = true;
            this.btnBuscarEmpresa.Click += new System.EventHandler(this.btnBuscarEmpresa_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Codigo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(69, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(32, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Busqueda de Empresas";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(710, 383);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpresas)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Label lblRespuesta;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.TextBox txtNumero3;
      private System.Windows.Forms.TextBox txtNumero2;
      private System.Windows.Forms.TextBox txtNumero1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label lblRespuesta2;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtLecturaArchivo;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.Panel panel4;
      private System.Windows.Forms.Button btnBuscarEmpresa;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.TextBox txtNombre;
      private System.Windows.Forms.TextBox txtCodigo;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.DataGridView gvEmpresas;
   }
}

