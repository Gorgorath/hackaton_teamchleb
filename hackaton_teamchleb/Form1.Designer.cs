namespace hackaton_teamchleb
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
            this.input_textbox = new System.Windows.Forms.RichTextBox();
            this.output_textbox = new System.Windows.Forms.RichTextBox();
            this.rotor3_ringPosition = new System.Windows.Forms.NumericUpDown();
            this.rotor2_ringPosition = new System.Windows.Forms.NumericUpDown();
            this.rotor1_ringPosition = new System.Windows.Forms.NumericUpDown();
            this.rotor3_position = new System.Windows.Forms.NumericUpDown();
            this.rotor2_position = new System.Windows.Forms.NumericUpDown();
            this.rotor1_position = new System.Windows.Forms.NumericUpDown();
            this.code_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rotor3_ringPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor2_ringPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor1_ringPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor3_position)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor2_position)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor1_position)).BeginInit();
            this.SuspendLayout();
            // 
            // input_textbox
            // 
            this.input_textbox.Location = new System.Drawing.Point(118, 12);
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(100, 96);
            this.input_textbox.TabIndex = 1;
            this.input_textbox.Text = "";
            // 
            // output_textbox
            // 
            this.output_textbox.Location = new System.Drawing.Point(12, 12);
            this.output_textbox.Name = "output_textbox";
            this.output_textbox.ReadOnly = true;
            this.output_textbox.Size = new System.Drawing.Size(100, 96);
            this.output_textbox.TabIndex = 2;
            this.output_textbox.Text = "";
            // 
            // rotor3_ringPosition
            // 
            this.rotor3_ringPosition.Location = new System.Drawing.Point(350, 69);
            this.rotor3_ringPosition.Name = "rotor3_ringPosition";
            this.rotor3_ringPosition.Size = new System.Drawing.Size(120, 22);
            this.rotor3_ringPosition.TabIndex = 3;
            // 
            // rotor2_ringPosition
            // 
            this.rotor2_ringPosition.Location = new System.Drawing.Point(350, 41);
            this.rotor2_ringPosition.Name = "rotor2_ringPosition";
            this.rotor2_ringPosition.Size = new System.Drawing.Size(120, 22);
            this.rotor2_ringPosition.TabIndex = 4;
            // 
            // rotor1_ringPosition
            // 
            this.rotor1_ringPosition.Location = new System.Drawing.Point(350, 13);
            this.rotor1_ringPosition.Name = "rotor1_ringPosition";
            this.rotor1_ringPosition.Size = new System.Drawing.Size(120, 22);
            this.rotor1_ringPosition.TabIndex = 5;
            // 
            // rotor3_position
            // 
            this.rotor3_position.Location = new System.Drawing.Point(224, 69);
            this.rotor3_position.Name = "rotor3_position";
            this.rotor3_position.Size = new System.Drawing.Size(120, 22);
            this.rotor3_position.TabIndex = 6;
            // 
            // rotor2_position
            // 
            this.rotor2_position.Location = new System.Drawing.Point(224, 41);
            this.rotor2_position.Name = "rotor2_position";
            this.rotor2_position.Size = new System.Drawing.Size(120, 22);
            this.rotor2_position.TabIndex = 7;
            // 
            // rotor1_position
            // 
            this.rotor1_position.Location = new System.Drawing.Point(224, 13);
            this.rotor1_position.Name = "rotor1_position";
            this.rotor1_position.Size = new System.Drawing.Size(120, 22);
            this.rotor1_position.TabIndex = 8;
            // 
            // code_button
            // 
            this.code_button.Location = new System.Drawing.Point(507, 40);
            this.code_button.Name = "code_button";
            this.code_button.Size = new System.Drawing.Size(75, 23);
            this.code_button.TabIndex = 9;
            this.code_button.Text = "button1";
            this.code_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.code_button);
            this.Controls.Add(this.rotor1_position);
            this.Controls.Add(this.rotor2_position);
            this.Controls.Add(this.rotor3_position);
            this.Controls.Add(this.rotor1_ringPosition);
            this.Controls.Add(this.rotor2_ringPosition);
            this.Controls.Add(this.rotor3_ringPosition);
            this.Controls.Add(this.output_textbox);
            this.Controls.Add(this.input_textbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rotor3_ringPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor2_ringPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor1_ringPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor3_position)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor2_position)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor1_position)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox input_textbox;
        private System.Windows.Forms.RichTextBox output_textbox;
        private System.Windows.Forms.NumericUpDown rotor3_ringPosition;
        private System.Windows.Forms.NumericUpDown rotor2_ringPosition;
        private System.Windows.Forms.NumericUpDown rotor1_ringPosition;
        private System.Windows.Forms.NumericUpDown rotor3_position;
        private System.Windows.Forms.NumericUpDown rotor2_position;
        private System.Windows.Forms.NumericUpDown rotor1_position;
        private System.Windows.Forms.Button code_button;
    }
}

