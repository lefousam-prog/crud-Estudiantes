using System;

namespace class2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            bool respuesta=false;
            School escuela = new School();
            
            do
            {

                int option;

                Console.WriteLine("\n\tREGISTRO DE ESTUDIANTES ");
                Console.WriteLine("\n1-Agregar estudiante");
                Console.WriteLine("2-Mostrar estudiantes");
                Console.WriteLine("3-Buscar estudiante por nombre");
                Console.WriteLine("4-Editar estudiante");
                Console.WriteLine("5-Eliminar estudiante");
                Console.WriteLine("6-Salir");
                Console.Write("\nEscoja una opción: ");
                option = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (option)
                {
                    case 1:

                        Student estudiante = new Student();
                        Console.Write("\nDigite el id: ");
                        estudiante.Id = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Digite nombre: ");
                        estudiante.Name = Console.ReadLine();
                        Console.Write("Digite apellido: ");
                        estudiante.Lastname = Console.ReadLine();
                        Console.Write("Digite la edad: ");
                        estudiante.Age = Convert.ToInt16(Console.ReadLine());


                        escuela.addStudent(estudiante);
                        Console.Clear();
                        break;

                    case 2:

                        escuela.showStudens();
                        break;

                    case 3:
                        string name;
                        Console.Write("\nIngrese el nombre a buscar: ");
                        name = Console.ReadLine();

                        escuela.findStudent(name);
                        break;

                    case 4:


                        Student upStudent = new Student();
                        Console.Write("\nDigite los datos del estudiante a editar");
                        Console.Write("\n\nDigite el id: ");
                        upStudent.Id = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Digite nombre: ");
                        upStudent.Name = Console.ReadLine();
                        Console.Write("Digite apellido: ");
                        upStudent.Lastname = Console.ReadLine();
                        Console.Write("Digite la edad: ");
                        upStudent.Age = Convert.ToInt16(Console.ReadLine());

                        escuela.updateStudent(upStudent);
                        break;

                    case 5:
                        int ID;
                        bool resultado;
                        Console.Write("\nIngrese el id del estudiante a eliminar: ");
                        ID = Convert.ToInt32(Console.ReadLine());
                        resultado = escuela.deleteStudent(ID);

                        if (resultado == true)
                        {
                            Console.WriteLine("\nSe elimino correctamente");
                        }
                        else
                        {
                            Console.WriteLine("\nNo se pudo eliminar el registro");
                        }
                        break;
                    case 6:
                        respuesta = true;
                        break;

                }

            } while (respuesta == false);


        }
    }
}
