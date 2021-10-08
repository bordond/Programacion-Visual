
namespace PrimerParcial
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblAnodeInscripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.intDni = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.datetimeAnodeinscripcion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblCantidadderegistrosingresados = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnodenacimiento = new System.Windows.Forms.Label();
            this.lblMaildecontacto = new System.Windows.Forms.Label();
            this.datetimeAnonacimiento = new System.Windows.Forms.TextBox();
            this.txtMaildecontacto = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anodenacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(149, 68);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 27);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Arial", 12F);
            this.lblApellido.Location = new System.Drawing.Point(148, 110);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(98, 27);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDni.Location = new System.Drawing.Point(149, 192);
            this.lblDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(52, 27);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Arial", 12F);
            this.lblLegajo.Location = new System.Drawing.Point(150, 267);
            this.lblLegajo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(84, 27);
            this.lblLegajo.TabIndex = 3;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCarrera.Location = new System.Drawing.Point(150, 306);
            this.lblCarrera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(92, 27);
            this.lblCarrera.TabIndex = 4;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblAnodeInscripcion
            // 
            this.lblAnodeInscripcion.AutoSize = true;
            this.lblAnodeInscripcion.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAnodeInscripcion.Location = new System.Drawing.Point(148, 351);
            this.lblAnodeInscripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAnodeInscripcion.Name = "lblAnodeInscripcion";
            this.lblAnodeInscripcion.Size = new System.Drawing.Size(210, 27);
            this.lblAnodeInscripcion.TabIndex = 5;
            this.lblAnodeInscripcion.Text = "Año de Inscripcion";
            this.lblAnodeInscripcion.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(441, 68);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(441, 110);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(230, 26);
            this.txtApellido.TabIndex = 7;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // intDni
            // 
            this.intDni.Location = new System.Drawing.Point(441, 192);
            this.intDni.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.intDni.Name = "intDni";
            this.intDni.Size = new System.Drawing.Size(130, 26);
            this.intDni.TabIndex = 8;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(441, 267);
            this.txtLegajo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(130, 26);
            this.txtLegajo.TabIndex = 9;
            this.txtLegajo.TextChanged += new System.EventHandler(this.txtLegajo_TextChanged);
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(441, 308);
            this.txtCarrera.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(230, 26);
            this.txtCarrera.TabIndex = 10;
            // 
            // datetimeAnodeinscripcion
            // 
            this.datetimeAnodeinscripcion.Location = new System.Drawing.Point(441, 353);
            this.datetimeAnodeinscripcion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.datetimeAnodeinscripcion.Name = "datetimeAnodeinscripcion";
            this.datetimeAnodeinscripcion.Size = new System.Drawing.Size(100, 26);
            this.datetimeAnodeinscripcion.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Location = new System.Drawing.Point(568, 422);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(160, 54);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.Red;
            this.btnLimpiar.Location = new System.Drawing.Point(277, 422);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(187, 54);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblCantidadderegistrosingresados
            // 
            this.lblCantidadderegistrosingresados.AutoSize = true;
            this.lblCantidadderegistrosingresados.Location = new System.Drawing.Point(41, 479);
            this.lblCantidadderegistrosingresados.Name = "lblCantidadderegistrosingresados";
            this.lblCantidadderegistrosingresados.Size = new System.Drawing.Size(0, 20);
            this.lblCantidadderegistrosingresados.TabIndex = 14;
            this.lblCantidadderegistrosingresados.Click += new System.EventHandler(this.lblCantidadderegistrosingresados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ingrese los datos del alumno:";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // lblAnodenacimiento
            // 
            this.lblAnodenacimiento.AutoSize = true;
            this.lblAnodenacimiento.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAnodenacimiento.Location = new System.Drawing.Point(150, 152);
            this.lblAnodenacimiento.Name = "lblAnodenacimiento";
            this.lblAnodenacimiento.Size = new System.Drawing.Size(239, 27);
            this.lblAnodenacimiento.TabIndex = 16;
            this.lblAnodenacimiento.Text = "Fecha de Nacimiento";
            this.lblAnodenacimiento.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lblMaildecontacto
            // 
            this.lblMaildecontacto.AutoSize = true;
            this.lblMaildecontacto.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMaildecontacto.Location = new System.Drawing.Point(150, 229);
            this.lblMaildecontacto.Name = "lblMaildecontacto";
            this.lblMaildecontacto.Size = new System.Drawing.Size(187, 27);
            this.lblMaildecontacto.TabIndex = 17;
            this.lblMaildecontacto.Text = "Mail de contacto";
            this.lblMaildecontacto.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // datetimeAnonacimiento
            // 
            this.datetimeAnonacimiento.Location = new System.Drawing.Point(441, 152);
            this.datetimeAnonacimiento.Name = "datetimeAnonacimiento";
            this.datetimeAnonacimiento.Size = new System.Drawing.Size(130, 26);
            this.datetimeAnonacimiento.TabIndex = 18;
            this.datetimeAnonacimiento.TextChanged += new System.EventHandler(this.datetimeAnonacimiento_TextChanged);
            // 
            // txtMaildecontacto
            // 
            this.txtMaildecontacto.Location = new System.Drawing.Point(441, 230);
            this.txtMaildecontacto.Name = "txtMaildecontacto";
            this.txtMaildecontacto.Size = new System.Drawing.Size(230, 26);
            this.txtMaildecontacto.TabIndex = 19;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Anodenacimiento,
            this.DNI,
            this.email,
            this.Legajo,
            this.Carrera,
            this.Inscripcion});
            this.dgvDatos.Location = new System.Drawing.Point(24, 646);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(1104, 150);
            this.dgvDatos.TabIndex = 20;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 8;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 150;
            // 
            // Anodenacimiento
            // 
            this.Anodenacimiento.HeaderText = "Fecha de Nacimiento";
            this.Anodenacimiento.MinimumWidth = 8;
            this.Anodenacimiento.Name = "Anodenacimiento";
            this.Anodenacimiento.Width = 150;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 8;
            this.DNI.Name = "DNI";
            this.DNI.Width = 150;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 8;
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.MinimumWidth = 8;
            this.Legajo.Name = "Legajo";
            this.Legajo.Width = 150;
            // 
            // Carrera
            // 
            this.Carrera.HeaderText = "Carrera";
            this.Carrera.MinimumWidth = 8;
            this.Carrera.Name = "Carrera";
            this.Carrera.Width = 150;
            // 
            // Inscripcion
            // 
            this.Inscripcion.HeaderText = "Inscripcion";
            this.Inscripcion.MinimumWidth = 8;
            this.Inscripcion.Name = "Inscripcion";
            this.Inscripcion.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 878);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtMaildecontacto);
            this.Controls.Add(this.datetimeAnonacimiento);
            this.Controls.Add(this.lblMaildecontacto);
            this.Controls.Add(this.lblAnodenacimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantidadderegistrosingresados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.datetimeAnodeinscripcion);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.intDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblAnodeInscripcion);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Registro de Alumnos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblAnodenacimiento;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblMaildecontacto;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblAnodeInscripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox datetimeAnonacimiento;
        private System.Windows.Forms.TextBox intDni;
        private System.Windows.Forms.TextBox txtMaildecontacto;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.TextBox datetimeAnodeinscripcion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblCantidadderegistrosingresados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anodenacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inscripcion;
    }
}

