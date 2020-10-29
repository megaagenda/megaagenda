namespace MegaAgenda
{
    partial class Form_DB_Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DB_Config));
            this.label1 = new System.Windows.Forms.Label();
            this.boxEndereco = new System.Windows.Forms.TextBox();
            this.boxPorta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxBanco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DB Endereço";
            // 
            // boxEndereco
            // 
            this.boxEndereco.Location = new System.Drawing.Point(6, 24);
            this.boxEndereco.Name = "boxEndereco";
            this.boxEndereco.Size = new System.Drawing.Size(298, 20);
            this.boxEndereco.TabIndex = 1;
            // 
            // boxPorta
            // 
            this.boxPorta.Location = new System.Drawing.Point(6, 64);
            this.boxPorta.Name = "boxPorta";
            this.boxPorta.Size = new System.Drawing.Size(298, 20);
            this.boxPorta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DB Porta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // boxBanco
            // 
            this.boxBanco.Location = new System.Drawing.Point(6, 103);
            this.boxBanco.Name = "boxBanco";
            this.boxBanco.Size = new System.Drawing.Size(298, 20);
            this.boxBanco.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DB Sistema";
            // 
            // boxUsuario
            // 
            this.boxUsuario.Location = new System.Drawing.Point(6, 143);
            this.boxUsuario.Name = "boxUsuario";
            this.boxUsuario.Size = new System.Drawing.Size(298, 20);
            this.boxUsuario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DB Usuário";
            // 
            // boxSenha
            // 
            this.boxSenha.Location = new System.Drawing.Point(6, 182);
            this.boxSenha.Name = "boxSenha";
            this.boxSenha.Size = new System.Drawing.Size(298, 20);
            this.boxSenha.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DB Senha";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(229, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Gravar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_DB_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 238);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.boxSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxBanco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxPorta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxEndereco);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_DB_Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mega Agenda - DB Config";
            this.Load += new System.EventHandler(this.Form_DB_Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxEndereco;
        private System.Windows.Forms.TextBox boxPorta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxBanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}