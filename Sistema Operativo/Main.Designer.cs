namespace Sistema_Operativo
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Title = new System.Windows.Forms.Label();
            this.ButtonCargarTxt = new System.Windows.Forms.Button();
            this.LabelTiempoActual = new System.Windows.Forms.Label();
            this.LabelCantidadTiempoActual = new System.Windows.Forms.Label();
            this.GroupBoxProcesoActual = new System.Windows.Forms.GroupBox();
            this.NumericPagina = new System.Windows.Forms.NumericUpDown();
            this.LabelDesplegarQuantumRestante = new System.Windows.Forms.Label();
            this.LabelDesplegarCpuRestante = new System.Windows.Forms.Label();
            this.LabelDesplegarEnvejecimiento = new System.Windows.Forms.Label();
            this.LabelDesplegarCpuAsignado = new System.Windows.Forms.Label();
            this.LabelDesplegarLlegada = new System.Windows.Forms.Label();
            this.LabelDesplegarNombre = new System.Windows.Forms.Label();
            this.ButtonEjecutar = new System.Windows.Forms.Button();
            this.LabelPagina = new System.Windows.Forms.Label();
            this.LabelQuantumRestante = new System.Windows.Forms.Label();
            this.LabelCpuRestante = new System.Windows.Forms.Label();
            this.LabelEnvejecimiento = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.LabelCpuAsignado = new System.Windows.Forms.Label();
            this.LabelLlegada = new System.Windows.Forms.Label();
            this.LabelVictor = new System.Windows.Forms.Label();
            this.GroupBoxSolicitudDeInterrupcion = new System.Windows.Forms.GroupBox();
            this.ButtonInterrumpir = new System.Windows.Forms.Button();
            this.ComboBoxInterrupciones = new System.Windows.Forms.ComboBox();
            this.GroupBoxTablaDePaginas = new System.Windows.Forms.GroupBox();
            this.DataGridViewTablaPaginas = new System.Windows.Forms.DataGridView();
            this.Pagina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Llegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UltimoAcceso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBoxMemoria = new System.Windows.Forms.GroupBox();
            this.ButtonReseteoNur = new System.Windows.Forms.Button();
            this.RadioButtonNur = new System.Windows.Forms.RadioButton();
            this.RadioButtonLfu = new System.Windows.Forms.RadioButton();
            this.RadioButtonLru = new System.Windows.Forms.RadioButton();
            this.RadioButtonFifoMemoria = new System.Windows.Forms.RadioButton();
            this.GroupBoxCpu = new System.Windows.Forms.GroupBox();
            this.NumericTamañoQuantum = new System.Windows.Forms.NumericUpDown();
            this.LabelTamañoQuantum = new System.Windows.Forms.Label();
            this.RadioButtonHrrn = new System.Windows.Forms.RadioButton();
            this.RadioButtonSjf = new System.Windows.Forms.RadioButton();
            this.RadioButtonSrt = new System.Windows.Forms.RadioButton();
            this.RadioButtonFifoCpu = new System.Windows.Forms.RadioButton();
            this.RadioButtonRoundRobin = new System.Windows.Forms.RadioButton();
            this.GroupBoxNuevoProceso = new System.Windows.Forms.GroupBox();
            this.NumericEjecucionTotal = new System.Windows.Forms.NumericUpDown();
            this.ButtonCrearProceso = new System.Windows.Forms.Button();
            this.NumericPaginas = new System.Windows.Forms.NumericUpDown();
            this.LabelDesplegarNombreProcesoNuevo = new System.Windows.Forms.Label();
            this.LabelEjecucionTotal = new System.Windows.Forms.Label();
            this.LabelPaginas = new System.Windows.Forms.Label();
            this.LabelNombreNuevoProceso = new System.Windows.Forms.Label();
            this.GroupBoxEstadoProcesos = new System.Windows.Forms.GroupBox();
            this.GroupBoxFinished = new System.Windows.Forms.GroupBox();
            this.ComboBoxFinished = new System.Windows.Forms.ComboBox();
            this.GroupBoxBloqued = new System.Windows.Forms.GroupBox();
            this.ComboBoxBloqued = new System.Windows.Forms.ComboBox();
            this.GroupBoxRunning = new System.Windows.Forms.GroupBox();
            this.LabelRunning = new System.Windows.Forms.Label();
            this.GroupBoxReady = new System.Windows.Forms.GroupBox();
            this.ComboBoxReady = new System.Windows.Forms.ComboBox();
            this.LabelAdrian = new System.Windows.Forms.Label();
            this.GroupBoxProcesoActual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPagina)).BeginInit();
            this.GroupBoxSolicitudDeInterrupcion.SuspendLayout();
            this.GroupBoxTablaDePaginas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTablaPaginas)).BeginInit();
            this.GroupBoxMemoria.SuspendLayout();
            this.GroupBoxCpu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTamañoQuantum)).BeginInit();
            this.GroupBoxNuevoProceso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEjecucionTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPaginas)).BeginInit();
            this.GroupBoxEstadoProcesos.SuspendLayout();
            this.GroupBoxFinished.SuspendLayout();
            this.GroupBoxBloqued.SuspendLayout();
            this.GroupBoxRunning.SuspendLayout();
            this.GroupBoxReady.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Title.Location = new System.Drawing.Point(10, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(447, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "Simulador de Sistema Operativo 2.0";
            // 
            // ButtonCargarTxt
            // 
            this.ButtonCargarTxt.BackColor = System.Drawing.SystemColors.WindowText;
            this.ButtonCargarTxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonCargarTxt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonCargarTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCargarTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonCargarTxt.Location = new System.Drawing.Point(950, 25);
            this.ButtonCargarTxt.Name = "ButtonCargarTxt";
            this.ButtonCargarTxt.Size = new System.Drawing.Size(203, 31);
            this.ButtonCargarTxt.TabIndex = 1;
            this.ButtonCargarTxt.Text = "Cargar Archivo .txt";
            this.ButtonCargarTxt.UseVisualStyleBackColor = false;
            this.ButtonCargarTxt.Click += new System.EventHandler(this.ButtonCargarTxt_Click);
            // 
            // LabelTiempoActual
            // 
            this.LabelTiempoActual.AutoSize = true;
            this.LabelTiempoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTiempoActual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelTiempoActual.Location = new System.Drawing.Point(12, 80);
            this.LabelTiempoActual.Name = "LabelTiempoActual";
            this.LabelTiempoActual.Size = new System.Drawing.Size(110, 20);
            this.LabelTiempoActual.TabIndex = 2;
            this.LabelTiempoActual.Text = "Tiempo Actual";
            // 
            // LabelCantidadTiempoActual
            // 
            this.LabelCantidadTiempoActual.AutoSize = true;
            this.LabelCantidadTiempoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCantidadTiempoActual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelCantidadTiempoActual.Location = new System.Drawing.Point(161, 80);
            this.LabelCantidadTiempoActual.Name = "LabelCantidadTiempoActual";
            this.LabelCantidadTiempoActual.Size = new System.Drawing.Size(18, 20);
            this.LabelCantidadTiempoActual.TabIndex = 3;
            this.LabelCantidadTiempoActual.Text = "0";
            // 
            // GroupBoxProcesoActual
            // 
            this.GroupBoxProcesoActual.Controls.Add(this.NumericPagina);
            this.GroupBoxProcesoActual.Controls.Add(this.LabelDesplegarQuantumRestante);
            this.GroupBoxProcesoActual.Controls.Add(this.LabelDesplegarCpuRestante);
            this.GroupBoxProcesoActual.Controls.Add(this.LabelDesplegarEnvejecimiento);
            this.GroupBoxProcesoActual.Controls.Add(this.LabelDesplegarCpuAsignado);
            this.GroupBoxProcesoActual.Controls.Add(this.LabelDesplegarLlegada);
            this.GroupBoxProcesoActual.Controls.Add(this.LabelDesplegarNombre);
            this.GroupBoxProcesoActual.Controls.Add(this.ButtonEjecutar);
            this.GroupBoxProcesoActual.Controls.Add(this.LabelPagina);
            this.GroupBoxProcesoActual.Controls.Add(this.LabelQuantumRestante);
            this.GroupBoxProcesoActual.Controls.Add(this.LabelCpuRestante);
            this.GroupBoxProcesoActual.Controls.Add(this.LabelEnvejecimiento);
            this.GroupBoxProcesoActual.Controls.Add(this.LabelNombre);
            this.GroupBoxProcesoActual.Controls.Add(this.LabelCpuAsignado);
            this.GroupBoxProcesoActual.Controls.Add(this.LabelLlegada);
            this.GroupBoxProcesoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxProcesoActual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBoxProcesoActual.Location = new System.Drawing.Point(16, 121);
            this.GroupBoxProcesoActual.Name = "GroupBoxProcesoActual";
            this.GroupBoxProcesoActual.Size = new System.Drawing.Size(186, 303);
            this.GroupBoxProcesoActual.TabIndex = 4;
            this.GroupBoxProcesoActual.TabStop = false;
            this.GroupBoxProcesoActual.Text = "Proceso Actual";
            // 
            // NumericPagina
            // 
            this.NumericPagina.Location = new System.Drawing.Point(105, 197);
            this.NumericPagina.Name = "NumericPagina";
            this.NumericPagina.Size = new System.Drawing.Size(58, 26);
            this.NumericPagina.TabIndex = 17;
            // 
            // LabelDesplegarQuantumRestante
            // 
            this.LabelDesplegarQuantumRestante.AutoSize = true;
            this.LabelDesplegarQuantumRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDesplegarQuantumRestante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelDesplegarQuantumRestante.Location = new System.Drawing.Point(145, 166);
            this.LabelDesplegarQuantumRestante.Name = "LabelDesplegarQuantumRestante";
            this.LabelDesplegarQuantumRestante.Size = new System.Drawing.Size(18, 20);
            this.LabelDesplegarQuantumRestante.TabIndex = 16;
            this.LabelDesplegarQuantumRestante.Text = "0";
            // 
            // LabelDesplegarCpuRestante
            // 
            this.LabelDesplegarCpuRestante.AutoSize = true;
            this.LabelDesplegarCpuRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDesplegarCpuRestante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelDesplegarCpuRestante.Location = new System.Drawing.Point(145, 138);
            this.LabelDesplegarCpuRestante.Name = "LabelDesplegarCpuRestante";
            this.LabelDesplegarCpuRestante.Size = new System.Drawing.Size(18, 20);
            this.LabelDesplegarCpuRestante.TabIndex = 15;
            this.LabelDesplegarCpuRestante.Text = "0";
            // 
            // LabelDesplegarEnvejecimiento
            // 
            this.LabelDesplegarEnvejecimiento.AutoSize = true;
            this.LabelDesplegarEnvejecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDesplegarEnvejecimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelDesplegarEnvejecimiento.Location = new System.Drawing.Point(145, 112);
            this.LabelDesplegarEnvejecimiento.Name = "LabelDesplegarEnvejecimiento";
            this.LabelDesplegarEnvejecimiento.Size = new System.Drawing.Size(18, 20);
            this.LabelDesplegarEnvejecimiento.TabIndex = 14;
            this.LabelDesplegarEnvejecimiento.Text = "0";
            // 
            // LabelDesplegarCpuAsignado
            // 
            this.LabelDesplegarCpuAsignado.AutoSize = true;
            this.LabelDesplegarCpuAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDesplegarCpuAsignado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelDesplegarCpuAsignado.Location = new System.Drawing.Point(145, 84);
            this.LabelDesplegarCpuAsignado.Name = "LabelDesplegarCpuAsignado";
            this.LabelDesplegarCpuAsignado.Size = new System.Drawing.Size(18, 20);
            this.LabelDesplegarCpuAsignado.TabIndex = 13;
            this.LabelDesplegarCpuAsignado.Text = "0";
            // 
            // LabelDesplegarLlegada
            // 
            this.LabelDesplegarLlegada.AutoSize = true;
            this.LabelDesplegarLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDesplegarLlegada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelDesplegarLlegada.Location = new System.Drawing.Point(145, 60);
            this.LabelDesplegarLlegada.Name = "LabelDesplegarLlegada";
            this.LabelDesplegarLlegada.Size = new System.Drawing.Size(18, 20);
            this.LabelDesplegarLlegada.TabIndex = 12;
            this.LabelDesplegarLlegada.Text = "0";
            // 
            // LabelDesplegarNombre
            // 
            this.LabelDesplegarNombre.AutoSize = true;
            this.LabelDesplegarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDesplegarNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelDesplegarNombre.Location = new System.Drawing.Point(145, 33);
            this.LabelDesplegarNombre.Name = "LabelDesplegarNombre";
            this.LabelDesplegarNombre.Size = new System.Drawing.Size(18, 20);
            this.LabelDesplegarNombre.TabIndex = 11;
            this.LabelDesplegarNombre.Text = "0";
            // 
            // ButtonEjecutar
            // 
            this.ButtonEjecutar.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonEjecutar.Location = new System.Drawing.Point(11, 234);
            this.ButtonEjecutar.Name = "ButtonEjecutar";
            this.ButtonEjecutar.Size = new System.Drawing.Size(161, 31);
            this.ButtonEjecutar.TabIndex = 10;
            this.ButtonEjecutar.Text = "Ejecutar";
            this.ButtonEjecutar.UseVisualStyleBackColor = true;
            this.ButtonEjecutar.Click += new System.EventHandler(this.ButtonEjecutar_Click);
            // 
            // LabelPagina
            // 
            this.LabelPagina.AutoSize = true;
            this.LabelPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPagina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelPagina.Location = new System.Drawing.Point(8, 202);
            this.LabelPagina.Name = "LabelPagina";
            this.LabelPagina.Size = new System.Drawing.Size(52, 17);
            this.LabelPagina.TabIndex = 9;
            this.LabelPagina.Text = "Página";
            // 
            // LabelQuantumRestante
            // 
            this.LabelQuantumRestante.AutoSize = true;
            this.LabelQuantumRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuantumRestante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelQuantumRestante.Location = new System.Drawing.Point(8, 169);
            this.LabelQuantumRestante.Name = "LabelQuantumRestante";
            this.LabelQuantumRestante.Size = new System.Drawing.Size(123, 17);
            this.LabelQuantumRestante.TabIndex = 8;
            this.LabelQuantumRestante.Text = "QuantumRestante";
            // 
            // LabelCpuRestante
            // 
            this.LabelCpuRestante.AutoSize = true;
            this.LabelCpuRestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCpuRestante.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelCpuRestante.Location = new System.Drawing.Point(8, 141);
            this.LabelCpuRestante.Name = "LabelCpuRestante";
            this.LabelCpuRestante.Size = new System.Drawing.Size(97, 17);
            this.LabelCpuRestante.TabIndex = 7;
            this.LabelCpuRestante.Text = "CPU Restante";
            // 
            // LabelEnvejecimiento
            // 
            this.LabelEnvejecimiento.AutoSize = true;
            this.LabelEnvejecimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEnvejecimiento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelEnvejecimiento.Location = new System.Drawing.Point(8, 115);
            this.LabelEnvejecimiento.Name = "LabelEnvejecimiento";
            this.LabelEnvejecimiento.Size = new System.Drawing.Size(103, 17);
            this.LabelEnvejecimiento.TabIndex = 6;
            this.LabelEnvejecimiento.Text = "Envejecimiento";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelNombre.Location = new System.Drawing.Point(8, 33);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(58, 17);
            this.LabelNombre.TabIndex = 5;
            this.LabelNombre.Text = "Nombre";
            // 
            // LabelCpuAsignado
            // 
            this.LabelCpuAsignado.AutoSize = true;
            this.LabelCpuAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCpuAsignado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelCpuAsignado.Location = new System.Drawing.Point(8, 87);
            this.LabelCpuAsignado.Name = "LabelCpuAsignado";
            this.LabelCpuAsignado.Size = new System.Drawing.Size(99, 17);
            this.LabelCpuAsignado.TabIndex = 4;
            this.LabelCpuAsignado.Text = "CPU Asignado";
            // 
            // LabelLlegada
            // 
            this.LabelLlegada.AutoSize = true;
            this.LabelLlegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLlegada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelLlegada.Location = new System.Drawing.Point(8, 60);
            this.LabelLlegada.Name = "LabelLlegada";
            this.LabelLlegada.Size = new System.Drawing.Size(59, 17);
            this.LabelLlegada.TabIndex = 3;
            this.LabelLlegada.Text = "Llegada";
            // 
            // LabelVictor
            // 
            this.LabelVictor.AutoSize = true;
            this.LabelVictor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVictor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelVictor.Location = new System.Drawing.Point(565, 36);
            this.LabelVictor.Name = "LabelVictor";
            this.LabelVictor.Size = new System.Drawing.Size(290, 20);
            this.LabelVictor.TabIndex = 5;
            this.LabelVictor.Text = "Víctor Andrés Martínez Valdés #313612";
            this.LabelVictor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GroupBoxSolicitudDeInterrupcion
            // 
            this.GroupBoxSolicitudDeInterrupcion.Controls.Add(this.ButtonInterrumpir);
            this.GroupBoxSolicitudDeInterrupcion.Controls.Add(this.ComboBoxInterrupciones);
            this.GroupBoxSolicitudDeInterrupcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxSolicitudDeInterrupcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBoxSolicitudDeInterrupcion.Location = new System.Drawing.Point(229, 355);
            this.GroupBoxSolicitudDeInterrupcion.Name = "GroupBoxSolicitudDeInterrupcion";
            this.GroupBoxSolicitudDeInterrupcion.Size = new System.Drawing.Size(701, 94);
            this.GroupBoxSolicitudDeInterrupcion.TabIndex = 6;
            this.GroupBoxSolicitudDeInterrupcion.TabStop = false;
            this.GroupBoxSolicitudDeInterrupcion.Text = "Solicitud de Interrupción";
            // 
            // ButtonInterrumpir
            // 
            this.ButtonInterrumpir.BackColor = System.Drawing.SystemColors.WindowText;
            this.ButtonInterrumpir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonInterrumpir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonInterrumpir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInterrumpir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonInterrumpir.Location = new System.Drawing.Point(509, 39);
            this.ButtonInterrumpir.Name = "ButtonInterrumpir";
            this.ButtonInterrumpir.Size = new System.Drawing.Size(171, 31);
            this.ButtonInterrumpir.TabIndex = 11;
            this.ButtonInterrumpir.Text = "Ejecutar Interrupción";
            this.ButtonInterrumpir.UseVisualStyleBackColor = false;
            this.ButtonInterrumpir.Click += new System.EventHandler(this.ButtonInterrumpir_Click);
            // 
            // ComboBoxInterrupciones
            // 
            this.ComboBoxInterrupciones.FormattingEnabled = true;
            this.ComboBoxInterrupciones.Items.AddRange(new object[] {
            "SVC Terminación Normal",
            "SVC Terminación Anormal",
            "SVC Solicitud de I/O",
            "SVC Solicitud de Recurso",
            "Fallo de Programa",
            "Externa de Quantum Expirado",
            "Dispositivo de I/O"});
            this.ComboBoxInterrupciones.Location = new System.Drawing.Point(25, 41);
            this.ComboBoxInterrupciones.Name = "ComboBoxInterrupciones";
            this.ComboBoxInterrupciones.Size = new System.Drawing.Size(453, 28);
            this.ComboBoxInterrupciones.TabIndex = 0;
            this.ComboBoxInterrupciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxInterrupciones_KeyPress);
            // 
            // GroupBoxTablaDePaginas
            // 
            this.GroupBoxTablaDePaginas.Controls.Add(this.DataGridViewTablaPaginas);
            this.GroupBoxTablaDePaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxTablaDePaginas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBoxTablaDePaginas.Location = new System.Drawing.Point(229, 121);
            this.GroupBoxTablaDePaginas.Name = "GroupBoxTablaDePaginas";
            this.GroupBoxTablaDePaginas.Size = new System.Drawing.Size(701, 224);
            this.GroupBoxTablaDePaginas.TabIndex = 7;
            this.GroupBoxTablaDePaginas.TabStop = false;
            this.GroupBoxTablaDePaginas.Text = "Tabla de Páginas del Proceso Actual";
            // 
            // DataGridViewTablaPaginas
            // 
            this.DataGridViewTablaPaginas.AllowUserToAddRows = false;
            this.DataGridViewTablaPaginas.AllowUserToDeleteRows = false;
            this.DataGridViewTablaPaginas.AllowUserToResizeColumns = false;
            this.DataGridViewTablaPaginas.AllowUserToResizeRows = false;
            this.DataGridViewTablaPaginas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTablaPaginas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pagina,
            this.R,
            this.Llegada,
            this.UltimoAcceso,
            this.Accesos,
            this.NUR});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTablaPaginas.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewTablaPaginas.Location = new System.Drawing.Point(25, 33);
            this.DataGridViewTablaPaginas.Name = "DataGridViewTablaPaginas";
            this.DataGridViewTablaPaginas.ReadOnly = true;
            this.DataGridViewTablaPaginas.Size = new System.Drawing.Size(644, 171);
            this.DataGridViewTablaPaginas.TabIndex = 0;
            // 
            // Pagina
            // 
            this.Pagina.HeaderText = "Página";
            this.Pagina.Name = "Pagina";
            this.Pagina.ReadOnly = true;
            // 
            // R
            // 
            this.R.HeaderText = "R";
            this.R.Name = "R";
            this.R.ReadOnly = true;
            // 
            // Llegada
            // 
            this.Llegada.HeaderText = "Llegada";
            this.Llegada.Name = "Llegada";
            this.Llegada.ReadOnly = true;
            // 
            // UltimoAcceso
            // 
            this.UltimoAcceso.HeaderText = "Ult. Acceso";
            this.UltimoAcceso.Name = "UltimoAcceso";
            this.UltimoAcceso.ReadOnly = true;
            // 
            // Accesos
            // 
            this.Accesos.HeaderText = "Accesos";
            this.Accesos.Name = "Accesos";
            this.Accesos.ReadOnly = true;
            // 
            // NUR
            // 
            this.NUR.HeaderText = "NUR";
            this.NUR.Name = "NUR";
            this.NUR.ReadOnly = true;
            // 
            // GroupBoxMemoria
            // 
            this.GroupBoxMemoria.Controls.Add(this.ButtonReseteoNur);
            this.GroupBoxMemoria.Controls.Add(this.RadioButtonNur);
            this.GroupBoxMemoria.Controls.Add(this.RadioButtonLfu);
            this.GroupBoxMemoria.Controls.Add(this.RadioButtonLru);
            this.GroupBoxMemoria.Controls.Add(this.RadioButtonFifoMemoria);
            this.GroupBoxMemoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxMemoria.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBoxMemoria.Location = new System.Drawing.Point(953, 121);
            this.GroupBoxMemoria.Name = "GroupBoxMemoria";
            this.GroupBoxMemoria.Size = new System.Drawing.Size(200, 219);
            this.GroupBoxMemoria.TabIndex = 8;
            this.GroupBoxMemoria.TabStop = false;
            this.GroupBoxMemoria.Text = "Memoria";
            // 
            // ButtonReseteoNur
            // 
            this.ButtonReseteoNur.BackColor = System.Drawing.SystemColors.WindowText;
            this.ButtonReseteoNur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonReseteoNur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonReseteoNur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReseteoNur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonReseteoNur.Location = new System.Drawing.Point(15, 161);
            this.ButtonReseteoNur.Name = "ButtonReseteoNur";
            this.ButtonReseteoNur.Size = new System.Drawing.Size(171, 31);
            this.ButtonReseteoNur.TabIndex = 10;
            this.ButtonReseteoNur.Text = "Resteo Bits NUR";
            this.ButtonReseteoNur.UseVisualStyleBackColor = false;
            // 
            // RadioButtonNur
            // 
            this.RadioButtonNur.AutoSize = true;
            this.RadioButtonNur.Location = new System.Drawing.Point(15, 120);
            this.RadioButtonNur.Name = "RadioButtonNur";
            this.RadioButtonNur.Size = new System.Drawing.Size(62, 24);
            this.RadioButtonNur.TabIndex = 3;
            this.RadioButtonNur.TabStop = true;
            this.RadioButtonNur.Text = "NUR";
            this.RadioButtonNur.UseVisualStyleBackColor = true;
            // 
            // RadioButtonLfu
            // 
            this.RadioButtonLfu.AutoSize = true;
            this.RadioButtonLfu.Location = new System.Drawing.Point(15, 90);
            this.RadioButtonLfu.Name = "RadioButtonLfu";
            this.RadioButtonLfu.Size = new System.Drawing.Size(58, 24);
            this.RadioButtonLfu.TabIndex = 2;
            this.RadioButtonLfu.TabStop = true;
            this.RadioButtonLfu.Text = "LFU";
            this.RadioButtonLfu.UseVisualStyleBackColor = true;
            // 
            // RadioButtonLru
            // 
            this.RadioButtonLru.AutoSize = true;
            this.RadioButtonLru.Location = new System.Drawing.Point(15, 60);
            this.RadioButtonLru.Name = "RadioButtonLru";
            this.RadioButtonLru.Size = new System.Drawing.Size(60, 24);
            this.RadioButtonLru.TabIndex = 1;
            this.RadioButtonLru.TabStop = true;
            this.RadioButtonLru.Text = "LRU";
            this.RadioButtonLru.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFifoMemoria
            // 
            this.RadioButtonFifoMemoria.AutoSize = true;
            this.RadioButtonFifoMemoria.Location = new System.Drawing.Point(15, 30);
            this.RadioButtonFifoMemoria.Name = "RadioButtonFifoMemoria";
            this.RadioButtonFifoMemoria.Size = new System.Drawing.Size(64, 24);
            this.RadioButtonFifoMemoria.TabIndex = 0;
            this.RadioButtonFifoMemoria.TabStop = true;
            this.RadioButtonFifoMemoria.Text = "FIFO";
            this.RadioButtonFifoMemoria.UseVisualStyleBackColor = true;
            // 
            // GroupBoxCpu
            // 
            this.GroupBoxCpu.Controls.Add(this.NumericTamañoQuantum);
            this.GroupBoxCpu.Controls.Add(this.LabelTamañoQuantum);
            this.GroupBoxCpu.Controls.Add(this.RadioButtonHrrn);
            this.GroupBoxCpu.Controls.Add(this.RadioButtonSjf);
            this.GroupBoxCpu.Controls.Add(this.RadioButtonSrt);
            this.GroupBoxCpu.Controls.Add(this.RadioButtonFifoCpu);
            this.GroupBoxCpu.Controls.Add(this.RadioButtonRoundRobin);
            this.GroupBoxCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxCpu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBoxCpu.Location = new System.Drawing.Point(953, 355);
            this.GroupBoxCpu.Name = "GroupBoxCpu";
            this.GroupBoxCpu.Size = new System.Drawing.Size(200, 271);
            this.GroupBoxCpu.TabIndex = 9;
            this.GroupBoxCpu.TabStop = false;
            this.GroupBoxCpu.Text = "CPU";
            // 
            // NumericTamañoQuantum
            // 
            this.NumericTamañoQuantum.Location = new System.Drawing.Point(140, 213);
            this.NumericTamañoQuantum.Name = "NumericTamañoQuantum";
            this.NumericTamañoQuantum.Size = new System.Drawing.Size(46, 26);
            this.NumericTamañoQuantum.TabIndex = 18;
            this.NumericTamañoQuantum.ValueChanged += new System.EventHandler(this.NumericTamañoQuantum_ValueChanged);
            // 
            // LabelTamañoQuantum
            // 
            this.LabelTamañoQuantum.AutoSize = true;
            this.LabelTamañoQuantum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTamañoQuantum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelTamañoQuantum.Location = new System.Drawing.Point(12, 222);
            this.LabelTamañoQuantum.Name = "LabelTamañoQuantum";
            this.LabelTamañoQuantum.Size = new System.Drawing.Size(122, 17);
            this.LabelTamañoQuantum.TabIndex = 10;
            this.LabelTamañoQuantum.Text = "Tamaño Quantum";
            // 
            // RadioButtonHrrn
            // 
            this.RadioButtonHrrn.AutoSize = true;
            this.RadioButtonHrrn.Location = new System.Drawing.Point(15, 180);
            this.RadioButtonHrrn.Name = "RadioButtonHrrn";
            this.RadioButtonHrrn.Size = new System.Drawing.Size(74, 24);
            this.RadioButtonHrrn.TabIndex = 5;
            this.RadioButtonHrrn.TabStop = true;
            this.RadioButtonHrrn.Text = "HRRN";
            this.RadioButtonHrrn.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSjf
            // 
            this.RadioButtonSjf.AutoSize = true;
            this.RadioButtonSjf.Location = new System.Drawing.Point(15, 146);
            this.RadioButtonSjf.Name = "RadioButtonSjf";
            this.RadioButtonSjf.Size = new System.Drawing.Size(56, 24);
            this.RadioButtonSjf.TabIndex = 4;
            this.RadioButtonSjf.TabStop = true;
            this.RadioButtonSjf.Text = "SJF";
            this.RadioButtonSjf.UseVisualStyleBackColor = true;
            // 
            // RadioButtonSrt
            // 
            this.RadioButtonSrt.AutoSize = true;
            this.RadioButtonSrt.Location = new System.Drawing.Point(15, 113);
            this.RadioButtonSrt.Name = "RadioButtonSrt";
            this.RadioButtonSrt.Size = new System.Drawing.Size(59, 24);
            this.RadioButtonSrt.TabIndex = 3;
            this.RadioButtonSrt.TabStop = true;
            this.RadioButtonSrt.Text = "SRT";
            this.RadioButtonSrt.UseVisualStyleBackColor = true;
            // 
            // RadioButtonFifoCpu
            // 
            this.RadioButtonFifoCpu.AutoSize = true;
            this.RadioButtonFifoCpu.Location = new System.Drawing.Point(15, 76);
            this.RadioButtonFifoCpu.Name = "RadioButtonFifoCpu";
            this.RadioButtonFifoCpu.Size = new System.Drawing.Size(64, 24);
            this.RadioButtonFifoCpu.TabIndex = 2;
            this.RadioButtonFifoCpu.TabStop = true;
            this.RadioButtonFifoCpu.Text = "FIFO";
            this.RadioButtonFifoCpu.UseVisualStyleBackColor = true;
            // 
            // RadioButtonRoundRobin
            // 
            this.RadioButtonRoundRobin.AutoSize = true;
            this.RadioButtonRoundRobin.Location = new System.Drawing.Point(15, 39);
            this.RadioButtonRoundRobin.Name = "RadioButtonRoundRobin";
            this.RadioButtonRoundRobin.Size = new System.Drawing.Size(121, 24);
            this.RadioButtonRoundRobin.TabIndex = 1;
            this.RadioButtonRoundRobin.TabStop = true;
            this.RadioButtonRoundRobin.Text = "Round Robin";
            this.RadioButtonRoundRobin.UseVisualStyleBackColor = true;
            // 
            // GroupBoxNuevoProceso
            // 
            this.GroupBoxNuevoProceso.Controls.Add(this.NumericEjecucionTotal);
            this.GroupBoxNuevoProceso.Controls.Add(this.ButtonCrearProceso);
            this.GroupBoxNuevoProceso.Controls.Add(this.NumericPaginas);
            this.GroupBoxNuevoProceso.Controls.Add(this.LabelDesplegarNombreProcesoNuevo);
            this.GroupBoxNuevoProceso.Controls.Add(this.LabelEjecucionTotal);
            this.GroupBoxNuevoProceso.Controls.Add(this.LabelPaginas);
            this.GroupBoxNuevoProceso.Controls.Add(this.LabelNombreNuevoProceso);
            this.GroupBoxNuevoProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxNuevoProceso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBoxNuevoProceso.Location = new System.Drawing.Point(16, 440);
            this.GroupBoxNuevoProceso.Name = "GroupBoxNuevoProceso";
            this.GroupBoxNuevoProceso.Size = new System.Drawing.Size(186, 186);
            this.GroupBoxNuevoProceso.TabIndex = 9;
            this.GroupBoxNuevoProceso.TabStop = false;
            this.GroupBoxNuevoProceso.Text = "NuevoProceso";
            // 
            // NumericEjecucionTotal
            // 
            this.NumericEjecucionTotal.Location = new System.Drawing.Point(117, 97);
            this.NumericEjecucionTotal.Name = "NumericEjecucionTotal";
            this.NumericEjecucionTotal.Size = new System.Drawing.Size(55, 26);
            this.NumericEjecucionTotal.TabIndex = 21;
            // 
            // ButtonCrearProceso
            // 
            this.ButtonCrearProceso.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonCrearProceso.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonCrearProceso.Location = new System.Drawing.Point(9, 137);
            this.ButtonCrearProceso.Name = "ButtonCrearProceso";
            this.ButtonCrearProceso.Size = new System.Drawing.Size(161, 31);
            this.ButtonCrearProceso.TabIndex = 20;
            this.ButtonCrearProceso.Text = "Crear Proceso";
            this.ButtonCrearProceso.UseVisualStyleBackColor = true;
            this.ButtonCrearProceso.Click += new System.EventHandler(this.ButtonCrearProceso_Click);
            // 
            // NumericPaginas
            // 
            this.NumericPaginas.Location = new System.Drawing.Point(117, 61);
            this.NumericPaginas.Name = "NumericPaginas";
            this.NumericPaginas.Size = new System.Drawing.Size(55, 26);
            this.NumericPaginas.TabIndex = 18;
            // 
            // LabelDesplegarNombreProcesoNuevo
            // 
            this.LabelDesplegarNombreProcesoNuevo.AutoSize = true;
            this.LabelDesplegarNombreProcesoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDesplegarNombreProcesoNuevo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelDesplegarNombreProcesoNuevo.Location = new System.Drawing.Point(145, 32);
            this.LabelDesplegarNombreProcesoNuevo.Name = "LabelDesplegarNombreProcesoNuevo";
            this.LabelDesplegarNombreProcesoNuevo.Size = new System.Drawing.Size(18, 20);
            this.LabelDesplegarNombreProcesoNuevo.TabIndex = 17;
            this.LabelDesplegarNombreProcesoNuevo.Text = "1";
            // 
            // LabelEjecucionTotal
            // 
            this.LabelEjecucionTotal.AutoSize = true;
            this.LabelEjecucionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEjecucionTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelEjecucionTotal.Location = new System.Drawing.Point(6, 102);
            this.LabelEjecucionTotal.Name = "LabelEjecucionTotal";
            this.LabelEjecucionTotal.Size = new System.Drawing.Size(105, 17);
            this.LabelEjecucionTotal.TabIndex = 8;
            this.LabelEjecucionTotal.Text = "Ejecución Total";
            // 
            // LabelPaginas
            // 
            this.LabelPaginas.AutoSize = true;
            this.LabelPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPaginas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelPaginas.Location = new System.Drawing.Point(9, 70);
            this.LabelPaginas.Name = "LabelPaginas";
            this.LabelPaginas.Size = new System.Drawing.Size(59, 17);
            this.LabelPaginas.TabIndex = 7;
            this.LabelPaginas.Text = "Páginas";
            // 
            // LabelNombreNuevoProceso
            // 
            this.LabelNombreNuevoProceso.AutoSize = true;
            this.LabelNombreNuevoProceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNombreNuevoProceso.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelNombreNuevoProceso.Location = new System.Drawing.Point(9, 35);
            this.LabelNombreNuevoProceso.Name = "LabelNombreNuevoProceso";
            this.LabelNombreNuevoProceso.Size = new System.Drawing.Size(58, 17);
            this.LabelNombreNuevoProceso.TabIndex = 6;
            this.LabelNombreNuevoProceso.Text = "Nombre";
            // 
            // GroupBoxEstadoProcesos
            // 
            this.GroupBoxEstadoProcesos.Controls.Add(this.GroupBoxFinished);
            this.GroupBoxEstadoProcesos.Controls.Add(this.GroupBoxBloqued);
            this.GroupBoxEstadoProcesos.Controls.Add(this.GroupBoxRunning);
            this.GroupBoxEstadoProcesos.Controls.Add(this.GroupBoxReady);
            this.GroupBoxEstadoProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxEstadoProcesos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBoxEstadoProcesos.Location = new System.Drawing.Point(229, 455);
            this.GroupBoxEstadoProcesos.Name = "GroupBoxEstadoProcesos";
            this.GroupBoxEstadoProcesos.Size = new System.Drawing.Size(701, 171);
            this.GroupBoxEstadoProcesos.TabIndex = 8;
            this.GroupBoxEstadoProcesos.TabStop = false;
            this.GroupBoxEstadoProcesos.Text = "Estado de los Procesos";
            // 
            // GroupBoxFinished
            // 
            this.GroupBoxFinished.Controls.Add(this.ComboBoxFinished);
            this.GroupBoxFinished.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBoxFinished.Location = new System.Drawing.Point(536, 25);
            this.GroupBoxFinished.Name = "GroupBoxFinished";
            this.GroupBoxFinished.Size = new System.Drawing.Size(108, 128);
            this.GroupBoxFinished.TabIndex = 3;
            this.GroupBoxFinished.TabStop = false;
            this.GroupBoxFinished.Text = "Finished";
            // 
            // ComboBoxFinished
            // 
            this.ComboBoxFinished.FormattingEnabled = true;
            this.ComboBoxFinished.Location = new System.Drawing.Point(16, 56);
            this.ComboBoxFinished.Name = "ComboBoxFinished";
            this.ComboBoxFinished.Size = new System.Drawing.Size(74, 28);
            this.ComboBoxFinished.TabIndex = 3;
            this.ComboBoxFinished.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxInterrupciones_KeyPress);
            // 
            // GroupBoxBloqued
            // 
            this.GroupBoxBloqued.Controls.Add(this.ComboBoxBloqued);
            this.GroupBoxBloqued.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBoxBloqued.Location = new System.Drawing.Point(370, 25);
            this.GroupBoxBloqued.Name = "GroupBoxBloqued";
            this.GroupBoxBloqued.Size = new System.Drawing.Size(108, 128);
            this.GroupBoxBloqued.TabIndex = 2;
            this.GroupBoxBloqued.TabStop = false;
            this.GroupBoxBloqued.Text = "Bloqued";
            // 
            // ComboBoxBloqued
            // 
            this.ComboBoxBloqued.FormattingEnabled = true;
            this.ComboBoxBloqued.Location = new System.Drawing.Point(17, 56);
            this.ComboBoxBloqued.Name = "ComboBoxBloqued";
            this.ComboBoxBloqued.Size = new System.Drawing.Size(74, 28);
            this.ComboBoxBloqued.TabIndex = 2;
            this.ComboBoxBloqued.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxInterrupciones_KeyPress);
            // 
            // GroupBoxRunning
            // 
            this.GroupBoxRunning.Controls.Add(this.LabelRunning);
            this.GroupBoxRunning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBoxRunning.Location = new System.Drawing.Point(204, 25);
            this.GroupBoxRunning.Name = "GroupBoxRunning";
            this.GroupBoxRunning.Size = new System.Drawing.Size(108, 128);
            this.GroupBoxRunning.TabIndex = 1;
            this.GroupBoxRunning.TabStop = false;
            this.GroupBoxRunning.Text = "Running";
            // 
            // LabelRunning
            // 
            this.LabelRunning.AutoSize = true;
            this.LabelRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRunning.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelRunning.Location = new System.Drawing.Point(25, 39);
            this.LabelRunning.Name = "LabelRunning";
            this.LabelRunning.Size = new System.Drawing.Size(57, 63);
            this.LabelRunning.TabIndex = 18;
            this.LabelRunning.Text = "0";
            // 
            // GroupBoxReady
            // 
            this.GroupBoxReady.Controls.Add(this.ComboBoxReady);
            this.GroupBoxReady.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBoxReady.Location = new System.Drawing.Point(43, 25);
            this.GroupBoxReady.Name = "GroupBoxReady";
            this.GroupBoxReady.Size = new System.Drawing.Size(108, 128);
            this.GroupBoxReady.TabIndex = 0;
            this.GroupBoxReady.TabStop = false;
            this.GroupBoxReady.Text = "Ready";
            // 
            // ComboBoxReady
            // 
            this.ComboBoxReady.FormattingEnabled = true;
            this.ComboBoxReady.Location = new System.Drawing.Point(15, 55);
            this.ComboBoxReady.Name = "ComboBoxReady";
            this.ComboBoxReady.Size = new System.Drawing.Size(74, 28);
            this.ComboBoxReady.TabIndex = 1;
            this.ComboBoxReady.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxInterrupciones_KeyPress);
            // 
            // LabelAdrian
            // 
            this.LabelAdrian.AutoSize = true;
            this.LabelAdrian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAdrian.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelAdrian.Location = new System.Drawing.Point(565, 80);
            this.LabelAdrian.Name = "LabelAdrian";
            this.LabelAdrian.Size = new System.Drawing.Size(323, 20);
            this.LabelAdrian.TabIndex = 10;
            this.LabelAdrian.Text = "Adrían Alejandro Valdez Rodríguez #315992";
            this.LabelAdrian.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1175, 659);
            this.Controls.Add(this.LabelAdrian);
            this.Controls.Add(this.GroupBoxEstadoProcesos);
            this.Controls.Add(this.GroupBoxNuevoProceso);
            this.Controls.Add(this.GroupBoxCpu);
            this.Controls.Add(this.GroupBoxMemoria);
            this.Controls.Add(this.GroupBoxTablaDePaginas);
            this.Controls.Add(this.GroupBoxSolicitudDeInterrupcion);
            this.Controls.Add(this.LabelVictor);
            this.Controls.Add(this.GroupBoxProcesoActual);
            this.Controls.Add(this.LabelCantidadTiempoActual);
            this.Controls.Add(this.LabelTiempoActual);
            this.Controls.Add(this.ButtonCargarTxt);
            this.Controls.Add(this.Title);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Operativo";
            this.GroupBoxProcesoActual.ResumeLayout(false);
            this.GroupBoxProcesoActual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPagina)).EndInit();
            this.GroupBoxSolicitudDeInterrupcion.ResumeLayout(false);
            this.GroupBoxTablaDePaginas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTablaPaginas)).EndInit();
            this.GroupBoxMemoria.ResumeLayout(false);
            this.GroupBoxMemoria.PerformLayout();
            this.GroupBoxCpu.ResumeLayout(false);
            this.GroupBoxCpu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTamañoQuantum)).EndInit();
            this.GroupBoxNuevoProceso.ResumeLayout(false);
            this.GroupBoxNuevoProceso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEjecucionTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPaginas)).EndInit();
            this.GroupBoxEstadoProcesos.ResumeLayout(false);
            this.GroupBoxFinished.ResumeLayout(false);
            this.GroupBoxBloqued.ResumeLayout(false);
            this.GroupBoxRunning.ResumeLayout(false);
            this.GroupBoxRunning.PerformLayout();
            this.GroupBoxReady.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button ButtonCargarTxt;
        private System.Windows.Forms.Label LabelTiempoActual;
        private System.Windows.Forms.GroupBox GroupBoxProcesoActual;
        private System.Windows.Forms.Label LabelCantidadTiempoActual;
        private System.Windows.Forms.Label LabelQuantumRestante;
        private System.Windows.Forms.Label LabelCpuRestante;
        private System.Windows.Forms.Label LabelEnvejecimiento;
        private System.Windows.Forms.Label LabelNombre;
        private System.Windows.Forms.Label LabelCpuAsignado;
        private System.Windows.Forms.Label LabelLlegada;
        private System.Windows.Forms.Button ButtonEjecutar;
        private System.Windows.Forms.Label LabelPagina;
        private System.Windows.Forms.Label LabelVictor;
        private System.Windows.Forms.Label LabelDesplegarNombre;
        private System.Windows.Forms.Label LabelDesplegarLlegada;
        private System.Windows.Forms.Label LabelDesplegarCpuAsignado;
        private System.Windows.Forms.Label LabelDesplegarEnvejecimiento;
        private System.Windows.Forms.Label LabelDesplegarCpuRestante;
        private System.Windows.Forms.Label LabelDesplegarQuantumRestante;
        private System.Windows.Forms.NumericUpDown NumericPagina;
        private System.Windows.Forms.GroupBox GroupBoxSolicitudDeInterrupcion;
        private System.Windows.Forms.ComboBox ComboBoxInterrupciones;
        private System.Windows.Forms.GroupBox GroupBoxTablaDePaginas;
        private System.Windows.Forms.GroupBox GroupBoxMemoria;
        private System.Windows.Forms.GroupBox GroupBoxCpu;
        private System.Windows.Forms.GroupBox GroupBoxNuevoProceso;
        private System.Windows.Forms.RadioButton RadioButtonNur;
        private System.Windows.Forms.RadioButton RadioButtonLfu;
        private System.Windows.Forms.RadioButton RadioButtonLru;
        private System.Windows.Forms.RadioButton RadioButtonFifoMemoria;
        private System.Windows.Forms.GroupBox GroupBoxEstadoProcesos;
        private System.Windows.Forms.Button ButtonReseteoNur;
        private System.Windows.Forms.NumericUpDown NumericTamañoQuantum;
        private System.Windows.Forms.RadioButton RadioButtonRoundRobin;
        private System.Windows.Forms.RadioButton RadioButtonFifoCpu;
        private System.Windows.Forms.RadioButton RadioButtonSrt;
        private System.Windows.Forms.RadioButton RadioButtonSjf;
        private System.Windows.Forms.RadioButton RadioButtonHrrn;
        private System.Windows.Forms.Label LabelTamañoQuantum;
        private System.Windows.Forms.Label LabelEjecucionTotal;
        private System.Windows.Forms.Label LabelPaginas;
        private System.Windows.Forms.Label LabelNombreNuevoProceso;
        private System.Windows.Forms.Label LabelAdrian;
        private System.Windows.Forms.NumericUpDown NumericPaginas;
        private System.Windows.Forms.Label LabelDesplegarNombreProcesoNuevo;
        private System.Windows.Forms.Button ButtonCrearProceso;
        private System.Windows.Forms.NumericUpDown NumericEjecucionTotal;
        private System.Windows.Forms.GroupBox GroupBoxFinished;
        private System.Windows.Forms.GroupBox GroupBoxBloqued;
        private System.Windows.Forms.GroupBox GroupBoxRunning;
        private System.Windows.Forms.GroupBox GroupBoxReady;
        private System.Windows.Forms.Button ButtonInterrumpir;
        private System.Windows.Forms.ComboBox ComboBoxFinished;
        private System.Windows.Forms.ComboBox ComboBoxBloqued;
        private System.Windows.Forms.Label LabelRunning;
        private System.Windows.Forms.ComboBox ComboBoxReady;
        private System.Windows.Forms.DataGridView DataGridViewTablaPaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagina;
        private System.Windows.Forms.DataGridViewTextBoxColumn R;
        private System.Windows.Forms.DataGridViewTextBoxColumn Llegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn UltimoAcceso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUR;
    }
}

