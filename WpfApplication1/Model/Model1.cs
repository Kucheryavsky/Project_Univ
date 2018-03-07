namespace WpfApplication1
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Контекст настроен для использования строки подключения "Model1" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WpfApplication1.Model1" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Model1" 
        // в файле конфигурации приложения.
        public Model1()
            : base("name=Model1")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //TODO:L улицы

    public class Skolnik
    {
        public int Id { get; set; }
        public string Familiya { get; set; }
        public string Imya { get; set; }
        public string Otchestvo { get; set; }

        public int UlitsaId { get; set; }
        public DateTime DenRozhdeniya { get; set; }

        public int ClassId { get; set; }//
        public string GodPostupleniya { get; set; }
    }

    public class SvedeniyaORoditelyah
    {
        public string Id { get; set; }
        public string Familiya { get; set; }
        public string Imya { get; set; }
        public string Otchestvo { get; set; }
        public string Adress { get; set; }     //??????????????????
        public string StepenRodstva { get; set; }  //????????????????????

        public Skolnik Skolnik { get; set; }   //?????????????????????
        public int SkolnikId { get; set; }
    }


    public class Predmet
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class Uspevayemost
    {

        public int God { get; set; }
        public int Chetvertnaya { get; set; }
        public int Itogovaya { get; set; }
        

        public Skolnik Skolnik { get; set; }
        public int SkolnikId { get; set; }
        
        public Predmet Predmet { get; set; }
        public int PredmetId {get; set;}

    }
    public class Exam
    {
        public Predmet Predmet { get; set; }
        public int PredmetId { get; set; }

        public int Chetvertnaya { get; set; }
        public int Itogovaya { get; set; }

        public Skolnik Skolnik { get; set; }
        public int SkolnikId { get; set; }
    }


}