namespace Base.Norte360.Logica.IUnitOfWork
{
    /// <summary>
    /// Define los metodos para realizar un inicio, un commit o un rollback de la transaccion
    /// </summary>
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
