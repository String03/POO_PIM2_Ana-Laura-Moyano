using POO_PIM2_Ana_Laura_Moyano.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace POO_PIM2_Ana_Laura_Moyano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //  Listado de alumnos inscritos y materias disponibles.    
        private List<Materia> Materias;
        private List<Alumno> Alumnos;

        //  Alumno seleccionado, materia seleccionada, materia relacionada al alumno seleccionado.
        private Alumno tempAlumno;
        private Materia tempMateria;
        private Materia tempMateriaAlumno;

        //  Evento que se dispara cuando el promedio general es igual o mayor a 9.
        public event EventHandler Promedio9Handler;

        private void Form1_Load(object sender, EventArgs e)
        {
            //  Se selecciona la fila completa cuando se clickea la grilla.
            GrillaEstudiante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GrillaMateria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GrillaMateriasAprobadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GrillaMateriasDesaprobadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GrillaMateriasEnCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //  Se instancian las listas de alumnos y materias.
            Alumnos = new List<Alumno>();
            Materias = new List<Materia>();
            
            // Se agrega el delegado al evento.
            Promedio9Handler += (o, s) => {
                MessageBox.Show(this, "Este alumno tiene un promedio general mayor o igual a 9.");
            };
        }

        //  Handler para el evento del promedio mayor o igual a 9.
        private void OnPromedio9Handler(EventArgs e)
        {
            EventHandler handler = Promedio9Handler;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void btn_agregar_alumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_legajo_alumno.Text) 
                    || string.IsNullOrWhiteSpace(txt_nombre_alumno.Text) 
                    || string.IsNullOrWhiteSpace(txt_apellido_alumno.Text))
                {
                    throw new Exception("Los campos no pueden estar vacios.");
                }

                try
                {
                    var temp = Convert.ToInt32(txt_legajo_alumno.Text);
                    if (temp < 0)
                        throw new Exception();
                }
                catch
                {
                    throw new Exception("El legajo no es valido.");
                }

                Alumno Al;

                Al = new Alumno(int.Parse(txt_legajo_alumno.Text),
                    txt_nombre_alumno.Text, txt_apellido_alumno.Text);
                if (Alumnos.Any(a => a.Legajo == Al.Legajo))
                    throw new Exception("Ya hay un registro con este legajo.");

                Alumnos.Add(Al);
                RefrescarAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos de entrada: " + ex.Message);
            }
        }

        private void btn_agregar_materia_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_codigo_materia.Text) || string.IsNullOrWhiteSpace(txt_descripcion_materia.Text))
                {
                    throw new Exception("Datos no validos. No pueden estar vacios.");
                }

                try
                {
                    var temp = Convert.ToInt32(txt_codigo_materia.Text);
                    if (temp < 0)
                        throw new Exception();
                }
                catch
                {
                    throw new Exception("Codigo de materia no valido.");
                }

                Materia Mat;

                if (rdo_materia_basica.Checked)
                {
                    Mat = new MateriaBasica(txt_codigo_materia.Text, txt_descripcion_materia.Text);
                }

                else
                {
                    Mat = new MateriaEspecializada(txt_codigo_materia.Text, txt_descripcion_materia.Text);
                }

                if (Materias.Any(m => m.Codigo == Mat.Codigo))
                    throw new Exception("Esta materia ya existe.");

                Materias.Add(Mat);
                this.GrillaMateria.DataSource = null;
                this.GrillaMateria.DataSource = Materias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void rdo_apellido_orden_ascendente_CheckedChanged(object sender, EventArgs e)
        {
            RefrescarAlumnos();
        }

        //  Método para actualizar la lista de los alumnos dependiendo del orden seleccionado.
        private void RefrescarAlumnos()
        {
            this.GrillaEstudiante.DataSource = null;
            if (rdo_apellido_orden_ascendente.Checked)
                Alumnos.Sort();
            else
            {
                Alumnos.Sort();
                Alumnos.Reverse();
            }
            this.GrillaEstudiante.DataSource = Alumnos;
        }

        //  Método para refrescar las grillas de las materias relacionadas con el alumno.
        private void RefrescarMaterias()
        {
            this.GrillaMateria.DataSource = null;
            this.GrillaMateria.DataSource = Materias.ToList();
            this.GrillaMateriasAprobadas.DataSource = null;
            this.GrillaMateriasDesaprobadas.DataSource = null;
            this.GrillaMateriasEnCurso.DataSource = null;

            if (tempAlumno != null)
            {
                this.GrillaMateriasAprobadas.DataSource = tempAlumno.Materias.Where(m => m.Nota >= 4).ToList();
                this.GrillaMateriasDesaprobadas.DataSource = tempAlumno.Materias.Where(m => m.Nota < 4 && m.Nota != 0 && tempAlumno.Materias.Where(m1 => m1.Codigo == m.Codigo).All(m1 => m1.Nota < 4)).ToList();
                this.GrillaMateriasEnCurso.DataSource = tempAlumno.Materias.Where(m => m.Nota == 0).ToList();
            }
        }

        private void btn_materias_alumno_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    tempAlumno = (Alumno)GrillaEstudiante.SelectedRows[0].DataBoundItem;
                }
                catch
                {
                    throw new Exception("Debe de seleccionar a un alumno.");
                }

                try
                {
                    tempMateria = (Materia)GrillaMateria.SelectedRows[0].DataBoundItem;
                }
                catch
                {
                    throw new Exception("Debe de seleccionar una materia.");
                }

                Materia mat = (Materia)tempMateria.Clone();

                if (tempAlumno.Materias.Where(m => m.Codigo == mat.Codigo).Any(m => m.Nota == 0))
                    throw new Exception("Esta materia está siendo cursada.");
                else if (tempAlumno.Materias.Where(m => m.Codigo == mat.Codigo).Any(m => m.Nota >= 4))
                    throw new Exception("Esta materia ya fue aprobada.");
                else if (mat.GetType() == typeof(MateriaEspecializada)
                    && tempAlumno.Materias.Where(m => m.Nota == 0).Any(m => m.GetType() == typeof(MateriaEspecializada)))
                    throw new Exception("Este alumno está cursando una materia especializada.");

                tempAlumno.Materias.Add(mat);
                RefrescarMaterias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void btn_calificar_materia_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    tempMateriaAlumno = (Materia)GrillaMateriasEnCurso.SelectedRows[0].DataBoundItem;
                }
                catch
                {
                    throw new Exception("No hay materia seleccionada.");
                }

                try
                {
                    int nota = Convert.ToInt32(txt_materia_calificacion.Text);
                    if (nota < 1 || nota > 10)
                        throw new Exception();
                    tempMateriaAlumno.AprobarMateria(nota);
                }
                catch
                {
                    throw new Exception("Calificacion no valida.");
                }

                if (tempAlumno == null)
                    throw new Exception("Debe seleccionar un alumno.");

                RefrescarMaterias();
                var materiasSeleccionadas = tempAlumno.Materias;
                var promedioGeneral = materiasSeleccionadas.Count == 0 ? 0 : materiasSeleccionadas.Select(m => m.Nota).Average();
                if (promedioGeneral >= 9)
                    Promedio9Handler(null, null);
            }
            catch (Exception ex)
            {
                tempMateriaAlumno = null;
                MessageBox.Show(this, ex.Message);
            }
        }

        //  Método que prepara el mensaje cuando se le hace click al alumno.
        private void MostrarDetalleAlumno()
        {
            try
            {
                var materiasSeleccionadas = tempAlumno.Materias;
                var materiasAprobadas = tempAlumno.Materias.Where(m => m.Nota >= 4).ToList();
                var promedioGeneral = materiasSeleccionadas.Count == 0 ? 0 : materiasSeleccionadas.Select(m => m.Nota).Average();
                if (promedioGeneral >= 9)
                    Promedio9Handler(null, null);
                var promedioAprobadas = materiasAprobadas.Count == 0 ? 0 : materiasAprobadas.Select(m => m.Nota).Average();
                var data = string.Format("Cantidad Materias: {0}\nCantidad Materias Aprobadas: {1}\nPromedio General: {2}\nPromedio Materias Aprobadas: {3}",
                    materiasSeleccionadas.Count,
                    materiasAprobadas.Count,
                    promedioGeneral,
                    promedioAprobadas);
                MessageBox.Show(this, data);
            }
            catch { }
        }

        private void GrillaEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                this.tempAlumno = (Alumno)GrillaEstudiante.SelectedRows[0].DataBoundItem;
                RefrescarMaterias();
                MostrarDetalleAlumno();
            }
            catch { }
        }

        private void GrillaEstudiante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LimpiarMateriasAlumno()
        {
            GrillaMateriasEnCurso.DataSource = null;
            GrillaMateriasAprobadas.DataSource = null;
            GrillaMateriasDesaprobadas.DataSource = null;
        }

        private void btn_eliminar_alumno_Click(object sender, EventArgs e)
        {
            try
            {
                Alumno a = GrillaEstudiante.SelectedRows[0].DataBoundItem as Alumno;
                Alumnos.Remove(a);
                LimpiarMateriasAlumno();
                RefrescarAlumnos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Debe seleccionar a un alumno.");
            }
        }

        private void btn_eliminar_materia_Click(object sender, EventArgs e)
        {
            try
            {
                Materia m = GrillaMateria.SelectedRows[0].DataBoundItem as Materia;
                Materias.Remove(m);
                Alumnos.ForEach(a => {
                    a.Materias.RemoveAll(am => am.Codigo == m.Codigo);
                });
                RefrescarMaterias();
            }
            catch
            {
                MessageBox.Show(this, "Debe de seleccionar una materia.");
            }
        }

        private void btn_modificar_alumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre_alumno.Text) 
                    || string.IsNullOrWhiteSpace(txt_apellido_alumno.Text))
                {
                    throw new Exception("Los campos no pueden estar vacios.");
                }

                Alumno a = GrillaEstudiante.SelectedRows[0].DataBoundItem as Alumno;
                a.Nombre = txt_nombre_alumno.Text;
                a.Apellido = txt_apellido_alumno.Text;
                RefrescarAlumnos();
            }
            catch
            {
                MessageBox.Show(this, "Debe de seleccionar un alumno.");
            }
        }

        private void btn_modificar_materia_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_descripcion_materia.Text))
                {
                    throw new Exception("Datos no validos. La descripcion no puede estar vacia.");
                }
                Materia m = GrillaMateria.SelectedRows[0].DataBoundItem as Materia;
                m.Denominacion = txt_descripcion_materia.Text;
                RefrescarMaterias();
                Alumnos.ForEach(a => {
                    foreach (var am in a.Materias)
                        if (am.Codigo == m.Codigo)
                            am.Denominacion = m.Denominacion;
                });
            }
            catch
            {
                MessageBox.Show(this, "Debe de seleccionar una materia.");
            }
        }
    }
}
