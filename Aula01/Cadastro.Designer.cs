namespace Aula01Chacara
{
    partial class Cadastro
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
            this.gb01 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb02 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.id1 = new System.Windows.Forms.TextBox();
            this.id3 = new System.Windows.Forms.TextBox();
            this.id2 = new System.Windows.Forms.TextBox();
            this.nome1 = new System.Windows.Forms.TextBox();
            this.nome2 = new System.Windows.Forms.TextBox();
            this.nome3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btgnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.sts = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gb01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb02.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb01
            // 
            this.gb01.Controls.Add(this.btnConsultar);
            this.gb01.Controls.Add(this.dataGridView1);
            this.gb01.Location = new System.Drawing.Point(28, 12);
            this.gb01.Name = "gb01";
            this.gb01.Size = new System.Drawing.Size(718, 140);
            this.gb01.TabIndex = 0;
            this.gb01.TabStop = false;
            this.gb01.Text = "Selecionat Tabela";
            this.gb01.Enter += new System.EventHandler(this.gb01_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 102);
            this.dataGridView1.TabIndex = 0;
            // 
            // gb02
            // 
            this.gb02.Controls.Add(this.btgnSelect);
            this.gb02.Controls.Add(this.btnInsert);
            this.gb02.Controls.Add(this.btnDelete);
            this.gb02.Controls.Add(this.btnUpdate);
            this.gb02.Controls.Add(this.label2);
            this.gb02.Controls.Add(this.label1);
            this.gb02.Controls.Add(this.nome3);
            this.gb02.Controls.Add(this.nome2);
            this.gb02.Controls.Add(this.nome1);
            this.gb02.Controls.Add(this.id2);
            this.gb02.Controls.Add(this.id3);
            this.gb02.Controls.Add(this.id1);
            this.gb02.Location = new System.Drawing.Point(28, 172);
            this.gb02.Name = "gb02";
            this.gb02.Size = new System.Drawing.Size(718, 172);
            this.gb02.TabIndex = 1;
            this.gb02.TabStop = false;
            this.gb02.Text = "CRUD";
            this.gb02.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(614, 62);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // id1
            // 
            this.id1.Location = new System.Drawing.Point(96, 49);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(65, 20);
            this.id1.TabIndex = 0;
            // 
            // id3
            // 
            this.id3.Location = new System.Drawing.Point(96, 133);
            this.id3.Name = "id3";
            this.id3.Size = new System.Drawing.Size(65, 20);
            this.id3.TabIndex = 1;
            // 
            // id2
            // 
            this.id2.Location = new System.Drawing.Point(96, 88);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(65, 20);
            this.id2.TabIndex = 2;
            // 
            // nome1
            // 
            this.nome1.Location = new System.Drawing.Point(295, 48);
            this.nome1.Name = "nome1";
            this.nome1.Size = new System.Drawing.Size(138, 20);
            this.nome1.TabIndex = 3;
            // 
            // nome2
            // 
            this.nome2.Location = new System.Drawing.Point(295, 88);
            this.nome2.Name = "nome2";
            this.nome2.Size = new System.Drawing.Size(138, 20);
            this.nome2.TabIndex = 4;
            // 
            // nome3
            // 
            this.nome3.Location = new System.Drawing.Point(295, 133);
            this.nome3.Name = "nome3";
            this.nome3.Size = new System.Drawing.Size(138, 20);
            this.nome3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(120, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // btgnSelect
            // 
            this.btgnSelect.Location = new System.Drawing.Point(614, 46);
            this.btgnSelect.Name = "btgnSelect";
            this.btgnSelect.Size = new System.Drawing.Size(75, 23);
            this.btgnSelect.TabIndex = 2;
            this.btgnSelect.Text = "Select";
            this.btgnSelect.UseVisualStyleBackColor = true;
            this.btgnSelect.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(614, 75);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(614, 104);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(614, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // sts
            // 
            this.sts.AutoSize = true;
            this.sts.Location = new System.Drawing.Point(46, 385);
            this.sts.Name = "sts";
            this.sts.Size = new System.Drawing.Size(53, 13);
            this.sts.TabIndex = 8;
            this.sts.Text = "STATUS:";
            this.sts.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(121, 368);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(450, 44);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "label3";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.sts);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gb02);
            this.Controls.Add(this.gb01);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.gb01.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb02.ResumeLayout(false);
            this.gb02.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb01;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gb02;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btgnSelect;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nome3;
        private System.Windows.Forms.TextBox nome2;
        private System.Windows.Forms.TextBox nome1;
        private System.Windows.Forms.TextBox id2;
        private System.Windows.Forms.TextBox id3;
        private System.Windows.Forms.TextBox id1;
        private System.Windows.Forms.Label sts;
        private System.Windows.Forms.Label lblStatus;
    }
}