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

    }
}
