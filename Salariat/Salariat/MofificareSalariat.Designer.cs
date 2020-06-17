namespace Salariat
{
    partial class MofificareSalariat
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNume = new System.Windows.Forms.TextBox();
            this.inputNrOre = new System.Windows.Forms.TextBox();
            this.inputSalariu = new System.Windows.Forms.TextBox();
            this.inputMarca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Modifica Salariat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Introduceti salariu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Introduceti Numar ore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Introduceti Nume";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Introduceti Marca";
            // 
            // inputNume
            // 
            this.inputNume.Location = new System.Drawing.Point(324, 172);
            this.inputNume.Name = "inputNume";
            this.inputNume.Size = new System.Drawing.Size(155, 22);
            this.inputNume.TabIndex = 12;
            // 
            // inputNrOre
            // 
            this.inputNrOre.Location = new System.Drawing.Point(324, 233);
            this.inputNrOre.Name = "inputNrOre";
            this.inputNrOre.Size = new System.Drawing.Size(155, 22);
            this.inputNrOre.TabIndex = 11;
            // 
            // inputSalariu
            // 
            this.inputSalariu.Location = new System.Drawing.Point(324, 292);
            this.inputSalariu.Name = "inputSalariu";
            this.inputSalariu.Size = new System.Drawing.Size(155, 22);
            this.inputSalariu.TabIndex = 10;
            // 
            // inputMarca
            // 
            this.inputMarca.Location = new System.Drawing.Point(324, 110);
            this.inputMarca.Name = "inputMarca";
            this.inputMarca.Size = new System.Drawing.Size(155, 22);
            this.inputMarca.TabIndex = 9;
            // 
            // MofificareSalariat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNume);
            this.Controls.Add(this.inputNrOre);
            this.Controls.Add(this.inputSalariu);
            this.Controls.Add(this.inputMarca);
            this.Name = "MofificareSalariat";
            this.Text = "MofificareSalariat";
            this.Load += new System.EventHandler(this.MofificareSalariat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNume;
        private System.Windows.Forms.TextBox inputNrOre;
        private System.Windows.Forms.TextBox inputSalariu;
        private System.Windows.Forms.TextBox inputMarca;
    }
}