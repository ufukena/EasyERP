using Dapper;
using EasyERP.Application.Context;
using EasyERP.Application.Infrastructure.Repository;
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


        public async Task<Customer?> GetAsync(Guid id)
        {
            sql = "SELECT * FROM EE_VW_Customer WHERE Id = @Id";


            using (IDbConnection connection = dbcontext.CreateConnection())
            {
                var parameters = new { Id = id };
                var result = await connection.QuerySingleOrDefaultAsync<Customer>(sql, parameters);
                return result;
            }
        }       

        public async Task<List<Customer>> GetAllAsync()
        {
            sql = "SELECT * FROM EE_VW_Customer";

            using (IDbConnection connection = dbcontext.CreateConnection())
            {
                var result = await connection.QueryAsync<Customer>(sql);
                return result.ToList();
            }
        }

        public async Task<Customer> CreateAsync(Customer entity)
        {
            sql = @"EE_SP_C_Customer";

            //entity.CreatedBy = new Guid("B662D274-B215-4DC4-860F-41ECE595711A");

            using (IDbConnection connection = dbcontext.CreateConnection())
            {
                var parameters = new
                {
                    entity.CustomerName,
                    entity.CustomerAddress,                    
                    entity.CreatedBy
                };

                var result = (await connection.QueryAsync<dynamic>(sql, parameters, commandType: CommandType.StoredProcedure))
                                  .Select(item => new Customer()
                                  {
                                      Id = item.Id,
                                      CustomerName = item.CustomerName,
                                      CustomerAddress = item.CustomerAddress,                                      
                                      CreatedBy = item.CreatedBy,
                                      CreatedDate = item.CreatedDate,
                                      ModifiedBy = item.ModifiedBy,
                                      ModifiedDate = item.ModifiedDate,
                                      DeletedBy = item.DeletedBy,
                                      DeletedDate = item.DeletedDate,
                                      DeletedFlg = item.DeletedFlg

                                  }).First();

                return result;

            }
        }

        public async Task<Customer> UpdateAsync(Customer entity)
        {
            sql = @"EE_SP_U_Customer";

            //entity.CreatedBy = new Guid("B662D274-B215-4DC4-860F-41ECE595711A");

            using (IDbConnection connection = dbcontext.CreateConnection())
            {
                var parameters = new
                {
                    entity.CustomerName,
                    entity.CustomerAddress,
                    entity.ModifiedBy,
                    entity.Id

                };

                var result = (await connection.QueryAsync<dynamic>(sql, parameters, commandType: CommandType.StoredProcedure))
                                  .Select(item => new Customer()
                                  {
                                      Id = item.Id,
                                      CustomerName = item.CustomerName,
                                      CustomerAddress = item.CustomerAddress,
                                      CreatedBy = item.CreatedBy,
                                      CreatedDate = item.CreatedDate,
                                      ModifiedBy = item.ModifiedBy,
                                      ModifiedDate = item.ModifiedDate,
                                      DeletedBy = item.DeletedBy,
                                      DeletedDate = item.DeletedDate,
                                      DeletedFlg = item.DeletedFlg

                                  }).First();

                return result;

            }
        }

        public async Task DeleteAsync(Customer entity)
        {
            sql = "EE_SP_D_Customer";

            using (IDbConnection connection = dbcontext.CreateConnection())
            {
                var parameters = new { entity.DeletedBy, entity.Id };
                await connection.ExecuteAsync(sql, parameters, commandType: CommandType.StoredProcedure);                
            }
        }

       
    }
}
