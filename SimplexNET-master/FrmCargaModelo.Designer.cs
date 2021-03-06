﻿namespace ProgramaSimplex
{
    partial class FrmCargaModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargaModelo));
            this.dGVc = new System.Windows.Forms.DataGridView();
            this.dGVAb = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNroRestricciones = new System.Windows.Forms.TextBox();
            this.txtNroVariables = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnLeerModelo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGrabarModelo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVc
            // 
            this.dGVc.AllowUserToAddRows = false;
            this.dGVc.AllowUserToDeleteRows = false;
            this.dGVc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.dGVc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVc.Location = new System.Drawing.Point(119, 151);
            this.dGVc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGVc.Name = "dGVc";
            this.dGVc.RowHeadersVisible = false;
            this.dGVc.Size = new System.Drawing.Size(917, 68);
            this.dGVc.TabIndex = 2;
            // 
            // dGVAb
            // 
            this.dGVAb.AllowUserToAddRows = false;
            this.dGVAb.AllowUserToDeleteRows = false;
            this.dGVAb.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.dGVAb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAb.Location = new System.Drawing.Point(119, 226);
            this.dGVAb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGVAb.Name = "dGVAb";
            this.dGVAb.RowHeadersVisible = false;
            this.dGVAb.Size = new System.Drawing.Size(917, 305);
            this.dGVAb.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnLeerModelo);
            this.groupBox1.Controls.Add(this.btnVolver);
            this.groupBox1.Controls.Add(this.btnGrabarModelo);
            this.groupBox1.Location = new System.Drawing.Point(3, 539);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1033, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtArchivo);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.txtNroRestricciones);
            this.groupBox2.Controls.Add(this.txtNroVariables);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(3, -2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1033, 146);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nº de Restricciones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nº de Variables:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Archivo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre del Modelo:";
            // 
            // txtArchivo
            // 
            this.txtArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtArchivo.Location = new System.Drawing.Point(161, 49);
            this.txtArchivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(709, 22);
            this.txtArchivo.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(161, 17);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(513, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // txtNroRestricciones
            // 
            this.txtNroRestricciones.BackColor = System.Drawing.Color.White;
            this.txtNroRestricciones.Location = new System.Drawing.Point(161, 113);
            this.txtNroRestricciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNroRestricciones.Name = "txtNroRestricciones";
            this.txtNroRestricciones.Size = new System.Drawing.Size(59, 22);
            this.txtNroRestricciones.TabIndex = 9;
            this.txtNroRestricciones.Leave += new System.EventHandler(this.txtNroRestricciones_Leave);
            // 
            // txtNroVariables
            // 
            this.txtNroVariables.BackColor = System.Drawing.Color.White;
            this.txtNroVariables.Location = new System.Drawing.Point(161, 81);
            this.txtNroVariables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNroVariables.Name = "txtNroVariables";
            this.txtNroVariables.Size = new System.Drawing.Size(59, 22);
            this.txtNroVariables.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Función Obj.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Restricciones:";
            // 
            // btnMenos
            // 
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenos.Image = global::ProgramaSimplex.Properties.Resources.Icon_awesome_minus_circle__1_;
            this.btnMenos.Location = new System.Drawing.Point(57, 383);
            this.btnMenos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(58, 59);
            this.btnMenos.TabIndex = 20;
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.AccessibleDescription = " ";
            this.btnMas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.btnMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMas.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMas.ForeColor = System.Drawing.Color.Transparent;
            this.btnMas.Image = global::ProgramaSimplex.Properties.Resources.Icon_awesome_plus_circle;
            this.btnMas.Location = new System.Drawing.Point(57, 318);
            this.btnMas.Margin = new System.Windows.Forms.Padding(4);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(58, 57);
            this.btnMas.TabIndex = 19;
            this.btnMas.UseVisualStyleBackColor = false;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProgramaSimplex.Properties.Resources.Grupo_289;
            this.pictureBox2.Location = new System.Drawing.Point(63, 172);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProgramaSimplex.Properties.Resources.Grupo_288;
            this.pictureBox1.Location = new System.Drawing.Point(63, 247);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 48);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = global::ProgramaSimplex.Properties.Resources._019_add;
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(116, 18);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(148, 54);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo Modelo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnLeerModelo
            // 
            this.btnLeerModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLeerModelo.Image = global::ProgramaSimplex.Properties.Resources._027_search;
            this.btnLeerModelo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLeerModelo.Location = new System.Drawing.Point(272, 18);
            this.btnLeerModelo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeerModelo.Name = "btnLeerModelo";
            this.btnLeerModelo.Size = new System.Drawing.Size(141, 54);
            this.btnLeerModelo.TabIndex = 8;
            this.btnLeerModelo.Text = "Leer Modelo";
            this.btnLeerModelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLeerModelo.UseVisualStyleBackColor = false;
            this.btnLeerModelo.Click += new System.EventHandler(this.btnLeerModelo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVolver.Image = global::ProgramaSimplex.Properties.Resources.exitPuerta;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(889, 18);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(131, 54);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGrabarModelo
            // 
            this.btnGrabarModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGrabarModelo.Image = global::ProgramaSimplex.Properties.Resources._006_verify;
            this.btnGrabarModelo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrabarModelo.Location = new System.Drawing.Point(421, 18);
            this.btnGrabarModelo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabarModelo.Name = "btnGrabarModelo";
            this.btnGrabarModelo.Size = new System.Drawing.Size(151, 54);
            this.btnGrabarModelo.TabIndex = 6;
            this.btnGrabarModelo.Text = "Grabar Modelo";
            this.btnGrabarModelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrabarModelo.UseVisualStyleBackColor = false;
            this.btnGrabarModelo.Click += new System.EventHandler(this.btnGrabarModelo_Click_1);
            // 
            // FrmCargaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1039, 623);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGVAb);
            this.Controls.Add(this.dGVc);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCargaModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definición de Modelo de PL";
            ((System.ComponentModel.ISupportInitialize)(this.dGVc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVc;
        private System.Windows.Forms.DataGridView dGVAb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLeerModelo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGrabarModelo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNroRestricciones;
        private System.Windows.Forms.TextBox txtNroVariables;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button btnMas;
    }
}