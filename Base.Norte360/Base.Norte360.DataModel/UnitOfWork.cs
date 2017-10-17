using Base.Norte360.Logica.IUnitOfWork;

namespace Base.Norte360.DataModel
{
    /// <summary>
    /// La clase UnitOfWork contiene métodos para comenzar, comprometer y relanzar una transacción, 
    /// también expone una propiedad Session que devuelve la sesión NHibernate actual
    /// asociada a la unidad de trabajo. Cada instancia de UnitOfWork contiene una sola sesión.
    /// 
    /// El constructor estático se utiliza para implementar el patrón Singleton para la fábrica de sesión NHibernate,
    /// en C # los constructores estáticos se ejecutan solo una vez por dominio de aplicación y 
    /// son seguros para hilos, lo que los hace ideales para implementar singletons ().
    /// Singleton es un patron cuyo proposito es asegurar que solo haya una instancia de clase
    /// 
    /// </summary>

    public class UnitOfWork : IUnitOfWork
    {
       // private static readonly ISessionFactory SessionFactory;
        public void BeginTransaction()
        {
            throw new System.NotImplementedException();
        }

        public void Commit()
        {
            throw new System.NotImplementedException();
        }

        public void Rollback()
        {
            throw new System.NotImplementedException();
        }
    }
}
