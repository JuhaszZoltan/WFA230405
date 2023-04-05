namespace WFA230405
{
    partial class FrmMain
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
            label1 = new Label();
            label2 = new Label();
            numSorSzam = new NumericUpDown();
            numOszlopSzam = new NumericUpDown();
            btnGeneral = new Button();
            pnlMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)numSorSzam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numOszlopSzam).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 34);
            label1.Name = "label1";
            label1.Size = new Size(138, 30);
            label1.TabIndex = 0;
            label1.Text = "sorok száma:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 33);
            label2.Name = "label2";
            label2.Size = new Size(171, 30);
            label2.TabIndex = 0;
            label2.Text = "oszlopok száma:";
            // 
            // numSorSzam
            // 
            numSorSzam.Location = new Point(181, 31);
            numSorSzam.Margin = new Padding(5, 6, 5, 6);
            numSorSzam.Name = "numSorSzam";
            numSorSzam.Size = new Size(120, 36);
            numSorSzam.TabIndex = 1;
            // 
            // numOszlopSzam
            // 
            numOszlopSzam.Location = new Point(527, 31);
            numOszlopSzam.Margin = new Padding(5, 6, 5, 6);
            numOszlopSzam.Name = "numOszlopSzam";
            numOszlopSzam.Size = new Size(120, 36);
            numOszlopSzam.TabIndex = 2;
            // 
            // btnGeneral
            // 
            btnGeneral.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnGeneral.Location = new Point(1002, 26);
            btnGeneral.Name = "btnGeneral";
            btnGeneral.Size = new Size(191, 45);
            btnGeneral.TabIndex = 3;
            btnGeneral.Text = "generálás";
            btnGeneral.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.LightCoral;
            pnlMain.Location = new Point(12, 104);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1181, 583);
            pnlMain.TabIndex = 0;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 699);
            Controls.Add(pnlMain);
            Controls.Add(btnGeneral);
            Controls.Add(numOszlopSzam);
            Controls.Add(numSorSzam);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmMain";
            Text = "controlok előállítása futási időben";
            ((System.ComponentModel.ISupportInitialize)numSorSzam).EndInit();
            ((System.ComponentModel.ISupportInitialize)numOszlopSzam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numSorSzam;
        private NumericUpDown numOszlopSzam;
        private Button btnGeneral;
        private Panel pnlMain;
    }
}