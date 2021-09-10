
namespace WinFormsApp1
{
    partial class CADASTROCURSO
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.idcurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.periodocurso = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.valorcurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ALTERAR = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idcurso
            // 
            this.idcurso.Location = new System.Drawing.Point(71, 59);
            this.idcurso.Name = "idcurso";
            this.idcurso.Size = new System.Drawing.Size(361, 23);
            this.idcurso.TabIndex = 0;
            this.idcurso.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id. do Curso";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(71, 126);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(361, 23);
            this.descricao.TabIndex = 2;
            this.descricao.TextChanged += new System.EventHandler(this.descurso_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição do Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Período";
            // 
            // periodocurso
            // 
            this.periodocurso.Location = new System.Drawing.Point(71, 187);
            this.periodocurso.Name = "periodocurso";
            this.periodocurso.Size = new System.Drawing.Size(361, 23);
            this.periodocurso.TabIndex = 5;
            this.periodocurso.TextChanged += new System.EventHandler(this.periodo_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(82, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "INSERIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // valorcurso
            // 
            this.valorcurso.Location = new System.Drawing.Point(71, 252);
            this.valorcurso.Name = "valorcurso";
            this.valorcurso.Size = new System.Drawing.Size(361, 23);
            this.valorcurso.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor";
            // 
            // ALTERAR
            // 
            this.ALTERAR.Location = new System.Drawing.Point(194, 499);
            this.ALTERAR.Name = "ALTERAR";
            this.ALTERAR.Size = new System.Drawing.Size(75, 23);
            this.ALTERAR.TabIndex = 9;
            this.ALTERAR.Text = "ALTERAR";
            this.ALTERAR.UseVisualStyleBackColor = true;
            this.ALTERAR.Click += new System.EventHandler(this.ALTERAR_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CADASTROCURSO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 651);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ALTERAR);
            this.Controls.Add(this.valorcurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.periodocurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idcurso);
            this.Name = "CADASTROCURSO";
            this.Text = "CADASTRO DE CURSO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idcurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox periodocurso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox valorcurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ALTERAR;
        private System.Windows.Forms.Button button2;
    }
}

