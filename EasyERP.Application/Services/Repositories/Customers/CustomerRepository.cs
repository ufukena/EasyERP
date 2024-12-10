using Dapper;
using EasyERP.Application.Context;
using EasyERP.Application.Infrastructure.Repository;
using EasyERP.Contract.Services.Customers;
using EasyERP.Domain.Services.Models.Customers;
using EasyERP.Enum.Database;
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

        public async Task<Customer> Get(Guid id)
        {
            sql = "SELECT * FROM EE_VW_Customer WHERE Id = @Id";


            using (IDbConnection connection = dbcontext.CreateConnection())
            {
                var parameters = new { Id = id };
                return await connection.QuerySingleOrDefaultAsync<Customer>(sql, parameters);
            }
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            sql = "SELECT * FROM EE_VW_Customer";


            using (IDbConnection connection = dbcontext.CreateConnection())
            {                
                return await connection.QueryAsync<Customer>(sql);
            }
        }


        public int Create(Customer entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(Customer entity)
        {
            throw new NotImplementedException();
        }       

        public int Update(Customer entity)
        {
            throw new NotImplementedException();
        }

    }
}
