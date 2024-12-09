using EasyERP.Application.Context;
using EasyERP.Application.Services.Contracts.Customers;
using EasyERP.Application.Services.Repositories.Customers;

namespace EasyERP.Application.Adapters
{
    public class ServiceBase
    {

        #region BusinessFollowUp

        //public IAgendaRepository Agenda;
        //public INotesRepository Notes;
        //public ITasksRepository Tasks;

        #endregion

        #region Checking Account

        //public ICheckingAccountRepository CheckingAccount;
        //public ICheckingAccountNotesRepository CheckingAccountNotes;

        #endregion

        #region Definitions

        //public ICheckingAccountTypeRepository CheckingAccountType;
        //public ICompanyTypeRepository CompanyType;
        //public ICompanySectorTypeRepository CompanySectorType;
        //public INotesTypeRepository NotesType;
        //public INotesImportanceRepository NotesImportance;
        //public ITasksStatuRepository TasksStatu;
        //public ITasksTypeRepository TasksType;
        //public IAgendaLabelRepository AgendaLabel;
        //public IAgendaStatusRepository AgendaStatus;

        #endregion

        #region Settings

        //public IAppSettingsDataRepository AppSettingsData;

        #endregion

        //private readonly DbContext dbContext; 
        public ICustomerRepository CustomerRepository;


        public ServiceBase()
        {
            DbContext dbContext = new DbContext(); 

            CustomerRepository = new CustomerRepository(dbContext);


            //Agenda = new AgendaRepository(databaseContext);
            //Notes = new NotesRepository(databaseContext);
            //Tasks = new TasksRepository(databaseContext);

            //CheckingAccount = new CheckingAccountRepository(databaseContext);
            //CheckingAccountNotes = new CheckingAccountNotesRepository(databaseContext);

            //CheckingAccountType = new CheckingAccountTypeRepository(databaseContext);
            //CompanyType = new CompanyTypeRepository(databaseContext);
            //CompanySectorType = new CompanySectorTypeRepository(databaseContext);
            //NotesType = new NotesTypeRepository(databaseContext);
            //NotesImportance = new NotesImportanceRepository(databaseContext);
            //TasksStatu = new TasksStatuRepository(databaseContext);
            //TasksType = new TasksTypeRepository(databaseContext);
            //AgendaLabel = new AgendaLabelRepository(databaseContext);
            //AgendaStatus = new AgendaStatusRepository(databaseContext);

            //AppSettingsData = new AppSettingsDataRepository(databaseContext);

        }


    }

}
