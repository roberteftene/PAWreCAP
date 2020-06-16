namespace Examen_PARCAUTO
{
    partial class AdaugareVehicul
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
            this.inputPret = new System.Windows.Forms.TextBox();
            this.inputAnFabricatie = new System.Windows.Forms.TextBox();
            this.inputModel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputPret
            // 
            this.inputPret.Location = new System.Drawing.Point(288, 176);
            this.inputPret.Name = "inputPret";
            this.inputPret.Size = new System.Drawing.Size(172, 22);
            this.inputPret.TabIndex = 1;
            // 
            // inputAnFabricatie
            // 
            this.inputAnFabricatie.Location = new System.Drawing.Point(288, 122);
            this.inputAnFabricatie.Name = "inputAnFabricatie";
            this.inputAnFabricatie.Size = new System.Drawing.Size(172, 22);
            this.inputAnFabricatie.TabIndex = 2;
            // 
            // inputModel
            // 
            this.inputModel.Location = new System.Drawing.Point(288, 68);
            this.inputModel.Name = "inputModel";
            this.inputModel.Size = new System.Drawing.Size(172, 22);
            this.inputModel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Model Masina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "An Fabricatie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pret";
            // 
            // addCarBtn
            // 
            this.addCarBtn.Location = new System.Drawing.Point(288, 226);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(172, 31);
            this.addCarBtn.TabIndex = 7;
            this.addCarBtn.Text = "Adauga Vehicul";
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // AdaugareVehicul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCarBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputModel);
            this.Controls.Add(this.inputAnFabricatie);
            this.Controls.Add(this.inputPret);
            this.Name = "AdaugareVehicul";
            this.Text = "AdaugareVehicul";
            this.Load += new System.EventHandler(this.AdaugareVehicul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox inputPret;
        private System.Windows.Forms.TextBox inputAnFabricatie;
        private System.Windows.Forms.TextBox inputModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addCarBtn;
    }
}