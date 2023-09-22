using Entidades;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Persona _persona;
        List<Persona> listaPersonas = new List<Persona>();

        private void CrearButton_Click(object sender, EventArgs e)
        {
            _persona = new Persona();
            _persona.Nombre = NombreTextBox.Text;
            _persona.Estatura = Convert.ToDecimal(EstaturaTextBox.Text);//Podemos convertir el valor a decimal colocando .ToDecimal al final
            _persona.Edad = DevolverEdad(FechaNacimientoDateTimePicker.Value);
            _persona.Genero = GeneroTextBox.Text;
            _persona.FechaNacimiento = FechaNacimientoDateTimePicker.Value;
            EdadTextBox.Text = _persona.Edad.ToString();

            listaPersonas.Add(_persona);
            PersonasBindingSource.DataSource = null;
            PersonasBindingSource.DataSource = listaPersonas;
            Limpiar();
            NombreTextBox.Focus();
            //PersonasDataGridView.DataSource = null;
            //PersonasDataGridView.DataSource = listaPersonas;

        }


        private void MostrarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_persona.devolverDatosDeLaPersona());
        }

        private void Limpiar()
        {
            _persona = null;
            /*
             * Para limpiar una cadena de texto o una variable
             * podemos usar cualquiera de estas tres maneras
             */
            NombreTextBox.Text = string.Empty;
            EstaturaTextBox.Clear();
            EdadTextBox.Text = "";
            GeneroTextBox.Clear();
            FechaNacimientoDateTimePicker.Value = DateTime.Now;
        }

        private void EstaturaLabel_Click(object sender, EventArgs e)
        {

        }

        private int DevolverEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = 0;

            if (fechaNacimiento >= fechaActual)
            {
                return 0;
            }
            else
            {
                edad = fechaActual.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    edad--;
                }
                return edad;
            }

        }
    }
}