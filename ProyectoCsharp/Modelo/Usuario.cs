namespace Modelo
{
    public abstract class Usuario
    {
        private long id_usuario;
        private string nombre;
        private string apellidos;
        private string correo;
        private string codigo;
        private string contraseņa;
        private string descripcion_permisos;



        //Constructores
        public Usuario()
        {
            id_usuario = 0;
            nombre = apellidos = correo = codigo = contraseņa = descripcion_permisos = null;
        }

        public Usuario(long id_usuario, string nombre, string apellidos, string correo, string codigo,
                       string contraseņa, string descripcion_permisos)
        {
            Id_usuario = id_usuario;
            Nombre = nombre;
            Apellidos = apellidos;
            Correo = correo;
            Codigo = codigo;
            Contraseņa = contraseņa;
            Descripcion_permisos = descripcion_permisos;
        }

        //Destructor
        ~Usuario()
        {
            nombre = apellidos = correo = codigo = contraseņa = descripcion_permisos = null;
        }

        public long Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Contraseņa { get => contraseņa; set => contraseņa = value; }
        public string Descripcion_permisos { get => descripcion_permisos; set => descripcion_permisos = value; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Nombre, Apellidos);
        }
    }
}