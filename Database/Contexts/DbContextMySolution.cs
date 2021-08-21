using Database.Configurations.Content.OrgStructures;
using Database.Models.Content.HumanContacts;
using Database.Models.Content.HumanEducations;
using Database.Models.Content.HumanMotivations;
using Database.Models.Content.HumanResources;
using Database.Models.Content.LabourPerformance;
using Database.Models.Content.LabourSafety;
using Database.Models.Content.NewsFeeder;
using Database.Models.Content.OrgPositions;
using Database.Models.Content.OrgProcesses;
using Database.Models.Content.OrgStructures;
using Database.Models.Content.Services;
using Database.Models.Content.Software;
using Database.Models.Logs;
using Database.Models.Security.Access;
using Database.Models.Security.Authorization;
using Database.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Database.Contexts
{
    public class DbContextMySolution : DbContext
    {
        public DbContextMySolution() { }
        public DbContextMySolution(DbContextOptions<DbContextMySolution> options) : base(options) { }


        #region Content HumanContacts
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        #endregion

        #region Content HumanEducations
        public virtual DbSet<Attestation> Attestations { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }

        #endregion

        #region Content HumanMotivations
        public virtual DbSet<Bonus> Bonuses { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<Reward> Rewards { get; set; }

        #endregion

        #region Content HumanResources
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Vacation> Vacations { get; set; }
        public virtual DbSet<VacationType> VacationTypes { get; set; }
        #endregion

        #region Content LabourPerformance
        public virtual DbSet<Task> Tasks { get; set; }
        #endregion

        #region Content LabourSafety
        public virtual DbSet<Incident> Incidents { get; set; }
        public virtual DbSet<IncidentType> IncidentTypes { get; set; }
        public virtual DbSet<Permit> Permits { get; set; }
        public virtual DbSet<PermitItem> PermitItems { get; set; }
        public virtual DbSet<PermitType> PermitTypes { get; set; }
        #endregion

        #region Content NewsFeeder
        public virtual DbSet<Announcement> Announcements { get; set; }
        #endregion
        
        #region Content OrgPositions
        public virtual DbSet<Access> Accesses { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Backup> Backups { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Process> Processes { get; set; }
        #endregion

        #region Content OrgProcesses
        public virtual DbSet<ProcessComplexity> ProcessComplexities { get; set; }
        public virtual DbSet<ProcessCriticality> ProcessCriticalities { get; set; }
        public virtual DbSet<ProcessFrequency> ProcessFrequencies { get; set; }
        #endregion

        #region Content OrgStructure
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        #endregion

        #region Content Services
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<StockProposal> StockProposals { get; set; }
        public virtual DbSet<StockRequest> StockRequests { get; set; }
        #endregion

        #region Content Software
        public virtual DbSet<Application> Applications { get; set; }
        #endregion

        #region Logs
        public virtual DbSet<HistoryChange> HistoryChanges { get; set; }
        public virtual DbSet<HistoryError> HistoryErrors { get; set; }
        #endregion

        #region Security Access
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestedRole> RequestedRoles { get; set; }
        public virtual DbSet<RequestStatus> RequestStatuses { get; set; }
        public virtual DbSet<RequestType> RequestTypes { get; set; }
        #endregion

        #region Security Authorization
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLazyLoadingProxies(false);

            // во время запуска тестов без этой проверки возникает ошибка 'Multiple database providers in service provider'  .
            // InMemory создает свою конфигурацию.
            if (!options.IsConfigured) 
            {
                options.UseSqlServer(ConntectionStrings.GetDevelopmentConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Content HumanContacts

            #endregion

            #region Content HumanEducations

            #endregion

            #region Content HumanMotivations

            #endregion

            #region Content HumanResources

            #endregion

            #region Content LabourPerformance

            #endregion

            #region Content LabourSafety

            #endregion

            #region Content OrgPositions

            #endregion

            #region Content OrgProcesses

            #endregion

            #region Content OrgStructure
            modelBuilder.ApplyConfiguration(new ConfigurationCompany());
            #endregion

            #region Content Software

            #endregion

            #region Logs

            #endregion

            #region Security Access

            #endregion

            #region Security Authorization

            #endregion

            #region Seeds
            modelBuilder.ApplyConfiguration(new SeedRole());
            #endregion
        }
    }
}