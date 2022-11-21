namespace Pso._1
{
    partial class ntxtMaxZ
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
            this.ntxtParticlesCount = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ntxtMinX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ntxtMaxX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ntxtMinY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.ntxtMaxY = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ntxtTargetZ = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.ntxtIterationCount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.ntxtC2 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.ntxtC1 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.ntxtW = new System.Windows.Forms.NumericUpDown();
            this.rtLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtParticlesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtMinX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtMaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtMinY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtMaxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtTargetZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtIterationCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtW)).BeginInit();
            this.SuspendLayout();
            // 
            // ntxtParticlesCount
            // 
            this.ntxtParticlesCount.Location = new System.Drawing.Point(106, 7);
            this.ntxtParticlesCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ntxtParticlesCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ntxtParticlesCount.Name = "ntxtParticlesCount";
            this.ntxtParticlesCount.Size = new System.Drawing.Size(120, 23);
            this.ntxtParticlesCount.TabIndex = 0;
            this.ntxtParticlesCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 311);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Particles count:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Min X:";
            // 
            // ntxtMinX
            // 
            this.ntxtMinX.Location = new System.Drawing.Point(106, 36);
            this.ntxtMinX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ntxtMinX.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ntxtMinX.Name = "ntxtMinX";
            this.ntxtMinX.Size = new System.Drawing.Size(120, 23);
            this.ntxtMinX.TabIndex = 18;
            this.ntxtMinX.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Max X:";
            // 
            // ntxtMaxX
            // 
            this.ntxtMaxX.Location = new System.Drawing.Point(106, 65);
            this.ntxtMaxX.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ntxtMaxX.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ntxtMaxX.Name = "ntxtMaxX";
            this.ntxtMaxX.Size = new System.Drawing.Size(120, 23);
            this.ntxtMaxX.TabIndex = 20;
            this.ntxtMaxX.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Min Y:";
            // 
            // ntxtMinY
            // 
            this.ntxtMinY.Location = new System.Drawing.Point(106, 94);
            this.ntxtMinY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ntxtMinY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ntxtMinY.Name = "ntxtMinY";
            this.ntxtMinY.Size = new System.Drawing.Size(120, 23);
            this.ntxtMinY.TabIndex = 22;
            this.ntxtMinY.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Max Y:";
            // 
            // ntxtMaxY
            // 
            this.ntxtMaxY.Location = new System.Drawing.Point(106, 123);
            this.ntxtMaxY.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ntxtMaxY.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ntxtMaxY.Name = "ntxtMaxY";
            this.ntxtMaxY.Size = new System.Drawing.Size(120, 23);
            this.ntxtMaxY.TabIndex = 24;
            this.ntxtMaxY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Target Z:";
            // 
            // ntxtTargetZ
            // 
            this.ntxtTargetZ.Location = new System.Drawing.Point(106, 152);
            this.ntxtTargetZ.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ntxtTargetZ.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ntxtTargetZ.Name = "ntxtTargetZ";
            this.ntxtTargetZ.Size = new System.Drawing.Size(120, 23);
            this.ntxtTargetZ.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "Iteration count:";
            // 
            // ntxtIterationCount
            // 
            this.ntxtIterationCount.Location = new System.Drawing.Point(106, 181);
            this.ntxtIterationCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ntxtIterationCount.Name = "ntxtIterationCount";
            this.ntxtIterationCount.Size = new System.Drawing.Size(120, 23);
            this.ntxtIterationCount.TabIndex = 36;
            this.ntxtIterationCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 15);
            this.label12.TabIndex = 43;
            this.label12.Text = "C2:";
            // 
            // ntxtC2
            // 
            this.ntxtC2.DecimalPlaces = 3;
            this.ntxtC2.Location = new System.Drawing.Point(106, 268);
            this.ntxtC2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ntxtC2.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ntxtC2.Name = "ntxtC2";
            this.ntxtC2.Size = new System.Drawing.Size(120, 23);
            this.ntxtC2.TabIndex = 42;
            this.ntxtC2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 15);
            this.label13.TabIndex = 41;
            this.label13.Text = "C1:";
            // 
            // ntxtC1
            // 
            this.ntxtC1.DecimalPlaces = 3;
            this.ntxtC1.Location = new System.Drawing.Point(106, 239);
            this.ntxtC1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ntxtC1.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ntxtC1.Name = "ntxtC1";
            this.ntxtC1.Size = new System.Drawing.Size(120, 23);
            this.ntxtC1.TabIndex = 40;
            this.ntxtC1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 15);
            this.label14.TabIndex = 39;
            this.label14.Text = "W:";
            // 
            // ntxtW
            // 
            this.ntxtW.DecimalPlaces = 3;
            this.ntxtW.Location = new System.Drawing.Point(106, 210);
            this.ntxtW.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ntxtW.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.ntxtW.Name = "ntxtW";
            this.ntxtW.Size = new System.Drawing.Size(120, 23);
            this.ntxtW.TabIndex = 38;
            this.ntxtW.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // rtLog
            // 
            this.rtLog.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtLog.Location = new System.Drawing.Point(232, 6);
            this.rtLog.Name = "rtLog";
            this.rtLog.Size = new System.Drawing.Size(799, 686);
            this.rtLog.TabIndex = 44;
            this.rtLog.Text = "";
            // 
            // ntxtMaxZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 704);
            this.Controls.Add(this.rtLog);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ntxtC2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ntxtC1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ntxtW);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ntxtIterationCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ntxtTargetZ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ntxtMaxY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ntxtMinY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ntxtMaxX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ntxtMinX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.ntxtParticlesCount);
            this.Name = "ntxtMaxZ";
            this.Text = "z = 3x^2 - 2xy + 3y^2 - x - y";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ntxtParticlesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtMinX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtMaxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtMinY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtMaxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtTargetZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtIterationCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ntxtW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown ntxtParticlesCount;
        private Button btnStart;
        private Label label1;
        private Label label2;
        private NumericUpDown ntxtMinX;
        private Label label3;
        private NumericUpDown ntxtMaxX;
        private Label label4;
        private NumericUpDown ntxtMinY;
        private Label label5;
        private NumericUpDown ntxtMaxY;
        private Label label8;
        private NumericUpDown ntxtTargetZ;
        private Label label11;
        private NumericUpDown ntxtIterationCount;
        private Label label12;
        private NumericUpDown ntxtC2;
        private Label label13;
        private NumericUpDown ntxtC1;
        private Label label14;
        private NumericUpDown ntxtW;
        private RichTextBox rtLog;
    }
}