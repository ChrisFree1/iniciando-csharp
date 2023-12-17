namespace Curso
{
    
    //Creacion de mi Struct 

    struct DataPersons
    {
        /*
         * Me permite crear nuevos tipos de datos 
         */
        public int? ege;
        public string? name;

        public Colors color;
    }

    enum Colors
    {   
        RED,
        
        BLACK,
    }
    public class Program
    {

        public static void Main(string[] args)
        {
            // Traer mi nuevo tipo de tados
            DataPersons data;

            data.color = Colors.RED;
            
            Console.WriteLine("Ingresa el nombre");
            data.name = Console.ReadLine();
            Console.WriteLine("Ingresa Edad: ");    
            data.ege = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Su nombre es {0}, y su edad es {1}, color es {2}",data.name,data.ege,data.color);
            
        

        }
    }
}