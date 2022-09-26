namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLlenarCombo = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_Consulta = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgvMostrarConsulta = new System.Windows.Forms.DataGridView();
            this.lv1MostrarConsulta = new System.Windows.Forms.ListView();
            this.dgvMostrar = new System.Windows.Forms.Button();
            this.lvMostrar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txtCampo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLlenarCombo
            // 
            this.btnLlenarCombo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLlenarCombo.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlenarCombo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLlenarCombo.Location = new System.Drawing.Point(488, 96);
            this.btnLlenarCombo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLlenarCombo.Name = "btnLlenarCombo";
            this.btnLlenarCombo.Size = new System.Drawing.Size(146, 25);
            this.btnLlenarCombo.TabIndex = 0;
            this.btnLlenarCombo.Text = "Combo";
            this.btnLlenarCombo.UseVisualStyleBackColor = false;
            this.btnLlenarCombo.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_ID.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ID.Location = new System.Drawing.Point(732, 57);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(0, 15);
            this.lbl_ID.TabIndex = 1;
            // 
            // txt_Consulta
            // 
            this.txt_Consulta.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Consulta.ForeColor = System.Drawing.Color.Red;
            this.txt_Consulta.Location = new System.Drawing.Point(36, 14);
            this.txt_Consulta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Consulta.Name = "txt_Consulta";
            this.txt_Consulta.Size = new System.Drawing.Size(683, 20);
            this.txt_Consulta.TabIndex = 2;
            this.txt_Consulta.Text = "Select * from Articulos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(572, 52);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 22);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvMostrarConsulta
            // 
            this.dgvMostrarConsulta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMostrarConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarConsulta.GridColor = System.Drawing.SystemColors.InfoText;
            this.dgvMostrarConsulta.Location = new System.Drawing.Point(36, 142);
            this.dgvMostrarConsulta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvMostrarConsulta.Name = "dgvMostrarConsulta";
            this.dgvMostrarConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMostrarConsulta.Size = new System.Drawing.Size(344, 161);
            this.dgvMostrarConsulta.TabIndex = 4;
            this.dgvMostrarConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrarConsulta_CellContentClick);
            // 
            // lv1MostrarConsulta
            // 
            this.lv1MostrarConsulta.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lv1MostrarConsulta.GridLines = true;
            this.lv1MostrarConsulta.Location = new System.Drawing.Point(386, 142);
            this.lv1MostrarConsulta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lv1MostrarConsulta.Name = "lv1MostrarConsulta";
            this.lv1MostrarConsulta.Size = new System.Drawing.Size(348, 160);
            this.lv1MostrarConsulta.TabIndex = 5;
            this.lv1MostrarConsulta.UseCompatibleStateImageBehavior = false;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvMostrar.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvMostrar.Location = new System.Drawing.Point(161, 339);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(102, 25);
            this.dgvMostrar.TabIndex = 6;
            this.dgvMostrar.Text = "DataGridView";
            this.dgvMostrar.UseVisualStyleBackColor = false;
            this.dgvMostrar.Click += new System.EventHandler(this.dgvMostrar_Click);
            // 
            // lvMostrar
            // 
            this.lvMostrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvMostrar.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMostrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvMostrar.Location = new System.Drawing.Point(524, 338);
            this.lvMostrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvMostrar.Name = "lvMostrar";
            this.lvMostrar.Size = new System.Drawing.Size(74, 25);
            this.lvMostrar.TabIndex = 7;
            this.lvMostrar.Text = "ListView";
            this.lvMostrar.UseVisualStyleBackColor = false;
            this.lvMostrar.Click += new System.EventHandler(this.lvMostrar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMostrarTodos.Location = new System.Drawing.Point(314, 404);
            this.btnMostrarTodos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(136, 25);
            this.btnMostrarTodos.TabIndex = 8;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsulta.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsulta.Location = new System.Drawing.Point(36, 49);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(136, 25);
            this.btnConsulta.TabIndex = 9;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLimpiar.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpiar.Location = new System.Drawing.Point(596, 404);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 25);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(213, 51);
            this.txt_Id.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(132, 20);
            this.txt_Id.TabIndex = 11;
            // 
            // txtCampo
            // 
            this.txtCampo.Location = new System.Drawing.Point(409, 52);
            this.txtCampo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCampo.Name = "txtCampo";
            this.txtCampo.Size = new System.Drawing.Size(132, 20);
            this.txtCampo.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(180, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(353, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Campo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(779, 439);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCampo);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.lvMostrar);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.lv1MostrarConsulta);
            this.Controls.Add(this.dgvMostrarConsulta);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_Consulta);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btnLlenarCombo);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlenarCombo;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_Consulta;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgvMostrarConsulta;
        private System.Windows.Forms.ListView lv1MostrarConsulta;
        private System.Windows.Forms.Button dgvMostrar;
        private System.Windows.Forms.Button lvMostrar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txtCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

