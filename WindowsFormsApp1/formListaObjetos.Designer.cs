namespace WindowsFormsApp1
{
    partial class formListaObjetos
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
            this.cjaObjetos1 = new System.Windows.Forms.ListBox();
            this.cjaObjetos2 = new System.Windows.Forms.ListBox();
            this.btonIngreso = new System.Windows.Forms.Button();
            this.trasladarItem = new System.Windows.Forms.Button();
            this.trasladarUnItem = new System.Windows.Forms.Button();
            this.regresarUnItem = new System.Windows.Forms.Button();
            this.ingItem = new System.Windows.Forms.TextBox();
            this.borrarUnItemDer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rnoMenu2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cjaObjetos1
            // 
            this.cjaObjetos1.FormattingEnabled = true;
            this.cjaObjetos1.Location = new System.Drawing.Point(33, 50);
            this.cjaObjetos1.Name = "cjaObjetos1";
            this.cjaObjetos1.Size = new System.Drawing.Size(261, 290);
            this.cjaObjetos1.TabIndex = 0;
            // 
            // cjaObjetos2
            // 
            this.cjaObjetos2.FormattingEnabled = true;
            this.cjaObjetos2.Location = new System.Drawing.Point(444, 50);
            this.cjaObjetos2.Name = "cjaObjetos2";
            this.cjaObjetos2.Size = new System.Drawing.Size(318, 290);
            this.cjaObjetos2.TabIndex = 1;
            // 
            // btonIngreso
            // 
            this.btonIngreso.Location = new System.Drawing.Point(226, 24);
            this.btonIngreso.Name = "btonIngreso";
            this.btonIngreso.Size = new System.Drawing.Size(75, 23);
            this.btonIngreso.TabIndex = 2;
            this.btonIngreso.Text = "Ingresar";
            this.btonIngreso.UseVisualStyleBackColor = true;
            this.btonIngreso.Click += new System.EventHandler(this.btonIngreso_Click);
            // 
            // trasladarItem
            // 
            this.trasladarItem.Location = new System.Drawing.Point(339, 73);
            this.trasladarItem.Name = "trasladarItem";
            this.trasladarItem.Size = new System.Drawing.Size(75, 23);
            this.trasladarItem.TabIndex = 3;
            this.trasladarItem.Text = ">>";
            this.trasladarItem.UseVisualStyleBackColor = true;
            this.trasladarItem.Click += new System.EventHandler(this.trasladarItem_Click);
            // 
            // trasladarUnItem
            // 
            this.trasladarUnItem.Location = new System.Drawing.Point(339, 128);
            this.trasladarUnItem.Name = "trasladarUnItem";
            this.trasladarUnItem.Size = new System.Drawing.Size(75, 23);
            this.trasladarUnItem.TabIndex = 4;
            this.trasladarUnItem.Text = ">";
            this.trasladarUnItem.UseVisualStyleBackColor = true;
            this.trasladarUnItem.Click += new System.EventHandler(this.trasladarUnItem_Click);
            // 
            // regresarUnItem
            // 
            this.regresarUnItem.Location = new System.Drawing.Point(339, 185);
            this.regresarUnItem.Name = "regresarUnItem";
            this.regresarUnItem.Size = new System.Drawing.Size(75, 23);
            this.regresarUnItem.TabIndex = 5;
            this.regresarUnItem.Text = "<";
            this.regresarUnItem.UseVisualStyleBackColor = true;
            this.regresarUnItem.Click += new System.EventHandler(this.regresarUnItem_Click);
            // 
            // ingItem
            // 
            this.ingItem.Location = new System.Drawing.Point(33, 24);
            this.ingItem.Name = "ingItem";
            this.ingItem.Size = new System.Drawing.Size(187, 20);
            this.ingItem.TabIndex = 6;
            // 
            // borrarUnItemDer
            // 
            this.borrarUnItemDer.Location = new System.Drawing.Point(339, 246);
            this.borrarUnItemDer.Name = "borrarUnItemDer";
            this.borrarUnItemDer.Size = new System.Drawing.Size(75, 23);
            this.borrarUnItemDer.TabIndex = 7;
            this.borrarUnItemDer.Text = "...";
            this.borrarUnItemDer.UseVisualStyleBackColor = true;
            this.borrarUnItemDer.Click += new System.EventHandler(this.borrarUnItemDer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rnoMenu2
            // 
            this.rnoMenu2.Location = new System.Drawing.Point(609, 358);
            this.rnoMenu2.Name = "rnoMenu2";
            this.rnoMenu2.Size = new System.Drawing.Size(152, 40);
            this.rnoMenu2.TabIndex = 9;
            this.rnoMenu2.Text = "Volver a menu";
            this.rnoMenu2.UseVisualStyleBackColor = true;
            this.rnoMenu2.Click += new System.EventHandler(this.rnoMenu2_Click);
            // 
            // formListaObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rnoMenu2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.borrarUnItemDer);
            this.Controls.Add(this.ingItem);
            this.Controls.Add(this.regresarUnItem);
            this.Controls.Add(this.trasladarUnItem);
            this.Controls.Add(this.trasladarItem);
            this.Controls.Add(this.btonIngreso);
            this.Controls.Add(this.cjaObjetos2);
            this.Controls.Add(this.cjaObjetos1);
            this.Name = "formListaObjetos";
            this.Text = "formListaObjetos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cjaObjetos1;
        private System.Windows.Forms.ListBox cjaObjetos2;
        private System.Windows.Forms.Button btonIngreso;
        private System.Windows.Forms.Button trasladarItem;
        private System.Windows.Forms.Button trasladarUnItem;
        private System.Windows.Forms.Button regresarUnItem;
        private System.Windows.Forms.TextBox ingItem;
        private System.Windows.Forms.Button borrarUnItemDer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button rnoMenu2;
    }
}