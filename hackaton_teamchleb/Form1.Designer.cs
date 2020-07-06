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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.input_textbox = new System.Windows.Forms.RichTextBox();
            this.output_textbox = new System.Windows.Forms.RichTextBox();
            this.rotor3_ringPosition = new System.Windows.Forms.NumericUpDown();
            this.rotor2_ringPosition = new System.Windows.Forms.NumericUpDown();
            this.rotor1_ringPosition = new System.Windows.Forms.NumericUpDown();
            this.rotor3_position = new System.Windows.Forms.NumericUpDown();
            this.rotor2_position = new System.Windows.Forms.NumericUpDown();
            this.rotor1_position = new System.Windows.Forms.NumericUpDown();
            this.code_button = new System.Windows.Forms.Button();
            this.output_box = new System.Windows.Forms.GroupBox();
            this.input_box = new System.Windows.Forms.GroupBox();
            this.rotor1_box = new System.Windows.Forms.GroupBox();
            this.rotor1_label2 = new System.Windows.Forms.Label();
            this.rotor1_label1 = new System.Windows.Forms.Label();
            this.rotor2_box = new System.Windows.Forms.GroupBox();
            this.rotor2_label2 = new System.Windows.Forms.Label();
            this.rotor2_label1 = new System.Windows.Forms.Label();
            this.rotor3_box = new System.Windows.Forms.GroupBox();
            this.rotor3_label2 = new System.Windows.Forms.Label();
            this.rotor3_label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rotor3_ringPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor2_ringPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor1_ringPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor3_position)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor2_position)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor1_position)).BeginInit();
            this.output_box.SuspendLayout();
            this.input_box.SuspendLayout();
            this.rotor1_box.SuspendLayout();
            this.rotor2_box.SuspendLayout();
            this.rotor3_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_textbox
            // 
            this.input_textbox.BackColor = System.Drawing.Color.White;
            this.input_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_textbox.Location = new System.Drawing.Point(0, 20);
            this.input_textbox.Margin = new System.Windows.Forms.Padding(10);
            this.input_textbox.Name = "input_textbox";
            this.input_textbox.Size = new System.Drawing.Size(260, 100);
            this.input_textbox.TabIndex = 1;
            this.input_textbox.Text = "";
            // 
            // output_textbox
            // 
            this.output_textbox.BackColor = System.Drawing.Color.White;
            this.output_textbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_textbox.Location = new System.Drawing.Point(0, 20);
            this.output_textbox.Margin = new System.Windows.Forms.Padding(10);
            this.output_textbox.Name = "output_textbox";
            this.output_textbox.ReadOnly = true;
            this.output_textbox.Size = new System.Drawing.Size(260, 100);
            this.output_textbox.TabIndex = 2;
            this.output_textbox.Text = "";
            // 
            // rotor3_ringPosition
            // 
            this.rotor3_ringPosition.Location = new System.Drawing.Point(144, 42);
            this.rotor3_ringPosition.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.rotor3_ringPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rotor3_ringPosition.Name = "rotor3_ringPosition";
            this.rotor3_ringPosition.Size = new System.Drawing.Size(120, 27);
            this.rotor3_ringPosition.TabIndex = 3;
            this.rotor3_ringPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rotor2_ringPosition
            // 
            this.rotor2_ringPosition.Location = new System.Drawing.Point(144, 42);
            this.rotor2_ringPosition.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.rotor2_ringPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rotor2_ringPosition.Name = "rotor2_ringPosition";
            this.rotor2_ringPosition.Size = new System.Drawing.Size(120, 27);
            this.rotor2_ringPosition.TabIndex = 4;
            this.rotor2_ringPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rotor1_ringPosition
            // 
            this.rotor1_ringPosition.Location = new System.Drawing.Point(144, 42);
            this.rotor1_ringPosition.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.rotor1_ringPosition.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rotor1_ringPosition.Name = "rotor1_ringPosition";
            this.rotor1_ringPosition.Size = new System.Drawing.Size(120, 27);
            this.rotor1_ringPosition.TabIndex = 5;
            this.rotor1_ringPosition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rotor3_position
            // 
            this.rotor3_position.Location = new System.Drawing.Point(6, 42);
            this.rotor3_position.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.rotor3_position.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rotor3_position.Name = "rotor3_position";
            this.rotor3_position.Size = new System.Drawing.Size(120, 27);
            this.rotor3_position.TabIndex = 6;
            this.rotor3_position.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rotor2_position
            // 
            this.rotor2_position.Location = new System.Drawing.Point(6, 42);
            this.rotor2_position.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.rotor2_position.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rotor2_position.Name = "rotor2_position";
            this.rotor2_position.Size = new System.Drawing.Size(120, 27);
            this.rotor2_position.TabIndex = 7;
            this.rotor2_position.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rotor1_position
            // 
            this.rotor1_position.Location = new System.Drawing.Point(6, 42);
            this.rotor1_position.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.rotor1_position.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rotor1_position.Name = "rotor1_position";
            this.rotor1_position.Size = new System.Drawing.Size(120, 27);
            this.rotor1_position.TabIndex = 8;
            this.rotor1_position.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // code_button
            // 
            this.code_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.code_button.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.code_button.Location = new System.Drawing.Point(12, 285);
            this.code_button.Margin = new System.Windows.Forms.Padding(10);
            this.code_button.Name = "code_button";
            this.code_button.Padding = new System.Windows.Forms.Padding(10);
            this.code_button.Size = new System.Drawing.Size(260, 120);
            this.code_button.TabIndex = 9;
            this.code_button.Text = "Szyfruj";
            this.code_button.UseVisualStyleBackColor = true;
            this.code_button.Click += new System.EventHandler(this.code_button_Click);
            // 
            // output_box
            // 
            this.output_box.Controls.Add(this.output_textbox);
            this.output_box.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.output_box.Location = new System.Drawing.Point(12, 12);
            this.output_box.Name = "output_box";
            this.output_box.Size = new System.Drawing.Size(260, 120);
            this.output_box.TabIndex = 18;
            this.output_box.TabStop = false;
            this.output_box.Text = "Wyjście";
            // 
            // input_box
            // 
            this.input_box.Controls.Add(this.input_textbox);
            this.input_box.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.input_box.Location = new System.Drawing.Point(12, 145);
            this.input_box.Name = "input_box";
            this.input_box.Size = new System.Drawing.Size(260, 120);
            this.input_box.TabIndex = 19;
            this.input_box.TabStop = false;
            this.input_box.Text = "Wejście";
            // 
            // rotor1_box
            // 
            this.rotor1_box.Controls.Add(this.rotor1_label2);
            this.rotor1_box.Controls.Add(this.rotor1_label1);
            this.rotor1_box.Controls.Add(this.rotor1_position);
            this.rotor1_box.Controls.Add(this.rotor1_ringPosition);
            this.rotor1_box.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotor1_box.Location = new System.Drawing.Point(285, 12);
            this.rotor1_box.Name = "rotor1_box";
            this.rotor1_box.Size = new System.Drawing.Size(270, 70);
            this.rotor1_box.TabIndex = 20;
            this.rotor1_box.TabStop = false;
            this.rotor1_box.Text = "Rotor Lewy";
            // 
            // rotor1_label2
            // 
            this.rotor1_label2.AutoSize = true;
            this.rotor1_label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rotor1_label2.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotor1_label2.Location = new System.Drawing.Point(141, 23);
            this.rotor1_label2.Name = "rotor1_label2";
            this.rotor1_label2.Size = new System.Drawing.Size(112, 16);
            this.rotor1_label2.TabIndex = 21;
            this.rotor1_label2.Text = "Ring position";
            // 
            // rotor1_label1
            // 
            this.rotor1_label1.AutoSize = true;
            this.rotor1_label1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotor1_label1.Location = new System.Drawing.Point(3, 23);
            this.rotor1_label1.Name = "rotor1_label1";
            this.rotor1_label1.Size = new System.Drawing.Size(120, 16);
            this.rotor1_label1.TabIndex = 22;
            this.rotor1_label1.Text = "Rotor position";
            // 
            // rotor2_box
            // 
            this.rotor2_box.Controls.Add(this.rotor2_label2);
            this.rotor2_box.Controls.Add(this.rotor2_label1);
            this.rotor2_box.Controls.Add(this.rotor2_ringPosition);
            this.rotor2_box.Controls.Add(this.rotor2_position);
            this.rotor2_box.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotor2_box.Location = new System.Drawing.Point(285, 88);
            this.rotor2_box.Name = "rotor2_box";
            this.rotor2_box.Size = new System.Drawing.Size(270, 70);
            this.rotor2_box.TabIndex = 23;
            this.rotor2_box.TabStop = false;
            this.rotor2_box.Text = "Rotor Środkowy";
            // 
            // rotor2_label2
            // 
            this.rotor2_label2.AutoSize = true;
            this.rotor2_label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rotor2_label2.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotor2_label2.Location = new System.Drawing.Point(141, 23);
            this.rotor2_label2.Name = "rotor2_label2";
            this.rotor2_label2.Size = new System.Drawing.Size(112, 16);
            this.rotor2_label2.TabIndex = 21;
            this.rotor2_label2.Text = "Ring position";
            // 
            // rotor2_label1
            // 
            this.rotor2_label1.AutoSize = true;
            this.rotor2_label1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotor2_label1.Location = new System.Drawing.Point(3, 23);
            this.rotor2_label1.Name = "rotor2_label1";
            this.rotor2_label1.Size = new System.Drawing.Size(120, 16);
            this.rotor2_label1.TabIndex = 22;
            this.rotor2_label1.Text = "Rotor position";
            // 
            // rotor3_box
            // 
            this.rotor3_box.Controls.Add(this.rotor3_label2);
            this.rotor3_box.Controls.Add(this.rotor3_label1);
            this.rotor3_box.Controls.Add(this.rotor3_position);
            this.rotor3_box.Controls.Add(this.rotor3_ringPosition);
            this.rotor3_box.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rotor3_box.Location = new System.Drawing.Point(285, 164);
            this.rotor3_box.Name = "rotor3_box";
            this.rotor3_box.Size = new System.Drawing.Size(270, 70);
            this.rotor3_box.TabIndex = 23;
            this.rotor3_box.TabStop = false;
            this.rotor3_box.Text = "Rotor Prawy";
            // 
            // rotor3_label2
            // 
            this.rotor3_label2.AutoSize = true;
            this.rotor3_label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rotor3_label2.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotor3_label2.Location = new System.Drawing.Point(141, 23);
            this.rotor3_label2.Name = "rotor3_label2";
            this.rotor3_label2.Size = new System.Drawing.Size(112, 16);
            this.rotor3_label2.TabIndex = 21;
            this.rotor3_label2.Text = "Ring position";
            // 
            // rotor3_label1
            // 
            this.rotor3_label1.AutoSize = true;
            this.rotor3_label1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotor3_label1.Location = new System.Drawing.Point(3, 23);
            this.rotor3_label1.Name = "rotor3_label1";
            this.rotor3_label1.Size = new System.Drawing.Size(120, 16);
            this.rotor3_label1.TabIndex = 22;
            this.rotor3_label1.Text = "Rotor position";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 422);
            this.Controls.Add(this.rotor3_box);
            this.Controls.Add(this.rotor2_box);
            this.Controls.Add(this.rotor1_box);
            this.Controls.Add(this.input_box);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.code_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Enigma";
            ((System.ComponentModel.ISupportInitialize)(this.rotor3_ringPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor2_ringPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor1_ringPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor3_position)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor2_position)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotor1_position)).EndInit();
            this.output_box.ResumeLayout(false);
            this.input_box.ResumeLayout(false);
            this.rotor1_box.ResumeLayout(false);
            this.rotor1_box.PerformLayout();
            this.rotor2_box.ResumeLayout(false);
            this.rotor2_box.PerformLayout();
            this.rotor3_box.ResumeLayout(false);
            this.rotor3_box.PerformLayout();
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
        private System.Windows.Forms.GroupBox output_box;
        private System.Windows.Forms.GroupBox input_box;
        private System.Windows.Forms.GroupBox rotor1_box;
        private System.Windows.Forms.Label rotor1_label2;
        private System.Windows.Forms.Label rotor1_label1;
        private System.Windows.Forms.GroupBox rotor2_box;
        private System.Windows.Forms.Label rotor2_label2;
        private System.Windows.Forms.Label rotor2_label1;
        private System.Windows.Forms.GroupBox rotor3_box;
        private System.Windows.Forms.Label rotor3_label2;
        private System.Windows.Forms.Label rotor3_label1;
    }
}

