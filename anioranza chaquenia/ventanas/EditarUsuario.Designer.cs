namespace anioranza_chaquenia.ventanas
{
    partial class EditarUsuario
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
            this.listaUsuarios = new System.Windows.Forms.DataGridView();
            this.buscarUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.borrarUsuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.editarUsuariosControl1 = new WindowsFormsControlLibrary.EditarUsuariosControl();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // listaUsuarios
            // 
            this.listaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUsuarios.Location = new System.Drawing.Point(12, 32);
            this.listaUsuarios.Name = "listaUsuarios";
            this.listaUsuarios.Size = new System.Drawing.Size(193, 544);
            this.listaUsuarios.TabIndex = 0;
            // 
            // buscarUsuario
            // 
            this.buscarUsuario.Location = new System.Drawing.Point(12, 582);
            this.buscarUsuario.Name = "buscarUsuario";
            this.buscarUsuario.Size = new System.Drawing.Size(193, 20);
            this.buscarUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuarios";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 640);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(193, 29);
            this.returnButton.TabIndex = 0;
            this.returnButton.Text = "Volver";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Image = global::anioranza_chaquenia.Properties.Resources.icons8_search_16;
            this.searchButton.Location = new System.Drawing.Point(211, 582);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(26, 20);
            this.searchButton.TabIndex = 5;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // borrarUsuario
            // 
            this.borrarUsuario.Image = global::anioranza_chaquenia.Properties.Resources.removeUser;
            this.borrarUsuario.Location = new System.Drawing.Point(43, 608);
            this.borrarUsuario.Name = "borrarUsuario";
            this.borrarUsuario.Size = new System.Drawing.Size(25, 26);
            this.borrarUsuario.TabIndex = 4;
            this.borrarUsuario.Text = "button2";
            this.borrarUsuario.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::anioranza_chaquenia.Properties.Resources.addUser;
            this.button1.Location = new System.Drawing.Point(12, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 26);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // editarUsuariosControl1
            // 
            this.editarUsuariosControl1.Location = new System.Drawing.Point(268, 32);
            this.editarUsuariosControl1.Name = "editarUsuariosControl1";
            this.editarUsuariosControl1.Size = new System.Drawing.Size(598, 624);
            this.editarUsuariosControl1.TabIndex = 6;
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 693);
            this.Controls.Add(this.editarUsuariosControl1);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.borrarUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarUsuario);
            this.Controls.Add(this.listaUsuarios);
            this.Name = "EditarUsuario";
            this.Text = "EditarUsuario";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listaUsuarios;
        private System.Windows.Forms.TextBox buscarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button borrarUsuario;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button returnButton;
        private WindowsFormsControlLibrary.EditarUsuariosControl editarUsuariosControl1;
    }
}