using System;
using System.Windows.Forms;

namespace WinForms25052020Test1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cleanButton2 = new System.Windows.Forms.Button();
            this.addRndStrButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Violet;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(355, 420);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Violet;
            this.textBox1.Location = new System.Drawing.Point(391, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 22);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.Location = new System.Drawing.Point(516, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cleanButton2
            // 
            this.cleanButton2.BackColor = System.Drawing.Color.Violet;
            this.cleanButton2.Location = new System.Drawing.Point(516, 192);
            this.cleanButton2.Name = "cleanButton2";
            this.cleanButton2.Size = new System.Drawing.Size(141, 45);
            this.cleanButton2.TabIndex = 3;
            this.cleanButton2.Text = "Clean";
            this.cleanButton2.UseVisualStyleBackColor = false;
            this.cleanButton2.Click += new System.EventHandler(this.cleanButton2_Click);
            //
            // addRndStrButton3
            // 
            this.addRndStrButton3.BackColor = System.Drawing.Color.Violet;
            this.addRndStrButton3.Location = new System.Drawing.Point(516, 292);
            this.addRndStrButton3.Name = "addRndStrButton3";
            this.addRndStrButton3.Size = new System.Drawing.Size(141, 45);
            this.addRndStrButton3.TabIndex = 3;
            this.addRndStrButton3.Text = "Add Random Strings";
            this.addRndStrButton3.UseVisualStyleBackColor = true;
            this.addRndStrButton3.Click += new System.EventHandler(this.addRndStrButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(800, 450);


            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cleanButton2);
            this.Controls.Add(this.addRndStrButton3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cleanButton2;
        private System.Windows.Forms.Button addRndStrButton3;
    }
}

