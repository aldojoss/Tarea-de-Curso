namespace ELECTROCOST
{
    partial class InterfazBase
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoAparatoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            aparatosToolStripMenuItem = new ToolStripMenuItem();
            editarAToolStripMenuItem = new ToolStripMenuItem();
            eliminarAparatosToolStripMenuItem = new ToolStripMenuItem();
            limpiarListaToolStripMenuItem = new ToolStripMenuItem();
            consumoToolStripMenuItem = new ToolStripMenuItem();
            calcularConsumoDiarioToolStripMenuItem = new ToolStripMenuItem();
            calcularConsumoMensualToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            manualDeInstruccionesToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.Font = new Font("Sans Serif Collection", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aparatosToolStripMenuItem, consumoToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(898, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoAparatoToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(89, 33);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoAparatoToolStripMenuItem
            // 
            nuevoAparatoToolStripMenuItem.Name = "nuevoAparatoToolStripMenuItem";
            nuevoAparatoToolStripMenuItem.Size = new Size(234, 38);
            nuevoAparatoToolStripMenuItem.Text = "Nuevo Aparato";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(234, 38);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += Salir;
            // 
            // aparatosToolStripMenuItem
            // 
            aparatosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editarAToolStripMenuItem, eliminarAparatosToolStripMenuItem, limpiarListaToolStripMenuItem });
            aparatosToolStripMenuItem.Name = "aparatosToolStripMenuItem";
            aparatosToolStripMenuItem.Size = new Size(76, 33);
            aparatosToolStripMenuItem.Text = "Editar";
            aparatosToolStripMenuItem.Click += aparatosToolStripMenuItem_Click;
            // 
            // editarAToolStripMenuItem
            // 
            editarAToolStripMenuItem.Name = "editarAToolStripMenuItem";
            editarAToolStripMenuItem.Size = new Size(255, 38);
            editarAToolStripMenuItem.Text = "Editar Aparatos";
            editarAToolStripMenuItem.Click += editarAToolStripMenuItem_Click;
            // 
            // eliminarAparatosToolStripMenuItem
            // 
            eliminarAparatosToolStripMenuItem.Name = "eliminarAparatosToolStripMenuItem";
            eliminarAparatosToolStripMenuItem.Size = new Size(255, 38);
            eliminarAparatosToolStripMenuItem.Text = "Eliminar Aparatos";
            // 
            // limpiarListaToolStripMenuItem
            // 
            limpiarListaToolStripMenuItem.Name = "limpiarListaToolStripMenuItem";
            limpiarListaToolStripMenuItem.Size = new Size(255, 38);
            limpiarListaToolStripMenuItem.Text = "Limpiar Lista";
            // 
            // consumoToolStripMenuItem
            // 
            consumoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calcularConsumoDiarioToolStripMenuItem, calcularConsumoMensualToolStripMenuItem });
            consumoToolStripMenuItem.Name = "consumoToolStripMenuItem";
            consumoToolStripMenuItem.Size = new Size(105, 33);
            consumoToolStripMenuItem.Text = "Consumo";
            // 
            // calcularConsumoDiarioToolStripMenuItem
            // 
            calcularConsumoDiarioToolStripMenuItem.Name = "calcularConsumoDiarioToolStripMenuItem";
            calcularConsumoDiarioToolStripMenuItem.Size = new Size(331, 38);
            calcularConsumoDiarioToolStripMenuItem.Text = "Calcular Consumo Diario";
            // 
            // calcularConsumoMensualToolStripMenuItem
            // 
            calcularConsumoMensualToolStripMenuItem.Name = "calcularConsumoMensualToolStripMenuItem";
            calcularConsumoMensualToolStripMenuItem.Size = new Size(331, 38);
            calcularConsumoMensualToolStripMenuItem.Text = "Calcular Consumo Mensual";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manualDeInstruccionesToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(80, 33);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeInstruccionesToolStripMenuItem
            // 
            manualDeInstruccionesToolStripMenuItem.Name = "manualDeInstruccionesToolStripMenuItem";
            manualDeInstruccionesToolStripMenuItem.Size = new Size(305, 38);
            manualDeInstruccionesToolStripMenuItem.Text = "Manual de Instrucciones";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 37);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Size = new Size(898, 518);
            splitContainer1.SplitterDistance = 299;
            splitContainer1.TabIndex = 1;
            // 
            // InterfazBase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(898, 555);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "InterfazBase";
            Text = "InterfazBase";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem aparatosToolStripMenuItem;
        private ToolStripMenuItem nuevoAparatoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem editarAToolStripMenuItem;
        private ToolStripMenuItem eliminarAparatosToolStripMenuItem;
        private ToolStripMenuItem limpiarListaToolStripMenuItem;
        private ToolStripMenuItem consumoToolStripMenuItem;
        private ToolStripMenuItem calcularConsumoDiarioToolStripMenuItem;
        private ToolStripMenuItem calcularConsumoMensualToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem manualDeInstruccionesToolStripMenuItem;
        private SplitContainer splitContainer1;
    }
}
