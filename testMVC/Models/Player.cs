namespace testMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Player : DbContext
    {
        // Контекст настроен для использования строки подключения "Player" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "testMVC.Models.Player" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Player" 
        // в файле конфигурации приложения.
        public Player()
            : base("name=Player")
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TopVictory { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}