using Sukulu.DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sukulu.DataAccessLibrary.Repositories
{
    public class SystemeScolaireFactory
    {
        private readonly SKLContext _context = new SKLContext();

        /// <summary>
        /// Retourne une instance d'un système scolaire a partir de son ID
        /// </summary>
        /// <param name="Id">Identité du système scolaire</param>
        /// <returns></returns>
        public SystemeScolaire getSystemeScolaireById(long Id)
        {
            return _context.SystemeScolaires.Where(ss => ss.Id == Id).FirstOrDefault();
        }

        /// <summary>
        /// Crée un nouveau système scolaire et retourne son identité 
        /// </summary>
        /// <param name="name">Nom</param>
        /// <param name="primaryOwner">Propriétaire principal</param>
        /// <param name="secondaryOwner">Propriétaire secondaire</param>
        /// <param name="description">Description</param>
        /// <param name="country">Pays</param>
        /// <param name="notes">Commentaires</param>
        /// <param name="createdBy">L'auteur de la création</param>
        /// <param name="dateCreated">Date de création</param>
        /// <returns></returns>
        public long createSystemeScolaire(string name, string primaryOwner, string secondaryOwner, string description, 
            string country, string notes, string createdBy, DateTime dateCreated)
        {
            SystemeScolaire sysSco = new SystemeScolaire();
            sysSco.Name = name;
            sysSco.PrimaryOwner = primaryOwner;
            sysSco.SecondaryOwner = secondaryOwner;
            sysSco.Description = description;
            sysSco.Country = country;
            sysSco.Notes = notes;
            sysSco.CreatedBy = createdBy;
            sysSco.DateCreated = dateCreated;
            _context.SystemeScolaires.Add(sysSco);
            _context.SaveChanges();

            return sysSco.Id;
        }

        /// <summary>
        /// Met à jour un système scolaire
        /// </summary>
        /// <param name="systemeScolaireId"></param>
        /// <param name="name">Nom</param>
        /// <param name="primaryOwner">Propriétaire principal</param>
        /// <param name="secondaryOwner">Propriétaire secondaire</param>
        /// <param name="description">Description</param>
        /// <param name="country">Pays</param>
        /// <param name="notes">Commentaires</param>
        /// <param name="modifiedBy">Auteur de la mise à jour</param>
        /// <param name="dateModified">Date de la mise à jour</param>
        public void updateSystemeScolaire(long systemeScolaireId, string name, string primaryOwner, string secondaryOwner, string description,
            string country, string notes, string modifiedBy, DateTime dateModified)
        {
            SystemeScolaire SysScoToBeUpdated = getSystemeScolaireById(systemeScolaireId);
            SysScoToBeUpdated.Name = name;
            SysScoToBeUpdated.PrimaryOwner = primaryOwner;
            SysScoToBeUpdated.SecondaryOwner = secondaryOwner;
            SysScoToBeUpdated.Description = description;
            SysScoToBeUpdated.Country = country;
            SysScoToBeUpdated.Notes = notes;
            SysScoToBeUpdated.ModifiedBy = modifiedBy;
            SysScoToBeUpdated.DateModified = dateModified;

            _context.SaveChanges();
        }

        /// <summary>
        /// Retourne une instance d'un enseignement a partir de son ID
        /// </summary>
        /// <param name="Id">Identité de l'enseignement</param>
        /// <returns>Un enseignement</returns>
        public Enseignement getEnseignementById(long Id)
        {
            return _context.Enseignements.Where(ens => ens.Id == Id).FirstOrDefault();
        }

        /// <summary>
        /// Retourne une instance d'un enseignement a partir de son Code
        /// </summary>
        /// <param name="Code">Identité de l'enseignement</param>
        /// <returns></returns>
        public Enseignement getEnseignementByCode(string Code)
        {
            return _context.Enseignements.Where(ens => ens.Code.ToLower().Trim() == Code.ToLower().Trim()).FirstOrDefault();
        }

        /// <summary>
        /// Crée un enseignement
        /// </summary>
        /// <param name="code">Code</param>
        /// <param name="name">Nom</param>
        /// <param name="description">Description</param>
        /// <param name="systemeScolaireId">Identité du système scolaire</param>
        /// <param name="createdBy">Auteur de la création</param>
        /// <param name="dateCreated">Date de création</param>
        /// <returns>Identité de l'enseignement</returns>
        public long createEnseignement(string code, string name, string description, long systemeScolaireId, string createdBy, DateTime dateCreated)
        {
            Enseignement ens = new Enseignement();
            ens.SystemeScolaireId = systemeScolaireId;
            ens.Code = code;
            ens.Name = name;
            ens.Description = description;
            ens.CreatedBy = createdBy;
            ens.DateCreated = dateCreated;
            _context.Enseignements.Add(ens);
            _context.SaveChanges();

            return ens.Id;
        }

        /// <summary>
        /// Mets à jour un enseignement
        /// </summary>
        /// <param name="enseignementId">Identitéde l'enseignement</param>
        /// <param name="code">Code</param>
        /// <param name="name">Nom</param>
        /// <param name="description">Description</param>
        /// <param name="modifiedBy">Auteur de la mise à jour</param>
        /// <param name="dateModified">Date de la mise à jour</param>
        public void updateEnseignement(long enseignementId, string code, string name, string description, string modifiedBy, DateTime dateModified)
        {
            Enseignement ensToBeUpdated = getEnseignementById(enseignementId);
            ensToBeUpdated.Code = code;
            ensToBeUpdated.Name = name;
            ensToBeUpdated.Description = description;
            ensToBeUpdated.ModifiedBy = modifiedBy;
            ensToBeUpdated.DateModified = dateModified;

            _context.SaveChanges();
        }

        /// <summary>
        /// Retourne une instance d'un Niveau a partir de son ID
        /// </summary>
        /// <param name="Id">Identité du niveau</param>
        /// <returns></returns>
        public Niveau getNiveauById(long Id)
        {
            return _context.Niveaus.Where(niv => niv.Id == Id).FirstOrDefault();
        }

        /// <summary>
        /// Retourne une instance d'un niveau a partir de son Code
        /// </summary>
        /// <param name="Code">Code du niveau</param>
        /// <returns></returns>
        public Niveau getNiveauByCode(string Code)
        {
            return _context.Niveaus.Where(niv => niv.Code.ToLower().Trim() == Code.ToLower().Trim()).FirstOrDefault();
        }

        /// <summary>
        /// Crée un niveau
        /// </summary>
        /// <param name="enseignementId">Identité de l'enseignement</param>
        /// <param name="code">Code</param>
        /// <param name="name">Nom</param>
        /// <param name="ranking">Rang du niveau</param>
        /// <param name="description">Description</param>
        /// <param name="createdBy">Auteur de la création</param>
        /// <param name="dateCreated">Date de la création</param>
        /// <returns>Identité du niveau</returns>
        public long createNiveau(long enseignementId, string code, string name, int ranking, string description, string createdBy, DateTime dateCreated)
        {
            Niveau niv = new Niveau();
            niv.Code = code;
            niv.Name = name;
            niv.Ranking = ranking;
            niv.Description = description;
            niv.EnseignementId = enseignementId;
            niv.CreatedBy = createdBy;
            niv.DateCreated = dateCreated;

            _context.Niveaus.Add(niv);
            _context.SaveChanges();

            return niv.Id;
        }

        /// <summary>
        /// Mets à jour un niveau
        /// </summary>
        /// <param name="niveauId">Identitédu niveau</param>
        /// <param name="code">Code</param>
        /// <param name="name">Nom</param>
        /// <param name="ranking">Rang du niveau</param>
        /// <param name="description">Description</param>
        /// <param name="modifiedBy">Auteur de la mise à jour</param>
        /// <param name="dateModified">Date de la mise à jour</param>
        public void updateNiveau(long niveauId, string code, string name, int ranking, string description, string modifiedBy, DateTime dateModified)
        {
            Niveau NivToUpdate = getNiveauById(niveauId);
            NivToUpdate.Code = code;
            NivToUpdate.Name = name;
            NivToUpdate.Ranking = ranking;
            NivToUpdate.Description = description;
            NivToUpdate.ModifiedBy = modifiedBy;
            NivToUpdate.DateModified = dateModified;

            _context.SaveChanges();
        }

        /// <summary>
        /// Retourne une instance d'une série a partir de son ID
        /// </summary>
        /// <param name="Id">Identité de la série</param>
        /// <returns></returns>
        public Serie getSerieById(long Id)
        {
            return _context.Series.Where(ser => ser.Id == Id).FirstOrDefault();
        }

        /// <summary>
        /// Retourne une instance d'une série à partir de son code
        /// </summary>
        /// <param name="Code">code de la série</param>
        /// <returns></returns>
        public Serie getSerieByCode(string Code)
        {
            return _context.Series.Where(ser => ser.Code.ToLower().Trim() == Code.ToLower().Trim()).FirstOrDefault();
        }

        /// <summary>
        /// Crée une série
        /// </summary>
        /// <param name="enseignementId">Identitéde l'enseignement</param>
        /// <param name="code">Code</param>
        /// <param name="name">Nom</param>
        /// <param name="description">Description</param>
        /// <param name="createdBy">Auteur de la création</param>
        /// <param name="dateCreated">Date de la création</param>
        /// <returns>Identité de la série</returns>
        public long createSerie(long enseignementId, string code, string name, string description, string createdBy, DateTime dateCreated)
        {
            Serie ser = new Serie();
            ser.EnseignementId = enseignementId;
            ser.Code = code;
            ser.Name = name;
            ser.Description = description;
            ser.CreatedBy = createdBy;
            ser.DateCreated = dateCreated;

            _context.Series.Add(ser);
            _context.SaveChanges();

            return ser.Id;
        }

        /// <summary>
        /// Mets à jour une série
        /// </summary>
        /// <param name="serieId">Identité de la série</param>
        /// <param name="code">Code</param>
        /// <param name="name">Nom</param>
        /// <param name="description">Description</param>
        /// <param name="modifiedBy">Auteur de la mise à jour</param>
        /// <param name="dateModified">Date de la mise à jour</param>
        public void updateSerie(long serieId, string code, string name, string description, string modifiedBy, DateTime dateModified)
        {
            Serie serieToUpdate = getSerieById(serieId);
            serieToUpdate.Code = code;
            serieToUpdate.Name = name;
            serieToUpdate.Description = description;
            serieToUpdate.ModifiedBy = modifiedBy;
            serieToUpdate.DateModified = dateModified;

            _context.SaveChanges();
        }

        /// <summary>
        /// Retourne une instance d'une classe à partir de son ID
        /// </summary>
        /// <param name="Id">Identité de la classe</param>
        /// <returns></returns>
        public Classe getClasseById(long Id)
        {
            return _context.Classes.Where(cl => cl.Id == Id).FirstOrDefault();
        }

        /// <summary>
        /// Retourne une instance d'une classe à partir de son code
        /// </summary>
        /// <param name="Code">code de la classe</param>
        /// <returns></returns>
        public Classe getClasseByCode(string Code)
        {
            return _context.Classes.Where(cl => cl.Code.ToLower().Trim() == Code.ToLower().Trim()).FirstOrDefault();
        }

        /// <summary>
        /// Crée une classe
        /// </summary>
        /// <param name="niveauId">Identité du niveau</param>
        /// <param name="serieId">Identité de la série</param>
        /// <param name="code">Code</param>
        /// <param name="name">Nom</param>
        /// <param name="description">Description</param>
        /// <param name="createdBy">Auteur de la création</param>
        /// <param name="dateCreated">Date de la création</param>
        /// <returns>Identité de la classe</returns>
        public long createClasse(long niveauId, long? serieId, string code, string name, string description, string createdBy, DateTime dateCreated)
        {
            Classe cla = new Classe();
            cla.NiveauId = niveauId;
            if (serieId != 0) cla.SerieId = serieId;
            cla.Code = code;
            cla.Name = name;
            cla.Description = description;
            cla.CreatedBy = createdBy;
            cla.DateCreated = dateCreated;

            _context.Classes.Add(cla);
            _context.SaveChanges();

            return cla.Id;

        }

        /// <summary>
        /// Mets à jour une classe
        /// </summary>
        /// <param name="classeId">Identité de la classe</param>
        /// <param name="code">Code</param>
        /// <param name="name">Nom</param>
        /// <param name="description">Description</param>
        /// <param name="modifiedBy">Auteur de la mise à jour</param>
        /// <param name="dateModified">Date de la mise à jour</param>
        public void updateClasse(long classeId, string code, string name, string description, string modifiedBy, DateTime dateModified)
        {
            Classe ClasseToUpdate = getClasseById(classeId);
            ClasseToUpdate.Code = code;
            ClasseToUpdate.Name = name;
            ClasseToUpdate.Description = description;
            ClasseToUpdate.ModifiedBy = modifiedBy;
            ClasseToUpdate.DateModified = dateModified;

            _context.SaveChanges();

        }

        /// <summary>
        /// Retourne la liste de tous les systemes scolaires
        /// </summary>
        /// <returns>Liste des systemes scolaires</returns>
        public List<SystemeScolaire> getAllSystemeScolaires()
        {
            return _context.SystemeScolaires.ToList();
        }

        /// <summary>
        /// Retourne la liste de tous les enseignements
        /// </summary>
        /// <returns>Liste des enseignements</returns>
        public List<Enseignement> getAllEnseignements()
        {
            return _context.Enseignements.ToList();
        }

        /// <summary>
        /// Retourne tous les niveaux
        /// </summary>
        /// <returns></returns>
        public List<Niveau> getAllNiveaux()
        {
            return _context.Niveaus.ToList();
        }

        /// <summary>
        /// Retourne toutes les séries
        /// </summary>
        /// <returns></returns>
        public List<Serie> getAllSeries()
        {
            return _context.Series.ToList();
        }

        /// <summary>
        /// Retourne toutes les classes
        /// </summary>
        /// <returns></returns>
        public List<Classe> getAllClasses()
        {
            return _context.Classes.ToList();
        }

        /// <summary>
        /// Retourne la liste des enseignements d'un système scolaire
        /// </summary>
        /// <param name="SystemeScolaireId">Identitédu système scolaire</param>
        /// <returns></returns>
        public List<Enseignement> getListEnseignementsFromSystemeScolaire(long SystemeScolaireId)
        {
            return _context.Enseignements.Where(ens => ens.SystemeScolaireId == SystemeScolaireId).ToList();
        }

        /// <summary>
        /// Retourne la liste des niveaux d'un enseignement
        /// </summary>
        /// <param name="EnseignementId">L'identité de l'enseignement</param>
        /// <returns></returns>
        public List<Niveau> getListNiveauxFromEnseignement(long EnseignementId)
        {
            return _context.Niveaus.Where(niv => niv.EnseignementId == EnseignementId).ToList();
        }

        /// <summary>
        /// Retourne la liste des séries d'un enseignement
        /// </summary>
        /// <param name="EnseignementId">L'identtité de l'enseignement</param>
        /// <returns></returns>
        public List<Serie> getListSerieFromEnseignement(long EnseignementId)
        {
            return _context.Series.Where(ser => ser.EnseignementId == EnseignementId).ToList();
        }

        /// <summary>
        /// Retourne la liste de toutes les classes d'un enseignement
        /// </summary>
        /// <param name="EnseignementId"></param>
        /// <returns></returns>
        public List<Classe> getClassesFromEnseignement(long EnseignementId)
        {
            return _context.Classes.Where(cl => cl.Niveau.EnseignementId == EnseignementId).ToList();
        }

        /// <summary>
        /// Retourne toutes les classes d'un systeme scolaire
        /// </summary>
        /// <param name="systemeScolaireId">Identifiant du système scolaire</param>
        /// <returns></returns>
        public List<Classe> getClassesFromSystemeScolaire(long systemeScolaireId)
        {
            return _context.Classes.Where(cl => cl.Niveau.Enseignement.SystemeScolaireId == systemeScolaireId).ToList();
        }
        
    }
}
