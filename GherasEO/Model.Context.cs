﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GherasEO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Validation;
    using System.Linq;

    public partial class employment_officeEntities : DbContext
    {
        public employment_officeEntities()
            : base("name=employment_officeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Certificate> Certificate { get; set; }
        public virtual DbSet<company> company { get; set; }
        public virtual DbSet<courses> courses { get; set; }
        public virtual DbSet<Hired> Hired { get; set; }
        public virtual DbSet<Job_seeker> Job_seeker { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<References> References { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User_Job> User_Job { get; set; }
        public virtual DbSet<Vacancy> Vacancy { get; set; }
        public virtual DbSet<Work_For> Work_For { get; set; }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
                
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }
    }
}
