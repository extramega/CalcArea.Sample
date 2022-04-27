namespace WinFormsArea
{
    partial class Form1
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
            this.triangleTabPage = new System.Windows.Forms.TabPage();
            this.triangleLabel = new System.Windows.Forms.Label();
            this.triangleInfo = new System.Windows.Forms.TextBox();
            this.triangleCalc = new System.Windows.Forms.Button();
            this.triangleArea = new System.Windows.Forms.TextBox();
            this.triangleC = new System.Windows.Forms.TextBox();
            this.triangleB = new System.Windows.Forms.TextBox();
            this.triangleA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.figureControl = new System.Windows.Forms.TabControl();
            this.circleTabPage = new System.Windows.Forms.TabPage();
            this.circleLabel = new System.Windows.Forms.Label();
            this.circleInfo = new System.Windows.Forms.TextBox();
            this.circleCalc = new System.Windows.Forms.Button();
            this.circleArea = new System.Windows.Forms.TextBox();
            this.circleR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.triangleTabPage.SuspendLayout();
            this.figureControl.SuspendLayout();
            this.circleTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // triangleTabPage
            // 
            this.triangleTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.triangleTabPage.Controls.Add(this.triangleLabel);
            this.triangleTabPage.Controls.Add(this.triangleInfo);
            this.triangleTabPage.Controls.Add(this.triangleCalc);
            this.triangleTabPage.Controls.Add(this.triangleArea);
            this.triangleTabPage.Controls.Add(this.triangleC);
            this.triangleTabPage.Controls.Add(this.triangleB);
            this.triangleTabPage.Controls.Add(this.triangleA);
            this.triangleTabPage.Controls.Add(this.label4);
            this.triangleTabPage.Controls.Add(this.label3);
            this.triangleTabPage.Controls.Add(this.label2);
            this.triangleTabPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.triangleTabPage.Location = new System.Drawing.Point(4, 24);
            this.triangleTabPage.Name = "triangleTabPage";
            this.triangleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.triangleTabPage.Size = new System.Drawing.Size(460, 248);
            this.triangleTabPage.TabIndex = 1;
            this.triangleTabPage.Text = "Triangle";
            this.triangleTabPage.UseVisualStyleBackColor = true;
            // 
            // triangleLabel
            // 
            this.triangleLabel.AutoSize = true;
            this.triangleLabel.Location = new System.Drawing.Point(20, 12);
            this.triangleLabel.Name = "triangleLabel";
            this.triangleLabel.Size = new System.Drawing.Size(237, 21);
            this.triangleLabel.TabIndex = 18;
            this.triangleLabel.Text = "Укажите стороны треугольника";
            // 
            // triangleInfo
            // 
            this.triangleInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.triangleInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.triangleInfo.ForeColor = System.Drawing.Color.Red;
            this.triangleInfo.Location = new System.Drawing.Point(15, 183);
            this.triangleInfo.Multiline = true;
            this.triangleInfo.Name = "triangleInfo";
            this.triangleInfo.Size = new System.Drawing.Size(422, 58);
            this.triangleInfo.TabIndex = 17;
            // 
            // triangleCalc
            // 
            this.triangleCalc.Location = new System.Drawing.Point(15, 146);
            this.triangleCalc.Name = "triangleCalc";
            this.triangleCalc.Size = new System.Drawing.Size(147, 29);
            this.triangleCalc.TabIndex = 14;
            this.triangleCalc.Text = "Считать площадь";
            this.triangleCalc.UseVisualStyleBackColor = true;
            // 
            // triangleArea
            // 
            this.triangleArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.triangleArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triangleArea.Location = new System.Drawing.Point(177, 146);
            this.triangleArea.Name = "triangleArea";
            this.triangleArea.ReadOnly = true;
            this.triangleArea.Size = new System.Drawing.Size(260, 29);
            this.triangleArea.TabIndex = 11;
            // 
            // triangleC
            // 
            this.triangleC.Location = new System.Drawing.Point(54, 111);
            this.triangleC.Name = "triangleC";
            this.triangleC.Size = new System.Drawing.Size(260, 29);
            this.triangleC.TabIndex = 9;
            // 
            // triangleB
            // 
            this.triangleB.Location = new System.Drawing.Point(55, 75);
            this.triangleB.Name = "triangleB";
            this.triangleB.Size = new System.Drawing.Size(260, 29);
            this.triangleB.TabIndex = 8;
            // 
            // triangleA
            // 
            this.triangleA.Location = new System.Drawing.Point(55, 40);
            this.triangleA.Name = "triangleA";
            this.triangleA.Size = new System.Drawing.Size(260, 29);
            this.triangleA.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "c =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "b =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "a =";
            // 
            // figureControl
            // 
            this.figureControl.Controls.Add(this.circleTabPage);
            this.figureControl.Controls.Add(this.triangleTabPage);
            this.figureControl.Location = new System.Drawing.Point(12, 12);
            this.figureControl.Name = "figureControl";
            this.figureControl.SelectedIndex = 0;
            this.figureControl.Size = new System.Drawing.Size(468, 276);
            this.figureControl.TabIndex = 4;
            // 
            // circleTabPage
            // 
            this.circleTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.circleTabPage.Controls.Add(this.circleLabel);
            this.circleTabPage.Controls.Add(this.circleInfo);
            this.circleTabPage.Controls.Add(this.circleCalc);
            this.circleTabPage.Controls.Add(this.circleArea);
            this.circleTabPage.Controls.Add(this.circleR);
            this.circleTabPage.Controls.Add(this.label1);
            this.circleTabPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.circleTabPage.Location = new System.Drawing.Point(4, 24);
            this.circleTabPage.Name = "circleTabPage";
            this.circleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.circleTabPage.Size = new System.Drawing.Size(460, 248);
            this.circleTabPage.TabIndex = 0;
            this.circleTabPage.Text = "Circle";
            // 
            // circleLabel
            // 
            this.circleLabel.AutoSize = true;
            this.circleLabel.Location = new System.Drawing.Point(13, 16);
            this.circleLabel.Name = "circleLabel";
            this.circleLabel.Size = new System.Drawing.Size(168, 21);
            this.circleLabel.TabIndex = 16;
            this.circleLabel.Text = "Укажите радиус круга";
            // 
            // circleInfo
            // 
            this.circleInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.circleInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.circleInfo.ForeColor = System.Drawing.Color.Red;
            this.circleInfo.Location = new System.Drawing.Point(13, 118);
            this.circleInfo.Multiline = true;
            this.circleInfo.Name = "circleInfo";
            this.circleInfo.Size = new System.Drawing.Size(433, 58);
            this.circleInfo.TabIndex = 15;
            // 
            // circleCalc
            // 
            this.circleCalc.Location = new System.Drawing.Point(13, 81);
            this.circleCalc.Name = "circleCalc";
            this.circleCalc.Size = new System.Drawing.Size(147, 29);
            this.circleCalc.TabIndex = 13;
            this.circleCalc.Text = "Считать площадь";
            this.circleCalc.UseVisualStyleBackColor = true;
            // 
            // circleArea
            // 
            this.circleArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.circleArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.circleArea.Location = new System.Drawing.Point(166, 81);
            this.circleArea.Name = "circleArea";
            this.circleArea.ReadOnly = true;
            this.circleArea.Size = new System.Drawing.Size(260, 29);
            this.circleArea.TabIndex = 12;
            // 
            // circleR
            // 
            this.circleR.Location = new System.Drawing.Point(54, 46);
            this.circleR.Name = "circleR";
            this.circleR.Size = new System.Drawing.Size(260, 29);
            this.circleR.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "R =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 293);
            this.Controls.Add(this.figureControl);
            this.Name = "Form1";
            this.Text = "Вычисление площади фигуры";
            this.triangleTabPage.ResumeLayout(false);
            this.triangleTabPage.PerformLayout();
            this.figureControl.ResumeLayout(false);
            this.circleTabPage.ResumeLayout(false);
            this.circleTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TabPage triangleTabPage;
        private TabControl figureControl;
        private TabPage circleTabPage;
        private Label label1;
        private TextBox triangleC;
        private TextBox triangleB;
        private TextBox triangleA;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox circleR;
        private TextBox triangleArea;
        private TextBox circleArea;
        private Button triangleCalc;
        private Button circleCalc;
        private TextBox triangleInfo;
        private TextBox circleInfo;
        private Label circleLabel;
        private Label triangleLabel;
    }
}