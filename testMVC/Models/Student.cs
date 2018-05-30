namespace testMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Student : DbContext
    {
        // Контекст настроен для использования строки подключения "Student" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "testMVC.Models.Student" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Student" 
        // в файле конфигурации приложения.
        public Student()
            : base("name=Student.cs")
        {
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public string Faculty { get; set; }
        


        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Student> Students { get; set; }


    }




    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}