﻿namespace UI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblBusquedaR = new System.Windows.Forms.Label();
            this.txtBusquedaR = new System.Windows.Forms.TextBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.btnBusquedaAv = new System.Windows.Forms.Button();
            this.btnListaArt = new System.Windows.Forms.Button();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.btnModificarArt = new System.Windows.Forms.Button();
            this.btnEliminarArt = new System.Windows.Forms.Button();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.pbxEliminarArt = new System.Windows.Forms.PictureBox();
            this.pbxModificarArt = new System.Windows.Forms.PictureBox();
            this.pbxAgregarArt = new System.Windows.Forms.PictureBox();
            this.pbxListaArt = new System.Windows.Forms.PictureBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnModificarCategorias = new System.Windows.Forms.Button();
            this.btnModificarMarcas = new System.Windows.Forms.Button();
            this.toolTipBusqueda = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxModMarcas = new System.Windows.Forms.PictureBox();
            this.pbxModCategorias = new System.Windows.Forms.PictureBox();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEliminarArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModificarArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxListaArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusquedaR
            // 
            this.lblBusquedaR.AutoSize = true;
            this.lblBusquedaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusquedaR.ForeColor = System.Drawing.Color.Transparent;
            this.lblBusquedaR.Location = new System.Drawing.Point(325, 492);
            this.lblBusquedaR.Name = "lblBusquedaR";
            this.lblBusquedaR.Size = new System.Drawing.Size(174, 22);
            this.lblBusquedaR.TabIndex = 1;
            this.lblBusquedaR.Text = "Búsqueda Rápida:";
            // 
            // txtBusquedaR
            // 
            this.txtBusquedaR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaR.Location = new System.Drawing.Point(505, 488);
            this.txtBusquedaR.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtBusquedaR.Name = "txtBusquedaR";
            this.txtBusquedaR.Size = new System.Drawing.Size(226, 30);
            this.txtBusquedaR.TabIndex = 3;
            this.toolTipBusqueda.SetToolTip(this.txtBusquedaR, "Buscar por nombre, descripción, categoría o marca");
            this.txtBusquedaR.TextChanged += new System.EventHandler(this.txtBusquedaR_TextChanged);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.GridColor = System.Drawing.Color.Black;
            this.dgvArticulos.Location = new System.Drawing.Point(328, 0);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(918, 468);
            this.dgvArticulos.TabIndex = 5;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnIzquierda.FlatAppearance.BorderSize = 0;
            this.btnIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzquierda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzquierda.ForeColor = System.Drawing.Color.Black;
            this.btnIzquierda.Location = new System.Drawing.Point(7, 354);
            this.btnIzquierda.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 39);
            this.btnIzquierda.TabIndex = 7;
            this.btnIzquierda.Text = "<";
            this.btnIzquierda.UseVisualStyleBackColor = false;
            this.btnIzquierda.Visible = false;
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDerecha.FlatAppearance.BorderSize = 0;
            this.btnDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDerecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecha.ForeColor = System.Drawing.Color.Black;
            this.btnDerecha.Location = new System.Drawing.Point(270, 354);
            this.btnDerecha.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 39);
            this.btnDerecha.TabIndex = 8;
            this.btnDerecha.Text = ">";
            this.btnDerecha.UseVisualStyleBackColor = false;
            this.btnDerecha.Visible = false;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDetalles.FlatAppearance.BorderSize = 0;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.ForeColor = System.Drawing.Color.Black;
            this.btnDetalles.Location = new System.Drawing.Point(1340, 354);
            this.btnDetalles.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(176, 39);
            this.btnDetalles.TabIndex = 7;
            this.btnDetalles.Text = "Más Detalles [+]";
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // btnBusquedaAv
            // 
            this.btnBusquedaAv.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnBusquedaAv.FlatAppearance.BorderSize = 0;
            this.btnBusquedaAv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusquedaAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaAv.ForeColor = System.Drawing.Color.Black;
            this.btnBusquedaAv.Location = new System.Drawing.Point(954, 484);
            this.btnBusquedaAv.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnBusquedaAv.Name = "btnBusquedaAv";
            this.btnBusquedaAv.Size = new System.Drawing.Size(292, 39);
            this.btnBusquedaAv.TabIndex = 9;
            this.btnBusquedaAv.Text = "Búsqueda Avanzada";
            this.btnBusquedaAv.UseVisualStyleBackColor = false;
            this.btnBusquedaAv.Click += new System.EventHandler(this.btnBusquedaAv_Click);
            // 
            // btnListaArt
            // 
            this.btnListaArt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnListaArt.FlatAppearance.BorderSize = 0;
            this.btnListaArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaArt.ForeColor = System.Drawing.Color.Black;
            this.btnListaArt.Location = new System.Drawing.Point(58, 271);
            this.btnListaArt.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnListaArt.Name = "btnListaArt";
            this.btnListaArt.Size = new System.Drawing.Size(261, 61);
            this.btnListaArt.TabIndex = 0;
            this.btnListaArt.Text = "Lista de Artículos";
            this.btnListaArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaArt.UseVisualStyleBackColor = false;
            this.btnListaArt.Click += new System.EventHandler(this.btnListaArt_Click);
            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarArt.FlatAppearance.BorderSize = 0;
            this.btnAgregarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArt.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarArt.Location = new System.Drawing.Point(58, 339);
            this.btnAgregarArt.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(261, 61);
            this.btnAgregarArt.TabIndex = 7;
            this.btnAgregarArt.Text = "Agregar Artículo";
            this.btnAgregarArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarArt.UseVisualStyleBackColor = false;
            this.btnAgregarArt.Click += new System.EventHandler(this.btnAgregarArt_Click);
            // 
            // btnModificarArt
            // 
            this.btnModificarArt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModificarArt.FlatAppearance.BorderSize = 0;
            this.btnModificarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArt.ForeColor = System.Drawing.Color.Black;
            this.btnModificarArt.Location = new System.Drawing.Point(58, 406);
            this.btnModificarArt.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnModificarArt.Name = "btnModificarArt";
            this.btnModificarArt.Size = new System.Drawing.Size(261, 61);
            this.btnModificarArt.TabIndex = 9;
            this.btnModificarArt.Text = "Modificar Artículo";
            this.btnModificarArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarArt.UseVisualStyleBackColor = false;
            this.btnModificarArt.Click += new System.EventHandler(this.btnModificarArt_Click);
            // 
            // btnEliminarArt
            // 
            this.btnEliminarArt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminarArt.FlatAppearance.BorderSize = 0;
            this.btnEliminarArt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArt.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarArt.Location = new System.Drawing.Point(58, 474);
            this.btnEliminarArt.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnEliminarArt.Name = "btnEliminarArt";
            this.btnEliminarArt.Size = new System.Drawing.Size(261, 61);
            this.btnEliminarArt.TabIndex = 11;
            this.btnEliminarArt.Text = "Eliminar Artículo";
            this.btnEliminarArt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarArt.UseVisualStyleBackColor = false;
            this.btnEliminarArt.Click += new System.EventHandler(this.btnEliminarArt_Click);
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlBotones.Controls.Add(this.pbxEliminarArt);
            this.pnlBotones.Controls.Add(this.btnEliminarArt);
            this.pnlBotones.Controls.Add(this.pbxModificarArt);
            this.pnlBotones.Controls.Add(this.btnModificarArt);
            this.pnlBotones.Controls.Add(this.pbxAgregarArt);
            this.pnlBotones.Controls.Add(this.btnAgregarArt);
            this.pnlBotones.Controls.Add(this.pbxListaArt);
            this.pnlBotones.Controls.Add(this.pbxLogo);
            this.pnlBotones.Controls.Add(this.btnListaArt);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotones.Location = new System.Drawing.Point(0, 0);
            this.pnlBotones.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(323, 547);
            this.pnlBotones.TabIndex = 4;
            // 
            // pbxEliminarArt
            // 
            this.pbxEliminarArt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbxEliminarArt.Image = ((System.Drawing.Image)(resources.GetObject("pbxEliminarArt.Image")));
            this.pbxEliminarArt.ImageLocation = "";
            this.pbxEliminarArt.Location = new System.Drawing.Point(3, 474);
            this.pbxEliminarArt.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pbxEliminarArt.Name = "pbxEliminarArt";
            this.pbxEliminarArt.Size = new System.Drawing.Size(55, 61);
            this.pbxEliminarArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEliminarArt.TabIndex = 12;
            this.pbxEliminarArt.TabStop = false;
            this.pbxEliminarArt.Click += new System.EventHandler(this.btnEliminarArt_Click);
            // 
            // pbxModificarArt
            // 
            this.pbxModificarArt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbxModificarArt.Image = global::UI.Properties.Resources.edit_50;
            this.pbxModificarArt.ImageLocation = "";
            this.pbxModificarArt.Location = new System.Drawing.Point(3, 406);
            this.pbxModificarArt.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pbxModificarArt.Name = "pbxModificarArt";
            this.pbxModificarArt.Size = new System.Drawing.Size(55, 61);
            this.pbxModificarArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxModificarArt.TabIndex = 10;
            this.pbxModificarArt.TabStop = false;
            this.pbxModificarArt.Click += new System.EventHandler(this.btnModificarArt_Click);
            // 
            // pbxAgregarArt
            // 
            this.pbxAgregarArt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbxAgregarArt.Image = global::UI.Properties.Resources.add_60;
            this.pbxAgregarArt.ImageLocation = "";
            this.pbxAgregarArt.Location = new System.Drawing.Point(3, 339);
            this.pbxAgregarArt.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pbxAgregarArt.Name = "pbxAgregarArt";
            this.pbxAgregarArt.Size = new System.Drawing.Size(55, 61);
            this.pbxAgregarArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAgregarArt.TabIndex = 8;
            this.pbxAgregarArt.TabStop = false;
            this.pbxAgregarArt.Click += new System.EventHandler(this.btnAgregarArt_Click);
            // 
            // pbxListaArt
            // 
            this.pbxListaArt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbxListaArt.Image = ((System.Drawing.Image)(resources.GetObject("pbxListaArt.Image")));
            this.pbxListaArt.ImageLocation = "";
            this.pbxListaArt.Location = new System.Drawing.Point(3, 271);
            this.pbxListaArt.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pbxListaArt.Name = "pbxListaArt";
            this.pbxListaArt.Size = new System.Drawing.Size(55, 61);
            this.pbxListaArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxListaArt.TabIndex = 6;
            this.pbxListaArt.TabStop = false;
            this.pbxListaArt.Click += new System.EventHandler(this.btnListaArt_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(0, 0);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(323, 249);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 2;
            this.pbxLogo.TabStop = false;
            // 
            // btnModificarCategorias
            // 
            this.btnModificarCategorias.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModificarCategorias.FlatAppearance.BorderSize = 0;
            this.btnModificarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCategorias.ForeColor = System.Drawing.Color.Black;
            this.btnModificarCategorias.Location = new System.Drawing.Point(1255, 405);
            this.btnModificarCategorias.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnModificarCategorias.Name = "btnModificarCategorias";
            this.btnModificarCategorias.Size = new System.Drawing.Size(286, 61);
            this.btnModificarCategorias.TabIndex = 10;
            this.btnModificarCategorias.Text = "Modificar Categorias";
            this.btnModificarCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarCategorias.UseVisualStyleBackColor = false;
            this.btnModificarCategorias.Click += new System.EventHandler(this.btnModificarCategorias_Click);
            // 
            // btnModificarMarcas
            // 
            this.btnModificarMarcas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModificarMarcas.FlatAppearance.BorderSize = 0;
            this.btnModificarMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarMarcas.ForeColor = System.Drawing.Color.Black;
            this.btnModificarMarcas.Location = new System.Drawing.Point(1255, 474);
            this.btnModificarMarcas.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnModificarMarcas.Name = "btnModificarMarcas";
            this.btnModificarMarcas.Size = new System.Drawing.Size(286, 61);
            this.btnModificarMarcas.TabIndex = 11;
            this.btnModificarMarcas.Text = "Modificar Marcas";
            this.btnModificarMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarMarcas.UseVisualStyleBackColor = false;
            this.btnModificarMarcas.Click += new System.EventHandler(this.btnModificarMarcas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnIzquierda);
            this.panel1.Controls.Add(this.btnDerecha);
            this.panel1.Location = new System.Drawing.Point(1252, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 547);
            this.panel1.TabIndex = 15;
            // 
            // pbxModMarcas
            // 
            this.pbxModMarcas.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbxModMarcas.Image = global::UI.Properties.Resources.add_60;
            this.pbxModMarcas.ImageLocation = "";
            this.pbxModMarcas.Location = new System.Drawing.Point(1548, 474);
            this.pbxModMarcas.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pbxModMarcas.Name = "pbxModMarcas";
            this.pbxModMarcas.Size = new System.Drawing.Size(55, 61);
            this.pbxModMarcas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxModMarcas.TabIndex = 14;
            this.pbxModMarcas.TabStop = false;
            // 
            // pbxModCategorias
            // 
            this.pbxModCategorias.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pbxModCategorias.Image = global::UI.Properties.Resources.add_60;
            this.pbxModCategorias.ImageLocation = "";
            this.pbxModCategorias.Location = new System.Drawing.Point(1548, 405);
            this.pbxModCategorias.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pbxModCategorias.Name = "pbxModCategorias";
            this.pbxModCategorias.Size = new System.Drawing.Size(55, 61);
            this.pbxModCategorias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxModCategorias.TabIndex = 13;
            this.pbxModCategorias.TabStop = false;
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.BackColor = System.Drawing.Color.MintCream;
            this.pbxArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxArticulo.Location = new System.Drawing.Point(1252, 0);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(350, 350);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 3;
            this.pbxArticulo.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1610, 547);
            this.Controls.Add(this.pbxModMarcas);
            this.Controls.Add(this.pbxModCategorias);
            this.Controls.Add(this.btnModificarMarcas);
            this.Controls.Add(this.btnModificarCategorias);
            this.Controls.Add(this.btnBusquedaAv);
            this.Controls.Add(this.btnDetalles);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.txtBusquedaR);
            this.Controls.Add(this.lblBusquedaR);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Artículos";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEliminarArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModificarArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxListaArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxModMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBusquedaR;
        private System.Windows.Forms.TextBox txtBusquedaR;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Button btnBusquedaAv;
        private System.Windows.Forms.Button btnListaArt;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.PictureBox pbxListaArt;
        private System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.PictureBox pbxAgregarArt;
        private System.Windows.Forms.Button btnModificarArt;
        private System.Windows.Forms.PictureBox pbxModificarArt;
        private System.Windows.Forms.Button btnEliminarArt;
        private System.Windows.Forms.PictureBox pbxEliminarArt;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnModificarCategorias;
        private System.Windows.Forms.Button btnModificarMarcas;
        private System.Windows.Forms.ToolTip toolTipBusqueda;
        private System.Windows.Forms.PictureBox pbxModCategorias;
        private System.Windows.Forms.PictureBox pbxModMarcas;
        private System.Windows.Forms.Panel panel1;
    }
}

