namespace EasyERP.Contract.Infrastructure
{
  

    public interface IFilterRepository<T>
    {
        IEnumerable<T> GetAllAsync(string datefilter);

    }


}
