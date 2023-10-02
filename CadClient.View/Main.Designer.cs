namespace CadClient.View
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            statusStrip1 = new StatusStrip();
            Clientes = new DataGridView();
            toolStrip1 = new ToolStrip();
            Incluir = new ToolStripButton();
            Alterar = new ToolStripButton();
            Excluir = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)Clientes).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 592);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1075, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // Clientes
            // 
            Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Clientes.Location = new Point(12, 133);
            Clientes.Name = "Clientes";
            Clientes.RowTemplate.Height = 25;
            Clientes.Size = new Size(1051, 456);
            Clientes.TabIndex = 1;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { Incluir, Alterar, Excluir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1075, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // Incluir
            // 
            Incluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Incluir.Image = (Image)resources.GetObject("Incluir.Image");
            Incluir.ImageTransparentColor = Color.Magenta;
            Incluir.Name = "Incluir";
            Incluir.Size = new Size(23, 22);
            Incluir.Text = "toolStripButton1";
            // 
            // Alterar
            // 
            Alterar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Alterar.Image = (Image)resources.GetObject("Alterar.Image");
            Alterar.ImageTransparentColor = Color.Magenta;
            Alterar.Name = "Alterar";
            Alterar.Size = new Size(23, 22);
            Alterar.Text = "toolStripButton1";
            // 
            // Excluir
            // 
            Excluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Excluir.Image = (Image)resources.GetObject("Excluir.Image");
            Excluir.ImageTransparentColor = Color.Magenta;
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(23, 22);
            Excluir.Text = "toolStripButton1";
            Excluir.Click += Excluir_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 614);
            Controls.Add(toolStrip1);
            Controls.Add(Clientes);
            Controls.Add(statusStrip1);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)Clientes).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private DataGridView Clientes;
        private ToolStrip toolStrip1;
        private ToolStripButton Incluir;
        private ToolStripButton Alterar;
        private ToolStripButton Excluir;
    }
}