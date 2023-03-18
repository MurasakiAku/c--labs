using System;
using System.Data.Entity;
using System.Linq;

namespace WpfAppNew.Model
{
    
    public class MarketModel : DbContext
    {
        // Контекст настроен для использования строки подключения "MarketModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WpfAppNew.MarketModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "MarketModel" 
        // в файле конфигурации приложения.
        public MarketModel()
            : base("name=MarketModel")
        {     
        }
        
        public virtual DbSet<ClassSeller> Sellers { get; set; }
        public virtual DbSet<ClassProduct> Products { get; set; }
        public virtual DbSet<ClassSale> Sales { get; set; }
        public virtual DbSet<ClassSelleCategory> Categories { get; set; }
        public virtual DbSet<ClassCash> Cashes { get; set; }
        public virtual DbSet<ClassSalesContnt> Contnts { get; set; }

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