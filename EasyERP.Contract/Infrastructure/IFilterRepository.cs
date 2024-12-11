namespace EasyERP.Contract.Infrastructure
{

    public interface IFilterRepository<T>
    {
        IEnumerable<T> GetAll(string datefilter);        

    }


    public interface IFilterAsyncRepository<T>
    {
        IEnumerable<T> GetAllAsync(string datefilter);

    }


}
