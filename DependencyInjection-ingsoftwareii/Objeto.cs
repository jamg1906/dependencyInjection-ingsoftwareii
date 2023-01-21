namespace DependencyInjection_ingsoftwareii
{

    public interface ITransient
    {
        public string valorActual();
    }
    public interface IScoped
    {
        public string valorActual();
    }
    public interface ISingleton
    {
        public string valorActual();
    }


    public class Objeto : ITransient, IScoped, ISingleton
    {
        public readonly int valor;
        
        public Objeto()
        {
            valor = new Random().Next(1989);
        }

        public string valorActual()
        {
            return valor.ToString();    
        }

        
    }
}
