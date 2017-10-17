using System.Linq;

namespace Base.Norte360.Logica.IGenericRepository
{
    /// <summary>
    /// Interfaz que expone Metodos CRUD sobre los metodos del sistema
    /// </summary>
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
