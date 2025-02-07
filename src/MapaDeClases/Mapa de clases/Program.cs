//Wilker Jose capellan Coronado 
//2024-0217
using System;

namespace ComunidadEducativa
{
    // Clase base
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public MiembroDeLaComunidad(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }
    }

    // Subclase de MiembroDeLaComunidad
    public class Empleado : MiembroDeLaComunidad
    {
        public string Cargo { get; set; }

        public Empleado(string nombre, int edad, string cargo) : base(nombre, edad)
        {
            Cargo = cargo;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Cargo: {Cargo}");
        }
    }

    // Subclase de Empleado
    public class Docente : Empleado
    {
        public Docente(string nombre, int edad) : base(nombre, edad, "Docente") { }
    }

    public class Administrativo : Empleado
    {
        public Administrativo(string nombre, int edad) : base(nombre, edad, "Administrativo") { }
    }

    // Subclase de Docente
    public class Administrador : Docente
    {
        public Administrador(string nombre, int edad) : base(nombre, edad) { }
    }

    public class Maestro : Docente
    {
        public Maestro(string nombre, int edad) : base(nombre, edad) { }
    }

    // Otras clases
    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }

        public Estudiante(string nombre, int edad, string carrera) : base(nombre, edad)
        {
            Carrera = carrera;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Carrera: {Carrera}");
        }
    }

    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AñoGraduacion { get; set; }

        public ExAlumno(string nombre, int edad, int añoGraduacion) : base(nombre, edad)
        {
            AñoGraduacion = añoGraduacion;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Año de Graduación: {AñoGraduacion}");
        }
    }

    class Program
    {
        static void Main()
        {
            Docente docente = new Docente("Carlos", 40);
            docente.MostrarInfo();

            Estudiante estudiante = new Estudiante("Ana", 20, "Ingeniería");
            estudiante.MostrarInfo();

            ExAlumno exAlumno = new ExAlumno("Luis", 30, 2015);
            exAlumno.MostrarInfo();
        }
    }
}

