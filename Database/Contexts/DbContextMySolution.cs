using Database.Configurations.Content.HumanContacts;
using Database.Configurations.Content.HumanEducations;
using Database.Configurations.Content.HumanMotivations;
using Database.Configurations.Content.HumanResources;
using Database.Configurations.Content.LabourPerformance;
using Database.Configurations.Content.LabourSafety;
using Database.Configurations.Content.NewsFeeder;
using Database.Configurations.Content.OrgPositions;
using Database.Configurations.Content.OrgProcesses;
using Database.Configurations.Content.OrgStructures;
using Database.Configurations.Content.Services;
using Database.Configurations.Content.Software;
using Database.Configurations.Logs;
using Database.Configurations.Security.Access;
using Database.Configurations.Security.Authorization;
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


        //#region Content HumanContacts
        //public virtual DbSet<Email> Emails { get; set; }
        //public virtual DbSet<Location> Locations { get; set; }
        //public virtual DbSet<Phone> Phones { get; set; }
        //#endregion

        //#region Content HumanEducations
        //public virtual DbSet<Attestation> Attestations { get; set; }
        //public virtual DbSet<Skill> Skills { get; set; }
        //public virtual DbSet<Training> Trainings { get; set; }
        //#endregion

        //#region Content HumanMotivations
        //public virtual DbSet<Bonus> Bonuses { get; set; }
        //public virtual DbSet<Insurance> Insurances { get; set; }
        //public virtual DbSet<Reward> Rewards { get; set; }
        //#endregion

        //#region Content HumanResources
        //public virtual DbSet<Employee> Employees { get; set; }
        //public virtual DbSet<Vacation> Vacations { get; set; }
        //public virtual DbSet<VacationType> VacationTypes { get; set; }
        //#endregion

        //#region Content LabourPerformance
        //public virtual DbSet<Task> Tasks { get; set; }
        //#endregion

        //#region Content LabourSafety
        //public virtual DbSet<Incident> Incidents { get; set; }
        //public virtual DbSet<IncidentType> IncidentTypes { get; set; }
        //public virtual DbSet<Permit> Permits { get; set; }
        //public virtual DbSet<PermitItem> PermitItems { get; set; }
        //public virtual DbSet<PermitType> PermitTypes { get; set; }
        //#endregion

        //#region Content NewsFeeder
        //public virtual DbSet<Announcement> Announcements { get; set; }
        //#endregion
        
        //#region Content OrgPositions
        //public virtual DbSet<Access> Accesses { get; set; }
        //public virtual DbSet<Assignment> Assignments { get; set; }
        //public virtual DbSet<Backup> Backups { get; set; }
        //public virtual DbSet<Document> Documents { get; set; }
        //public virtual DbSet<Process> Processes { get; set; }
        //#endregion

        //#region Content OrgProcesses
        //public virtual DbSet<ProcessComplexity> ProcessComplexities { get; set; }
        //public virtual DbSet<ProcessCriticality> ProcessCriticalities { get; set; }
        //public virtual DbSet<ProcessFrequency> ProcessFrequencies { get; set; }
        //#endregion

        //#region Content OrgStructure
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        //#endregion

        //#region Content Services
        //public virtual DbSet<Stock> Stocks { get; set; }
        //public virtual DbSet<StockProposal> StockProposals { get; set; }
        //public virtual DbSet<StockRequest> StockRequests { get; set; }
        //#endregion

        //#region Content Software
        //public virtual DbSet<Application> Applications { get; set; }
        //#endregion

        //#region Logs
        //public virtual DbSet<HistoryChange> HistoryChanges { get; set; }
        //public virtual DbSet<HistoryError> HistoryErrors { get; set; }
        //#endregion

        //#region Security Access
        //public virtual DbSet<Request> Requests { get; set; }
        //public virtual DbSet<RequestedRole> RequestedRoles { get; set; }
        //public virtual DbSet<RequestStatus> RequestStatuses { get; set; }
        //public virtual DbSet<RequestType> RequestTypes { get; set; }
        //#endregion

        //#region Security Authorization
        //public virtual DbSet<Permission> Permissions { get; set; }
        //public virtual DbSet<Role> Roles { get; set; }
        //public virtual DbSet<User> Users { get; set; }
        //#endregion

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
            //#region Content HumanContacts
            //modelBuilder.ApplyConfiguration(new ConfigurationEmail());
            //modelBuilder.ApplyConfiguration(new ConfigurationLocation());
            //modelBuilder.ApplyConfiguration(new ConfigurationPhone());
            //#endregion

            //#region Content HumanEducations
            //modelBuilder.ApplyConfiguration(new ConfigurationAttestation());
            //modelBuilder.ApplyConfiguration(new ConfigurationSkill());
            //modelBuilder.ApplyConfiguration(new ConfigurationTraining());
            //#endregion

            //#region Content HumanMotivations
            //modelBuilder.ApplyConfiguration(new ConfigurationBonus());
            //modelBuilder.ApplyConfiguration(new ConfigurationInsurance());
            //modelBuilder.ApplyConfiguration(new ConfigurationReward());
            //#endregion

            //#region Content HumanResources
            //modelBuilder.ApplyConfiguration(new ConfigurationEmployee());
            //modelBuilder.ApplyConfiguration(new ConfigurationVacation());
            //modelBuilder.ApplyConfiguration(new ConfigurationVacationType());
            //#endregion

            //#region Content LabourPerformance
            //modelBuilder.ApplyConfiguration(new ConfigurationTask());
            //#endregion

            //#region Content LabourSafety
            //modelBuilder.ApplyConfiguration(new ConfigurationIncident());
            //modelBuilder.ApplyConfiguration(new ConfigurationIncidentType());
            //modelBuilder.ApplyConfiguration(new ConfigurationPermit());
            //modelBuilder.ApplyConfiguration(new ConfigurationPermitItem());
            //modelBuilder.ApplyConfiguration(new ConfigurationPermitType());
            //#endregion

            //#region Content NewsFeeder
            //modelBuilder.ApplyConfiguration(new ConfigurationAnnouncement());
            //#endregion

            //#region Content OrgPositions
            //modelBuilder.ApplyConfiguration(new ConfigurationAccess());
            //modelBuilder.ApplyConfiguration(new ConfigurationAssignment());
            //modelBuilder.ApplyConfiguration(new ConfigurationBackup());
            //modelBuilder.ApplyConfiguration(new ConfigurationDocument());
            //modelBuilder.ApplyConfiguration(new ConfigurationProcess());
            //#endregion

            //#region Content OrgProcesses
            //modelBuilder.ApplyConfiguration(new ConfigurationProcessComplexity());
            //modelBuilder.ApplyConfiguration(new ConfigurationProcessCriticality());
            //modelBuilder.ApplyConfiguration(new ConfigurationProcessFrequency());
            //#endregion

            //#region Content OrgStructure
            modelBuilder.ApplyConfiguration(new ConfigurationCompany());
            modelBuilder.ApplyConfiguration(new ConfigurationDepartment());
            modelBuilder.ApplyConfiguration(new ConfigurationPosition());
            //#endregion

            //#region Content Services
            //modelBuilder.ApplyConfiguration(new ConfigurationStock());
            //modelBuilder.ApplyConfiguration(new ConfigurationStockProposal());
            //modelBuilder.ApplyConfiguration(new ConfigurationStockRequest());
            //#endregion

            //#region Content Software
            //modelBuilder.ApplyConfiguration(new ConfigurationApplication());
            //#endregion

            //#region Logs
            //modelBuilder.ApplyConfiguration(new ConfigurationHistoryChange());
            //modelBuilder.ApplyConfiguration(new ConfigurationHistoryError());
            //modelBuilder.ApplyConfiguration(new ConfigurationHistoryLogin());
            //#endregion

            //#region Security Access
            //modelBuilder.ApplyConfiguration(new ConfigurationRequest());
            //modelBuilder.ApplyConfiguration(new ConfigurationRequestedRole());
            //modelBuilder.ApplyConfiguration(new ConfigurationRequestStatus());
            //modelBuilder.ApplyConfiguration(new ConfigurationRequestType());
            //#endregion

            //#region Security Authorization
            //modelBuilder.ApplyConfiguration(new ConfigurationRole());
            //modelBuilder.ApplyConfiguration(new ConfigurationUser());
            //#endregion

            //#region Seeds
            //modelBuilder.ApplyConfiguration(new SeedRole());
            //#endregion
        }
    }
}