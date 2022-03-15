using Sukulu.DataAccessLibrary.Enums;
using Sukulu.DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sukulu.DataAccessLibrary.Repositories
{

    public class EcoleFactory
    {
        private readonly SKLContext _context = new SKLContext();

        /// <summary>
        /// Retourne une école à partor de son identifiant
        /// </summary>
        /// <param name="ecoleId">Identifian de l'école</param>
        /// <returns></returns>
        public Ecole getEcoleById(long ecoleId)
        {
            return _context.Ecoles.Where(e => e.Id == ecoleId).FirstOrDefault();
        }
        /// <summary>
        /// Retourne la liste des classes d'une année scolaire dans une école 
        /// </summary>
        /// <param name="ecoleId">Identifiant de l'école</param>
        /// <param name="anneeScolaireId">Identifiant de l'année scolaire</param>
        /// <returns></returns>
        public List<SalleClasse> getEcoleSalleClasse(long ecoleId, long anneeScolaireId)
        {
            return _context.SalleClasses.Where(sc => sc.EcoleId == ecoleId && sc.AnneeScolaireId == anneeScolaireId).ToList();
        }

        /// <summary>
        /// Retourne la liste des élèves d'une annee scolaire dans une école 
        /// </summary>
        /// <param name="ecoleId"></param>
        /// <param name="anneeScolaireId"></param>
        /// <returns></returns>
        public List<Eleve> getAllelevesFromEcole(long ecoleId, long anneeScolaireId)
        {
            return _context.Inscriptions.Where(ins => ins.SalleClasse.AnneeScolaireId == anneeScolaireId && ins.SalleClasse.EcoleId == ecoleId)
                .Select(ins => ins.Eleve).Distinct().ToList();
        }

        /// <summary>
        /// Retourne toutes les inscriptions d'une année scolaire dans une école
        /// </summary>
        /// <param name="ecoleId">Identifiant école</param>
        /// <param name="anneeScolaireId">Identifiant année scolaire</param>
        /// <returns></returns>
        public List<Inscription> getAllInscriptionsFromEcole(long ecoleId, long anneeScolaireId)
        {
            return _context.Inscriptions.Where(ins => ins.SalleClasse.AnneeScolaireId == anneeScolaireId && ins.SalleClasse.EcoleId == ecoleId).ToList();
        }


        /// <summary>
        /// Retourne les eleves d'une classe
        /// </summary>
        /// <param name="salleClasseId">Identifinat de la classe</param>
        /// <returns></returns>
        public List<Eleve> getElevesFromSalleClasse(long salleClasseId)
        {
            return _context.Inscriptions.Where(ins => ins.SalleClasseId == salleClasseId).Select(ins => ins.Eleve).ToList();
        }


        /// <summary>
        /// Crée une salle de classe
        /// </summary>
        /// <param name="code">Code</param>
        /// <param name="name">Nom</param>
        /// <param name="description">Description</param>
        /// <param name="anneeScolaireId">Identifiant de l'année scolaire</param>
        /// <param name="classeId">Identifiant de la classe</param>
        /// <param name="ecoleId">Identifiant de l'école</param>
        /// <param name="createdBy">Auteur de la création</param>
        /// <param name="dateCreated">Date de création</param>
        /// <returns></returns>
        public long CreateSalleClasse(string code, string name, string description, long anneeScolaireId, long classeId, long ecoleId, string createdBy, DateTime dateCreated)
        {
            SalleClasse sc = new SalleClasse();
            sc.AnneeScolaireId = anneeScolaireId;
            sc.ClasseId = classeId;
            sc.EcoleId = ecoleId;
            sc.Code = code;
            sc.Name = name;
            sc.Description = description;
            sc.CreatedBy = createdBy;
            sc.DateCreated = dateCreated;
            _context.SalleClasses.Add(sc);
            _context.SaveChanges();

            return sc.Id;
        }

        /// <summary>
        /// Crée un élève
        /// </summary>
        /// <param name="number">Matricule</param>
        /// <param name="firstName">Prénom</param>
        /// <param name="lastName">Nom</param>
        /// <param name="otherNames">Autres noms</param>
        /// <param name="sexe">Sexe</param>
        /// <param name="dob">Date de naissance</param>
        /// <param name="email">Email</param>
        /// <param name="phone">Téléphone</param>
        /// <param name="notes">Notes/commentaires</param>
        /// <param name="photo">Photo</param>
        /// <param name="createdBy">Auteur de la création</param>
        /// <param name="dateCreated">Date de création</param>
        /// <returns></returns>
        public long CreateEleve(string number, string firstName, string lastName, string otherNames, Gender sexe, DateTime dob, 
            string email, string phone, string notes, byte[] photo, string createdBy, DateTime dateCreated)
        {
            Eleve el = new Eleve();

            el.Number = number;
            el.LastName = lastName;
            el.FirstName = firstName;
            el.OtherNames = otherNames;
            el.Sex = sexe;
            el.DateOfBirth = dob;
            el.Email = email;
            el.Phone = phone;
            el.Notes = notes;
            el.Photo = photo;
            el.CreatedBy = createdBy;
            el.DateCreated = dateCreated;

            _context.Eleves.Add(el);
            _context.SaveChanges();

            return el.Id;
        }



        /// <summary>
        /// Crée un enseignant
        /// </summary>
        /// <param name="number">Matricule</param>
        /// <param name="firstName">Prénom</param>
        /// <param name="lastName">Nom</param>
        /// <param name="otherNames">Autres noms</param>
        /// <param name="sexe">Sexe</param>
        /// <param name="dob">Date de naissance</param>
        /// <param name="email">Email</param>
        /// <param name="phone">Téléphone</param>
        /// <param name="notes">Notes/commentaires</param>
        /// <param name="photo">Photo</param>
        /// <param name="createdBy">Auteur de la création</param>
        /// <param name="dateCreated">Date de création</param>
        /// <returns></returns>
        public long CreateEnseignant(string number, string firstName, string lastName, string otherNames, Gender sexe, DateTime dob,
            string email, string phone, string notes, byte[] photo, string createdBy, DateTime dateCreated)
        {
            Enseignant ens = new Enseignant();

            ens.Number = number;
            ens.LastName = lastName;
            ens.FirstName = firstName;
            ens.OtherNames = otherNames;
            ens.Sexe = sexe;
            ens.DateOfBirth = dob;
            ens.Email = email;
            ens.Phone = phone;
            ens.Notes = notes;
            ens.Photo = photo;
            ens.CreatedBy = createdBy;
            ens.DateCreated = dateCreated;

            _context.Enseignants.Add(ens);
            _context.SaveChanges();

            return ens.Id;
        }

        /// <summary>
        /// Retourne vrai ou faux un matricule d'élève est déjà utiliséou pas
        /// </summary>
        /// <param name="matricule">Matricule de l'eleve</param>
        /// <returns></returns>
        public Boolean IsEleveMatriculeInUse(string matricule)
        {
            Eleve el = _context.Eleves.Where(e => e.Number.ToUpper() == matricule.ToUpper()).FirstOrDefault();
            if (el == null) return false; else return true;
        }


        /// <summary>
        /// Retourne vrai ou faux un matricule d'un enseignant est déjà utiliséou pas
        /// </summary>
        /// <param name="matricule">Matricule de l'enseignant</param>
        /// <returns></returns>
        public Boolean IsEnseignantMatriculeInUse(string matricule)
        {
            Enseignant el = _context.Enseignants.Where(e => e.Number.ToUpper() == matricule.ToUpper()).FirstOrDefault();
            if (el == null) return false; else return true;
        }

        /// <summary>
        /// Retourne le nombre d'inscription d'un élève
        /// </summary>
        /// <param name="eleveId">Identifiant de l'élève</param>
        /// <returns></returns>
        public int getEleveNumberOfInscriptions(long eleveId)
        {
            return _context.Inscriptions.Where(ins => ins.EleveId == eleveId).Count();
        }

        /// <summary>
        /// Retourne un élève d'un matricule donné
        /// </summary>
        /// <param name="eleveNumber">Matricule de l'élève</param>
        /// <returns></returns>
        public Eleve getEleveFromMatricule(string eleveNumber)
        {
            return _context.Eleves.Where(e => e.Number.ToUpper() == eleveNumber.ToUpper()).FirstOrDefault();
        }

        /// <summary>
        /// Retourne une année scolaire par son identifiant
        /// </summary>
        /// <param name="anneeScolaireId">Identifiant de l'année scolaire</param>
        /// <returns></returns>
        public AnneeScolaire getAnneeScolaireById(long anneeScolaireId)
        {
            return _context.AnneeScolaires.Where(asco => asco.Id == anneeScolaireId).FirstOrDefault();
        }


        /// <summary>
        /// Crée une inscription
        /// </summary>
        /// <param name="eleveId">Identifiant ♪0lève</param>
        /// <param name="salleClasseId">Identifiant salle classe</param>
        /// <param name="dateInscription">Date d'inscription</param>
        /// <param name="notes">Notes</param>
        /// <param name="createdBy">Auteur de la création</param>
        /// <param name="dateCreated">Date de création</param>
        /// <returns></returns>
        public long CreateInscription(long eleveId, long salleClasseId, DateTime dateInscription, string notes, string createdBy, DateTime dateCreated)
        {
            Inscription insc = new Inscription();
            insc.EleveId = eleveId;
            insc.SalleClasseId = salleClasseId;
            insc.DateInscription = dateInscription;
            insc.Notes = notes;
            insc.CreatedBy = createdBy;
            insc.DateCreated = dateCreated;

            _context.Inscriptions.Add(insc);
            _context.SaveChanges();

            return insc.Id;
        }

        /// <summary>
        /// Retourne la liste d'inscription d'une année scolaire dans une école
        /// </summary>
        /// <param name="ecoleId">Identifiant de l'école</param>
        /// <param name="anneeScolaireId">Identifiant de l'année scolaire</param>
        /// <returns></returns>
        public List<Inscription> getInscriptionOfEcoleAndAnneeScolaire(long ecoleId, long anneeScolaireId)
        {
            return _context.Inscriptions.Where(insc => insc.SalleClasse.AnneeScolaireId == anneeScolaireId && insc.SalleClasse.EcoleId == ecoleId).ToList();
        }


        /// <summary>
        /// Retourne tous les élèves du système
        /// </summary>
        /// <returns></returns>
        public List<Eleve> getAllEleves()
        {
            return _context.Eleves.ToList();
        }

        /// <summary>
        /// Retourne un élève à partir de son identifiant 
        /// </summary>
        /// <param name="eleveId">Identifiant de l'élève</param>
        /// <returns></returns>
        public Eleve getEleveById(long eleveId)
        {
            return _context.Eleves.Where(el => el.Id == eleveId).FirstOrDefault();
        }

        /// <summary>
        /// Retourne une salle classe a partir de son identifiant
        /// </summary>
        /// <param name="salleClasseId">Identifiant de la salle de classe</param>
        /// <returns></returns>
        public SalleClasse getSalleClasseById(long salleClasseId)
        {
            return _context.SalleClasses.Where(sc => sc.Id == salleClasseId).FirstOrDefault();
        }

        /// <summary>
        /// Retourne la liste de toutes les écoles 
        /// </summary>
        /// <returns></returns>
        public List<Ecole> getAllEcoles()
        {
            return _context.Ecoles.ToList();
        }

        public List<Eleve> getAllElevesFromAnneeScolaire(long anneeScolaireId)
        {
            return _context.Inscriptions.Where(i => i.SalleClasse.AnneeScolaireId == anneeScolaireId).Select(i => i.Eleve).Distinct().ToList();
        }

        public List<Eleve> getAllElevesFromEcoleAndAnneeScolaire(long ecoleId, long anneeScolaireId)
        {
            return _context.Inscriptions.Where(insc => insc.SalleClasse.AnneeScolaireId == anneeScolaireId && insc.SalleClasse.EcoleId == ecoleId).Select(insc => insc.Eleve).Distinct().ToList();
        }

    }
}
