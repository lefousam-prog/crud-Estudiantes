using System;
using System.Collections.Generic;
using System.Text;

namespace class2
{
    public class School
    {
        /*Lista que sera del tipo de la clase estudiante
         alojara objetos del tipo de esa clase*/
        private List<Student> students;

        public School()
        {
            students = new List<Student>();
        }

        /*se agregan un nuevo objeto a la lista*/
        public void addStudent(Student newstudent)
        {
            students.Add(newstudent);
        }
        
        /*Imprimimos cada objeto con sus respetivas propiedades
         que hacen referencia  a los atributos*/
        public void showStudens()
        {
            Console.WriteLine("\t\tEstudiantes ingresados");

            foreach (var s in students)
            {
                
                Console.WriteLine($"\n\nId: {s.Id}");
                Console.WriteLine($"Nombre completo: {s.Name} {s.Lastname}");
                Console.WriteLine($"Edad: {s.Age}");
                Console.WriteLine("\n");
            }
        }

        /*metodo que encuentra estudiantes por nombre*/
        public void findStudent(string name)
        {
            int i = 0;
            bool encontrado = false;
            

            /*Comopara el nombre ingresado con la propiedad Name en cada
             posicion de cada objeto de la lista*/
            foreach (var s in students)
            {
                if (s.Name.Equals(name))
                {
                    Console.WriteLine($"\nId: {s.Id}");
                    Console.WriteLine($"Nombre completo: {s.Name} {s.Lastname}");
                    Console.WriteLine($"Edad: {s.Age}");
                    Console.WriteLine("\n");

                    encontrado = true;
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("\nNo se encontro el estudiante");
            }
            
        }


        /*Pide un id este se evalua si coincide con el id de algunos de
         los objetos en la lista students si es asi obtiene todo el objeto
        y lo pasa a la variable elment que es un objeto en si y se remueve
        luego si es correcto el remove envia true hacia la clase program*/
        public bool deleteStudent(int id)
        {
            bool result = false;
            var element = students.Find(i => i.Id == id);
            result= students.Remove(element);

            if (result == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*Pide un objeto con los datos del usuario a actualizar
         luego evalua si el id de ese objeto coincide con alguno de la lista 
        student si es asi obtiene el objeto y se le van pasando los valores
        del objeto que se ha pedido al usuario para actualizar*/
        public void updateStudent(Student upstudent)
        {
            var element = students.Find(i => i.Id == upstudent.Id);
            if (element!=null)
            {
                element.Id = upstudent.Id;
                element.Name = upstudent.Name;
                element.Lastname = upstudent.Lastname;
                element.Age = upstudent.Age;

                Console.WriteLine("\nActualización exitosa");
            }
            else
            {
                Console.WriteLine("\nNo se pudo actualizar el registro");
            }
            
        }

        
    }
}
