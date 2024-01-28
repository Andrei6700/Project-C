
using System.Drawing;

namespace Proiect
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label TITLE;
            this.Qwestion = new System.Windows.Forms.Label();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.answer_label = new System.Windows.Forms.Label();
            this.Arms = new System.Windows.Forms.RadioButton();
            this.Shoulders = new System.Windows.Forms.RadioButton();
            this.Legs = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Chest = new System.Windows.Forms.RadioButton();
            this.Back = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            TITLE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TITLE
            // 
            TITLE.Font = new System.Drawing.Font("Myanmar Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TITLE.ForeColor = System.Drawing.Color.Black;
            TITLE.Location = new System.Drawing.Point(104, 12);
            TITLE.Name = "TITLE";
            TITLE.Size = new System.Drawing.Size(531, 61);
            TITLE.TabIndex = 9;
            TITLE.Text = "GYM EDITION";
            TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            TITLE.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Qwestion
            // 
            this.Qwestion.Location = new System.Drawing.Point(193, 119);
            this.Qwestion.Name = "Qwestion";
            this.Qwestion.Size = new System.Drawing.Size(385, 45);
            this.Qwestion.TabIndex = 0;
            this.Qwestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_A
            // 
            this.btn_A.Location = new System.Drawing.Point(269, 180);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(222, 45);
            this.btn_A.TabIndex = 1;
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_B
            // 
            this.btn_B.Location = new System.Drawing.Point(269, 242);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(222, 45);
            this.btn_B.TabIndex = 2;
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_C
            // 
            this.btn_C.Location = new System.Drawing.Point(269, 300);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(222, 45);
            this.btn_C.TabIndex = 3;
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(354, 396);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // answer_label
            // 
            this.answer_label.BackColor = System.Drawing.SystemColors.Control;
            this.answer_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.answer_label.Location = new System.Drawing.Point(211, 361);
            this.answer_label.Name = "answer_label";
            this.answer_label.Size = new System.Drawing.Size(329, 23);
            this.answer_label.TabIndex = 5;
            this.answer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Arms
            // 
            this.Arms.AutoSize = true;
            this.Arms.Location = new System.Drawing.Point(37, 170);
            this.Arms.Name = "Arms";
            this.Arms.Size = new System.Drawing.Size(48, 17);
            this.Arms.TabIndex = 6;
            this.Arms.TabStop = true;
            this.Arms.Text = "Arms";
            this.Arms.UseVisualStyleBackColor = true;
            this.Arms.CheckedChanged += new System.EventHandler(this.Arms_CheckedChanged);
            // 
            // Shoulders
            // 
            this.Shoulders.AutoSize = true;
            this.Shoulders.Location = new System.Drawing.Point(37, 194);
            this.Shoulders.Name = "Shoulders";
            this.Shoulders.Size = new System.Drawing.Size(72, 17);
            this.Shoulders.TabIndex = 7;
            this.Shoulders.TabStop = true;
            this.Shoulders.Text = "Shoulders";
            this.Shoulders.UseVisualStyleBackColor = true;
            this.Shoulders.CheckedChanged += new System.EventHandler(this.Shoulders_CheckedChanged);
            // 
            // Legs
            // 
            this.Legs.AutoSize = true;
            this.Legs.Location = new System.Drawing.Point(37, 218);
            this.Legs.Name = "Legs";
            this.Legs.Size = new System.Drawing.Size(48, 17);
            this.Legs.TabIndex = 8;
            this.Legs.TabStop = true;
            this.Legs.Text = "Legs";
            this.Legs.UseVisualStyleBackColor = true;
            this.Legs.CheckedChanged += new System.EventHandler(this.Legs_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Chest
            // 
            this.Chest.AutoSize = true;
            this.Chest.Location = new System.Drawing.Point(37, 242);
            this.Chest.Name = "Chest";
            this.Chest.Size = new System.Drawing.Size(52, 17);
            this.Chest.TabIndex = 11;
            this.Chest.TabStop = true;
            this.Chest.Text = "Chest";
            this.Chest.UseVisualStyleBackColor = true;
            this.Chest.CheckedChanged += new System.EventHandler(this.Chest_CheckedChanged);
            // 
            // Back
            // 
            this.Back.AutoSize = true;
            this.Back.Location = new System.Drawing.Point(37, 266);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(50, 17);
            this.Back.TabIndex = 12;
            this.Back.TabStop = true;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.CheckedChanged += new System.EventHandler(this.Back_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Chest);
            this.Controls.Add(TITLE);
            this.Controls.Add(this.Legs);
            this.Controls.Add(this.Shoulders);
            this.Controls.Add(this.Arms);
            this.Controls.Add(this.answer_label);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_A);
            this.Controls.Add(this.Qwestion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Qwestion;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label answer_label;
        private System.Windows.Forms.RadioButton Arms;
        private System.Windows.Forms.RadioButton Shoulders;
        private System.Windows.Forms.RadioButton Legs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton Chest;
        private System.Windows.Forms.RadioButton Back;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

