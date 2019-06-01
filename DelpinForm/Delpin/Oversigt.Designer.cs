namespace Delpin
{
    partial class Oversigt
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.VisLedigeRessourcer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(181, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(723, 313);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // VisLedigeRessourcer
            // 
            this.VisLedigeRessourcer.Location = new System.Drawing.Point(12, 330);
            this.VisLedigeRessourcer.Name = "VisLedigeRessourcer";
            this.VisLedigeRessourcer.Size = new System.Drawing.Size(163, 37);
            this.VisLedigeRessourcer.TabIndex = 1;
            this.VisLedigeRessourcer.Text = "VisLedigeRessourcer";
            this.VisLedigeRessourcer.UseVisualStyleBackColor = true;
            this.VisLedigeRessourcer.Click += new System.EventHandler(this.button1_Click);
            // 
            // Oversigt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.VisLedigeRessourcer);
            this.Controls.Add(this.listView1);
            this.Name = "Oversigt";
            this.Text = "Oversigt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button VisLedigeRessourcer;
    }
}