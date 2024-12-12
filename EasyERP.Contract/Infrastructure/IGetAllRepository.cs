namespace EasyERP.Contract.Infrastructure
{

    public interface IGetAllRepository<T>
    {
        Task<List<T>> GetAllAsync();
    }


}
