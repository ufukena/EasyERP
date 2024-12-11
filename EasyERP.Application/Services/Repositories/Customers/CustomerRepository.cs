using Dapper;
using EasyERP.Application.Context;
using EasyERP.Application.Infrastructure.Repository;
using EasyERP.Contract.Infrastructure;
using EasyERP.Contract.Services.Customers;
using EasyERP.Domain.Services.Models.Customers;
using System.Data;

namespace EasyERP.Application.Services.Repositories.Customers
{
    internal class CustomerRepository : BaseRepository, ICustomerRepository
    {
        private readonly DbContext dbcontext;

        public CustomerRepository(DbContext _dbcontext)
        {
            dbcontext = _dbcontext;
        }

        public Customer? Get(Guid id)
        {
            sql = "SELECT * FROM EE_VW_Customer WHERE Id = @Id";


            using (IDbConnection connection = dbcontext.CreateConnection())
            {
                var parameters = new { Id = id };
                return connection.QuerySingleOrDefault<Customer>(sql, parameters);
            }
        }

       
        public List<Customer> GetAll()
        {
            sql = "SELECT * FROM EE_VW_Customer";


            using (IDbConnection connection = dbcontext.CreateConnection())
            {
                var result = connection.Query<Customer>(sql);
                return result.ToList();
            }
        }


        public Customer Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            sql = "UPDATE EE_Customer SET DeletedFlg = 1 WHERE Id = @Id";

            using (IDbConnection connection = dbcontext.CreateConnection())
            {
                var parameters = new { entity.Id };
                connection.Execute(sql, parameters);                
            }
        }

       
    }
}
