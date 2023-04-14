namespace MariaWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ExitButton1 = new Button();
            ExitButton2 = new Button();
            CountLabel = new Label();
            CounterButton = new Button();
            SuspendLayout();
            // 
            // ExitButton1
            // 
            ExitButton1.BackColor = SystemColors.ActiveCaption;
            ExitButton1.Location = new Point(33, 360);
            ExitButton1.Name = "ExitButton1";
            ExitButton1.Size = new Size(169, 78);
            ExitButton1.TabIndex = 0;
            ExitButton1.Text = "Выход";
            ExitButton1.UseVisualStyleBackColor = false;
            ExitButton1.Click += Exit;
            // 
            // ExitButton2
            // 
            ExitButton2.BackColor = SystemColors.ControlDarkDark;
            ExitButton2.Location = new Point(619, 369);
            ExitButton2.Name = "ExitButton2";
            ExitButton2.Size = new Size(169, 78);
            ExitButton2.TabIndex = 1;
            ExitButton2.Text = "Тоже выход";
            ExitButton2.UseVisualStyleBackColor = false;
            ExitButton2.Click += Exit;
            // 
            // CountLabel
            // 
            CountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            CountLabel.AutoSize = true;
            CountLabel.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            CountLabel.Location = new Point(361, 67);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(88, 106);
            CountLabel.TabIndex = 2;
            CountLabel.Text = "8";
            // 
            // CounterButton
            // 
            CounterButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CounterButton.Location = new Point(324, 208);
            CounterButton.Name = "CounterButton";
            CounterButton.Size = new Size(141, 92);
            CounterButton.TabIndex = 3;
            CounterButton.Text = "Нажми меня!";
            CounterButton.UseVisualStyleBackColor = true;
            CounterButton.Click += CounterButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(CounterButton);
            Controls.Add(CountLabel);
            Controls.Add(ExitButton2);
            Controls.Add(ExitButton1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Самое полезное приложение в мире";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton1;
        private Button ExitButton2;
        private Button CounterButton;
        internal Label CountLabel;
    }
}