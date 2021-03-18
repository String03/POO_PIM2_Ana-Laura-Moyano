namespace POO_PIM2_Ana_Laura_Moyano
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
            this.GrillaEstudiante = new System.Windows.Forms.DataGridView();
            this.GrillaMateria = new System.Windows.Forms.DataGridView();
            this.GrillaMateriasAprobadas = new System.Windows.Forms.DataGridView();
            this.GrillaMateriasDesaprobadas = new System.Windows.Forms.DataGridView();
            this.btn_agregar_alumno = new System.Windows.Forms.Button();
            this.btn_agregar_materia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdo_materia_basica = new System.Windows.Forms.RadioButton();
            this.rdo_materia_especializada = new System.Windows.Forms.RadioButton();
            this.txt_legajo_alumno = new System.Windows.Forms.TextBox();
            this.txt_nombre_alumno = new System.Windows.Forms.TextBox();
            this.txt_apellido_alumno = new System.Windows.Forms.TextBox();
            this.txt_codigo_materia = new System.Windows.Forms.TextBox();
            this.txt_descripcion_materia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_materia_calificacion = new System.Windows.Forms.TextBox();
            this.btn_calificar_materia = new System.Windows.Forms.Button();
            this.rdo_apellido_orden_ascendente = new System.Windows.Forms.RadioButton();
            this.rdo_apellido_forma_descendente = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_materias_alumno = new System.Windows.Forms.Button();
            this.GrillaMateriasEnCurso = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_modificar_alumno = new System.Windows.Forms.Button();
            this.btn_eliminar_alumno = new System.Windows.Forms.Button();
            this.btn_modificar_materia = new System.Windows.Forms.Button();
            this.btn_eliminar_materia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMateriasAprobadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMateriasDesaprobadas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMateriasEnCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaEstudiante
            // 
            this.GrillaEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaEstudiante.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrillaEstudiante.Location = new System.Drawing.Point(15, 54);
            this.GrillaEstudiante.Name = "GrillaEstudiante";
            this.GrillaEstudiante.ReadOnly = true;
            this.GrillaEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaEstudiante.Size = new System.Drawing.Size(303, 150);
            this.GrillaEstudiante.TabIndex = 0;
            this.GrillaEstudiante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaEstudiante_CellContentClick);
            this.GrillaEstudiante.Click += new System.EventHandler(this.GrillaEstudiante_Click);
            // 
            // GrillaMateria
            // 
            this.GrillaMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaMateria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrillaMateria.Location = new System.Drawing.Point(760, 54);
            this.GrillaMateria.Name = "GrillaMateria";
            this.GrillaMateria.ReadOnly = true;
            this.GrillaMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaMateria.Size = new System.Drawing.Size(303, 150);
            this.GrillaMateria.TabIndex = 1;
            // 
            // GrillaMateriasAprobadas
            // 
            this.GrillaMateriasAprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaMateriasAprobadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrillaMateriasAprobadas.Location = new System.Drawing.Point(392, 416);
            this.GrillaMateriasAprobadas.Name = "GrillaMateriasAprobadas";
            this.GrillaMateriasAprobadas.ReadOnly = true;
            this.GrillaMateriasAprobadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaMateriasAprobadas.Size = new System.Drawing.Size(303, 150);
            this.GrillaMateriasAprobadas.TabIndex = 2;
            // 
            // GrillaMateriasDesaprobadas
            // 
            this.GrillaMateriasDesaprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaMateriasDesaprobadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrillaMateriasDesaprobadas.Location = new System.Drawing.Point(760, 416);
            this.GrillaMateriasDesaprobadas.Name = "GrillaMateriasDesaprobadas";
            this.GrillaMateriasDesaprobadas.ReadOnly = true;
            this.GrillaMateriasDesaprobadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaMateriasDesaprobadas.Size = new System.Drawing.Size(303, 150);
            this.GrillaMateriasDesaprobadas.TabIndex = 3;
            // 
            // btn_agregar_alumno
            // 
            this.btn_agregar_alumno.Location = new System.Drawing.Point(12, 210);
            this.btn_agregar_alumno.Name = "btn_agregar_alumno";
            this.btn_agregar_alumno.Size = new System.Drawing.Size(91, 23);
            this.btn_agregar_alumno.TabIndex = 4;
            this.btn_agregar_alumno.Text = "Agregar Alumno";
            this.btn_agregar_alumno.UseVisualStyleBackColor = true;
            this.btn_agregar_alumno.Click += new System.EventHandler(this.btn_agregar_alumno_Click);
            // 
            // btn_agregar_materia
            // 
            this.btn_agregar_materia.Location = new System.Drawing.Point(612, 181);
            this.btn_agregar_materia.Name = "btn_agregar_materia";
            this.btn_agregar_materia.Size = new System.Drawing.Size(94, 23);
            this.btn_agregar_materia.TabIndex = 5;
            this.btn_agregar_materia.Text = "Agregar Materia";
            this.btn_agregar_materia.UseVisualStyleBackColor = true;
            this.btn_agregar_materia.Click += new System.EventHandler(this.btn_agregar_materia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alumno que se da de alta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(757, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Materias de la Universidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Materias aprobadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(757, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Materias desaprobadas";
            // 
            // rdo_materia_basica
            // 
            this.rdo_materia_basica.AutoSize = true;
            this.rdo_materia_basica.Checked = true;
            this.rdo_materia_basica.Location = new System.Drawing.Point(6, 19);
            this.rdo_materia_basica.Name = "rdo_materia_basica";
            this.rdo_materia_basica.Size = new System.Drawing.Size(95, 17);
            this.rdo_materia_basica.TabIndex = 10;
            this.rdo_materia_basica.TabStop = true;
            this.rdo_materia_basica.Text = "Materia Básica";
            this.rdo_materia_basica.UseVisualStyleBackColor = true;
            // 
            // rdo_materia_especializada
            // 
            this.rdo_materia_especializada.AutoSize = true;
            this.rdo_materia_especializada.Location = new System.Drawing.Point(6, 48);
            this.rdo_materia_especializada.Name = "rdo_materia_especializada";
            this.rdo_materia_especializada.Size = new System.Drawing.Size(128, 17);
            this.rdo_materia_especializada.TabIndex = 11;
            this.rdo_materia_especializada.Text = "Materia Especializada";
            this.rdo_materia_especializada.UseVisualStyleBackColor = true;
            // 
            // txt_legajo_alumno
            // 
            this.txt_legajo_alumno.Location = new System.Drawing.Point(83, 246);
            this.txt_legajo_alumno.Name = "txt_legajo_alumno";
            this.txt_legajo_alumno.Size = new System.Drawing.Size(100, 20);
            this.txt_legajo_alumno.TabIndex = 12;
            // 
            // txt_nombre_alumno
            // 
            this.txt_nombre_alumno.Location = new System.Drawing.Point(83, 284);
            this.txt_nombre_alumno.Name = "txt_nombre_alumno";
            this.txt_nombre_alumno.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_alumno.TabIndex = 13;
            // 
            // txt_apellido_alumno
            // 
            this.txt_apellido_alumno.Location = new System.Drawing.Point(74, 327);
            this.txt_apellido_alumno.Name = "txt_apellido_alumno";
            this.txt_apellido_alumno.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido_alumno.TabIndex = 14;
            // 
            // txt_codigo_materia
            // 
            this.txt_codigo_materia.Location = new System.Drawing.Point(612, 82);
            this.txt_codigo_materia.Name = "txt_codigo_materia";
            this.txt_codigo_materia.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo_materia.TabIndex = 15;
            // 
            // txt_descripcion_materia
            // 
            this.txt_descripcion_materia.Location = new System.Drawing.Point(612, 125);
            this.txt_descripcion_materia.Name = "txt_descripcion_materia";
            this.txt_descripcion_materia.Size = new System.Drawing.Size(100, 20);
            this.txt_descripcion_materia.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Legajo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Código";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Descripción";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_materia_basica);
            this.groupBox1.Controls.Add(this.rdo_materia_especializada);
            this.groupBox1.Location = new System.Drawing.Point(324, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 78);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 602);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Nota";
            // 
            // txt_materia_calificacion
            // 
            this.txt_materia_calificacion.Location = new System.Drawing.Point(74, 595);
            this.txt_materia_calificacion.Name = "txt_materia_calificacion";
            this.txt_materia_calificacion.Size = new System.Drawing.Size(100, 20);
            this.txt_materia_calificacion.TabIndex = 24;
            // 
            // btn_calificar_materia
            // 
            this.btn_calificar_materia.Location = new System.Drawing.Point(201, 593);
            this.btn_calificar_materia.Name = "btn_calificar_materia";
            this.btn_calificar_materia.Size = new System.Drawing.Size(75, 23);
            this.btn_calificar_materia.TabIndex = 25;
            this.btn_calificar_materia.Text = "Calificar";
            this.btn_calificar_materia.UseVisualStyleBackColor = true;
            this.btn_calificar_materia.Click += new System.EventHandler(this.btn_calificar_materia_Click);
            // 
            // rdo_apellido_orden_ascendente
            // 
            this.rdo_apellido_orden_ascendente.AutoSize = true;
            this.rdo_apellido_orden_ascendente.Checked = true;
            this.rdo_apellido_orden_ascendente.Location = new System.Drawing.Point(6, 31);
            this.rdo_apellido_orden_ascendente.Name = "rdo_apellido_orden_ascendente";
            this.rdo_apellido_orden_ascendente.Size = new System.Drawing.Size(113, 17);
            this.rdo_apellido_orden_ascendente.TabIndex = 27;
            this.rdo_apellido_orden_ascendente.TabStop = true;
            this.rdo_apellido_orden_ascendente.Text = "Forma ascendente";
            this.rdo_apellido_orden_ascendente.UseVisualStyleBackColor = true;
            this.rdo_apellido_orden_ascendente.CheckedChanged += new System.EventHandler(this.rdo_apellido_orden_ascendente_CheckedChanged);
            // 
            // rdo_apellido_forma_descendente
            // 
            this.rdo_apellido_forma_descendente.AutoSize = true;
            this.rdo_apellido_forma_descendente.Location = new System.Drawing.Point(6, 65);
            this.rdo_apellido_forma_descendente.Name = "rdo_apellido_forma_descendente";
            this.rdo_apellido_forma_descendente.Size = new System.Drawing.Size(119, 17);
            this.rdo_apellido_forma_descendente.TabIndex = 28;
            this.rdo_apellido_forma_descendente.Text = "Forma descendente";
            this.rdo_apellido_forma_descendente.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_apellido_forma_descendente);
            this.groupBox2.Controls.Add(this.rdo_apellido_orden_ascendente);
            this.groupBox2.Location = new System.Drawing.Point(248, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 100);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orden por apellido";
            // 
            // btn_materias_alumno
            // 
            this.btn_materias_alumno.Location = new System.Drawing.Point(464, 301);
            this.btn_materias_alumno.Name = "btn_materias_alumno";
            this.btn_materias_alumno.Size = new System.Drawing.Size(95, 39);
            this.btn_materias_alumno.TabIndex = 30;
            this.btn_materias_alumno.Text = "Materias que cursa el alumno";
            this.btn_materias_alumno.UseVisualStyleBackColor = true;
            this.btn_materias_alumno.Click += new System.EventHandler(this.btn_materias_alumno_Click);
            // 
            // GrillaMateriasEnCurso
            // 
            this.GrillaMateriasEnCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaMateriasEnCurso.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GrillaMateriasEnCurso.Location = new System.Drawing.Point(15, 416);
            this.GrillaMateriasEnCurso.Name = "GrillaMateriasEnCurso";
            this.GrillaMateriasEnCurso.ReadOnly = true;
            this.GrillaMateriasEnCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaMateriasEnCurso.Size = new System.Drawing.Size(303, 150);
            this.GrillaMateriasEnCurso.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Materias en curso";
            // 
            // btn_modificar_alumno
            // 
            this.btn_modificar_alumno.Location = new System.Drawing.Point(120, 210);
            this.btn_modificar_alumno.Name = "btn_modificar_alumno";
            this.btn_modificar_alumno.Size = new System.Drawing.Size(101, 23);
            this.btn_modificar_alumno.TabIndex = 33;
            this.btn_modificar_alumno.Text = "Modificar Alumno";
            this.btn_modificar_alumno.UseVisualStyleBackColor = true;
            this.btn_modificar_alumno.Click += new System.EventHandler(this.btn_modificar_alumno_Click);
            // 
            // btn_eliminar_alumno
            // 
            this.btn_eliminar_alumno.Location = new System.Drawing.Point(237, 210);
            this.btn_eliminar_alumno.Name = "btn_eliminar_alumno";
            this.btn_eliminar_alumno.Size = new System.Drawing.Size(91, 23);
            this.btn_eliminar_alumno.TabIndex = 34;
            this.btn_eliminar_alumno.Text = "Eliminar Alumno";
            this.btn_eliminar_alumno.UseVisualStyleBackColor = true;
            this.btn_eliminar_alumno.Click += new System.EventHandler(this.btn_eliminar_alumno_Click);
            // 
            // btn_modificar_materia
            // 
            this.btn_modificar_materia.Location = new System.Drawing.Point(760, 222);
            this.btn_modificar_materia.Name = "btn_modificar_materia";
            this.btn_modificar_materia.Size = new System.Drawing.Size(102, 23);
            this.btn_modificar_materia.TabIndex = 35;
            this.btn_modificar_materia.Text = "Modificar Materia";
            this.btn_modificar_materia.UseVisualStyleBackColor = true;
            this.btn_modificar_materia.Click += new System.EventHandler(this.btn_modificar_materia_Click);
            // 
            // btn_eliminar_materia
            // 
            this.btn_eliminar_materia.Location = new System.Drawing.Point(894, 222);
            this.btn_eliminar_materia.Name = "btn_eliminar_materia";
            this.btn_eliminar_materia.Size = new System.Drawing.Size(102, 23);
            this.btn_eliminar_materia.TabIndex = 36;
            this.btn_eliminar_materia.Text = "Eliminar Materia";
            this.btn_eliminar_materia.UseVisualStyleBackColor = true;
            this.btn_eliminar_materia.Click += new System.EventHandler(this.btn_eliminar_materia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 631);
            this.Controls.Add(this.btn_eliminar_materia);
            this.Controls.Add(this.btn_modificar_materia);
            this.Controls.Add(this.btn_eliminar_alumno);
            this.Controls.Add(this.btn_modificar_alumno);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GrillaMateriasEnCurso);
            this.Controls.Add(this.btn_materias_alumno);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_calificar_materia);
            this.Controls.Add(this.txt_materia_calificacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_descripcion_materia);
            this.Controls.Add(this.txt_codigo_materia);
            this.Controls.Add(this.txt_apellido_alumno);
            this.Controls.Add(this.txt_nombre_alumno);
            this.Controls.Add(this.txt_legajo_alumno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_agregar_materia);
            this.Controls.Add(this.btn_agregar_alumno);
            this.Controls.Add(this.GrillaMateriasDesaprobadas);
            this.Controls.Add(this.GrillaMateriasAprobadas);
            this.Controls.Add(this.GrillaMateria);
            this.Controls.Add(this.GrillaEstudiante);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMateriasAprobadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMateriasDesaprobadas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaMateriasEnCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaEstudiante;
        private System.Windows.Forms.DataGridView GrillaMateria;
        private System.Windows.Forms.DataGridView GrillaMateriasAprobadas;
        private System.Windows.Forms.DataGridView GrillaMateriasDesaprobadas;
        private System.Windows.Forms.Button btn_agregar_alumno;
        private System.Windows.Forms.Button btn_agregar_materia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdo_materia_basica;
        private System.Windows.Forms.RadioButton rdo_materia_especializada;
        private System.Windows.Forms.TextBox txt_legajo_alumno;
        private System.Windows.Forms.TextBox txt_nombre_alumno;
        private System.Windows.Forms.TextBox txt_apellido_alumno;
        private System.Windows.Forms.TextBox txt_codigo_materia;
        private System.Windows.Forms.TextBox txt_descripcion_materia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_materia_calificacion;
        private System.Windows.Forms.Button btn_calificar_materia;
        private System.Windows.Forms.RadioButton rdo_apellido_orden_ascendente;
        private System.Windows.Forms.RadioButton rdo_apellido_forma_descendente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_materias_alumno;
        private System.Windows.Forms.DataGridView GrillaMateriasEnCurso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_modificar_alumno;
        private System.Windows.Forms.Button btn_eliminar_alumno;
        private System.Windows.Forms.Button btn_modificar_materia;
        private System.Windows.Forms.Button btn_eliminar_materia;
    }
}

