
namespace MathsQuiz
{
    partial class MathsQuizForm
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
            this.components = new System.ComponentModel.Container();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLeftLable = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusOperationLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.plusEqualsLabel = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.minusOperationLabel = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.minusEqualsLabel = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.multiplyOperationLabel = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.multiplyEqualsLabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.divideOperationLabel = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.divideEqualsLabel = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sum.Location = new System.Drawing.Point(314, 82);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(120, 39);
            this.sum.TabIndex = 2;
            this.sum.ValueChanged += new System.EventHandler(this.correctAdditionAnswer);
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(268, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // timeLeftLable
            // 
            this.timeLeftLable.AutoSize = true;
            this.timeLeftLable.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeLeftLable.Location = new System.Drawing.Point(163, 9);
            this.timeLeftLable.Name = "timeLeftLable";
            this.timeLeftLable.Size = new System.Drawing.Size(99, 30);
            this.timeLeftLable.TabIndex = 1;
            this.timeLeftLable.Text = "Time Left";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 75);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusOperationLabel
            // 
            this.plusOperationLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusOperationLabel.Location = new System.Drawing.Point(116, 75);
            this.plusOperationLabel.Name = "plusOperationLabel";
            this.plusOperationLabel.Size = new System.Drawing.Size(60, 50);
            this.plusOperationLabel.TabIndex = 3;
            this.plusOperationLabel.Text = "+";
            this.plusOperationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusRightLabel.Location = new System.Drawing.Point(182, 75);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusEqualsLabel
            // 
            this.plusEqualsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plusEqualsLabel.Location = new System.Drawing.Point(248, 75);
            this.plusEqualsLabel.Name = "plusEqualsLabel";
            this.plusEqualsLabel.Size = new System.Drawing.Size(60, 50);
            this.plusEqualsLabel.TabIndex = 5;
            this.plusEqualsLabel.Text = "=";
            this.plusEqualsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusLeftLabel.Location = new System.Drawing.Point(50, 120);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 2;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusOperationLabel
            // 
            this.minusOperationLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusOperationLabel.Location = new System.Drawing.Point(116, 120);
            this.minusOperationLabel.Name = "minusOperationLabel";
            this.minusOperationLabel.Size = new System.Drawing.Size(60, 50);
            this.minusOperationLabel.TabIndex = 3;
            this.minusOperationLabel.Text = "-";
            this.minusOperationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusRightLabel.Location = new System.Drawing.Point(182, 120);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 4;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusEqualsLabel
            // 
            this.minusEqualsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minusEqualsLabel.Location = new System.Drawing.Point(248, 120);
            this.minusEqualsLabel.Name = "minusEqualsLabel";
            this.minusEqualsLabel.Size = new System.Drawing.Size(60, 50);
            this.minusEqualsLabel.TabIndex = 5;
            this.minusEqualsLabel.Text = "=";
            this.minusEqualsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difference.Location = new System.Drawing.Point(314, 127);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(120, 39);
            this.difference.TabIndex = 3;
            this.difference.ValueChanged += new System.EventHandler(this.difference_ValueChanged);
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timesLeftLabel.Location = new System.Drawing.Point(50, 166);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 2;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiplyOperationLabel
            // 
            this.multiplyOperationLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplyOperationLabel.Location = new System.Drawing.Point(116, 166);
            this.multiplyOperationLabel.Name = "multiplyOperationLabel";
            this.multiplyOperationLabel.Size = new System.Drawing.Size(60, 50);
            this.multiplyOperationLabel.TabIndex = 3;
            this.multiplyOperationLabel.Text = "x";
            this.multiplyOperationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timesRightLabel.Location = new System.Drawing.Point(182, 166);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 4;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiplyEqualsLabel
            // 
            this.multiplyEqualsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplyEqualsLabel.Location = new System.Drawing.Point(248, 166);
            this.multiplyEqualsLabel.Name = "multiplyEqualsLabel";
            this.multiplyEqualsLabel.Size = new System.Drawing.Size(60, 50);
            this.multiplyEqualsLabel.TabIndex = 5;
            this.multiplyEqualsLabel.Text = "=";
            this.multiplyEqualsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.product.Location = new System.Drawing.Point(314, 173);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(120, 39);
            this.product.TabIndex = 4;
            this.product.ValueChanged += new System.EventHandler(this.product_ValueChanged);
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dividedLeftLabel.Location = new System.Drawing.Point(50, 211);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel.TabIndex = 2;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideOperationLabel
            // 
            this.divideOperationLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divideOperationLabel.Location = new System.Drawing.Point(116, 211);
            this.divideOperationLabel.Name = "divideOperationLabel";
            this.divideOperationLabel.Size = new System.Drawing.Size(60, 50);
            this.divideOperationLabel.TabIndex = 3;
            this.divideOperationLabel.Text = "/";
            this.divideOperationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dividedRightLabel.Location = new System.Drawing.Point(182, 211);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLabel.TabIndex = 4;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideEqualsLabel
            // 
            this.divideEqualsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divideEqualsLabel.Location = new System.Drawing.Point(248, 211);
            this.divideEqualsLabel.Name = "divideEqualsLabel";
            this.divideEqualsLabel.Size = new System.Drawing.Size(60, 50);
            this.divideEqualsLabel.TabIndex = 5;
            this.divideEqualsLabel.Text = "=";
            this.divideEqualsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quotient.Location = new System.Drawing.Point(314, 218);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(120, 39);
            this.quotient.TabIndex = 5;
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startButton.Location = new System.Drawing.Point(172, 304);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(136, 35);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the Quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MathsQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.divideEqualsLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.multiplyEqualsLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.minusEqualsLabel);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.divideOperationLabel);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.multiplyOperationLabel);
            this.Controls.Add(this.plusEqualsLabel);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.minusOperationLabel);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.plusOperationLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeLeftLable);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MathsQuizForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLeftLable;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusOperationLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label plusEqualsLabel;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label minusOperationLabel;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label minusEqualsLabel;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.Label multiplyOperationLabel;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label multiplyEqualsLabel;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.Label divideOperationLabel;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label divideEqualsLabel;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

