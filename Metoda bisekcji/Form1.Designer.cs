namespace Metoda_bisekcji
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonW = new System.Windows.Forms.Button();
            this.numericA = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numericB = new System.Windows.Forms.NumericUpDown();
            this.numericEps = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericDokladnosc = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDokladnosc)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonW
            // 
            this.buttonW.Location = new System.Drawing.Point(120, 169);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(75, 23);
            this.buttonW.TabIndex = 7;
            this.buttonW.Text = "Designate";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericA
            // 
            this.numericA.AccessibleDescription = "";
            this.numericA.DecimalPlaces = 5;
            this.numericA.Location = new System.Drawing.Point(232, 16);
            this.numericA.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericA.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numericA.Name = "numericA";
            this.numericA.Size = new System.Drawing.Size(66, 20);
            this.numericA.TabIndex = 1;
            this.numericA.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numericB
            // 
            this.numericB.AccessibleDescription = "";
            this.numericB.DecimalPlaces = 5;
            this.numericB.Location = new System.Drawing.Point(232, 42);
            this.numericB.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericB.Minimum = new decimal(new int[] {
            50000,
            0,
            0,
            -2147483648});
            this.numericB.Name = "numericB";
            this.numericB.Size = new System.Drawing.Size(66, 20);
            this.numericB.TabIndex = 2;
            this.numericB.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numericEps
            // 
            this.numericEps.AccessibleDescription = "";
            this.numericEps.DecimalPlaces = 5;
            this.numericEps.Location = new System.Drawing.Point(231, 68);
            this.numericEps.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericEps.Name = "numericEps";
            this.numericEps.Size = new System.Drawing.Size(66, 20);
            this.numericEps.TabIndex = 3;
            this.numericEps.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "The initial isolation interval of the element:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "The final isolation interval of an element:\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Epsilon value:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Function:\n";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(201, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jump on the axis of the graph of the function:";
            // 
            // numericDokladnosc
            // 
            this.numericDokladnosc.AccessibleDescription = "";
            this.numericDokladnosc.DecimalPlaces = 2;
            this.numericDokladnosc.Location = new System.Drawing.Point(231, 94);
            this.numericDokladnosc.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDokladnosc.Name = "numericDokladnosc";
            this.numericDokladnosc.Size = new System.Drawing.Size(66, 20);
            this.numericDokladnosc.TabIndex = 4;
            this.numericDokladnosc.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonW;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(317, 200);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericDokladnosc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericEps);
            this.Controls.Add(this.numericB);
            this.Controls.Add(this.numericA);
            this.Controls.Add(this.buttonW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilab";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDokladnosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.NumericUpDown numericA;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown numericB;
        private System.Windows.Forms.NumericUpDown numericEps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericDokladnosc;
    }
}

