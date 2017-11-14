namespace GitTesting
{
    partial class Test_from
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Test_button = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Test_button
            // 
            this.Test_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Test_button.Location = new System.Drawing.Point(289, 123);
            this.Test_button.Name = "Test_button";
            this.Test_button.Size = new System.Drawing.Size(304, 150);
            this.Test_button.TabIndex = 0;
            this.Test_button.Text = "Coooler Knopf";
            this.Test_button.UseVisualStyleBackColor = false;
            this.Test_button.Click += new System.EventHandler(this.Test_button_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(291, 296);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(301, 103);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "Zweiter cooler Knopf";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // Test_from
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 457);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.Test_button);
            this.Name = "Test_from";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Test_button;
        private System.Windows.Forms.Button btn_2;
    }
}

