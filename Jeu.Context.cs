﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JeuPendu
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class penduEntities : DbContext
    {
        public penduEntities()
            : base("name=penduEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DictionnaireTable> DictionnaireTables { get; set; }
        public virtual DbSet<HistoriqueTable> HistoriqueTables { get; set; }
        public virtual DbSet<Langue> Langues { get; set; }
        public virtual DbSet<Niveau> Niveaux { get; set; }
        public virtual DbSet<Parametre> Parametres { get; set; }
    }
}
