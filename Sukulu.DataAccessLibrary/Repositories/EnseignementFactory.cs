using Sukulu.DataAccessLibrary.Enums;
using Sukulu.DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sukulu.DataAccessLibrary.Repositories
{
    public class EnseignementFactory
    {
        private readonly SKLContext _context = new SKLContext();

        /// <summary>
        /// Retourne une matière à partir de son identifiant
        /// </summary>
        /// <param name="matiereId">Identifiant de la matière</param>
        /// <returns></returns>
        public Matiere getMatiereById(long matiereId)
        {
            return _context.Matieres.Where(m => m.Id == matiereId).FirstOrDefault();
        }

        /// <summary>
        /// Retourne un enseignant à partir de son identifiant
        /// </summary>
        /// <param name="enseignantId">Identifiant de l'enseignant</param>
        /// <returns></returns>
        public Enseignant getEnseignantById(long enseignantId)
        {
            return _context.Enseignants.Where(e => e.Id == enseignantId).FirstOrDefault();
        }

        /// <summary>
        /// Retourne toutes les matières
        /// </summary>
        /// <returns></returns>
        public List<Matiere> getAllMatieres()
        {
            return _context.Matieres.ToList();
        }

        /// <summary>
        /// Retourne la liste des enseignants officiant dans une école
        /// </summary>
        /// <param name="ecoleId">Identifiant de l'école</param>
        /// <returns></returns>
        List<Enseignant> getEnseignantsFromEcole(long ecoleId)
        {
            return _context.PortfolioEnseignants.Where(p => p.SalleClasseMatiere.SalleClasse.EcoleId == ecoleId).Select(p => p.Enseignant).Distinct().ToList();
        }

        /// <summary>
        /// Retourne une liste de SalleClasseMatiere seolan la salle de classe
        /// </summary>
        /// <param name="salleClasseId">dIdentifiant de la salle de classe</param>
        /// <returns></returns>
        public List<SalleClasseMatiere> getSalleClasseMatiere(long salleClasseId)
        {
            return _context.SalleClasseMatieres.Where(scm => scm.SalleClasseId == salleClasseId).ToList();
        }

        /// <summary>
        /// Retourne le portfolio d'un enseignat officiant dans une école en une année scolaire
        /// </summary>
        /// <param name="ecoleId">Identifiant de l'école</param>
        /// <param name="anneeScolaireId">Identifiant de l'année scolaire</param>
        /// <param name="enseignantId">Identifiant de l'enseignant</param>
        /// <returns></returns>
        public List<PortfolioEnseignant> getEnseigantPortfolioForAnneeScolairePerEcole(long ecoleId,long anneeScolaireId, long enseignantId)
        {
            return _context.PortfolioEnseignants.Where(ep => ep.SalleClasseMatiere.SalleClasse.EcoleId == ecoleId &&
            ep.SalleClasseMatiere.SalleClasse.AnneeScolaireId == anneeScolaireId && ep.EnseignantId == enseignantId).ToList();
        }

        /// <summary>
        /// Retourne une instance de coursPrevu 
        /// </summary>
        /// <param name="coursPrevuId">Identifiant de coursPrevu</param>
        /// <returns></returns>
        public CoursPrevu getCoursPrevuById(long coursPrevuId)
        {
            return _context.CoursPrevus.Where(cp => cp.Id == coursPrevuId).FirstOrDefault();
        }

        /// <summary>
        /// Retourne une liste d'element d'emploi du jour d'une classe et d'un jour spécifique
        /// </summary>
        /// <param name="Day">Date</param>
        /// <param name="salleClasseId">Identifiant salle de classe</param>
        /// <returns></returns>
        public List<CoursPrevu> getListCoursPrevuOfSalleClasseOfDay(DateTime Day, long salleClasseId)
        {
            return _context.CoursPrevus.Where(cp => cp.PortfolioEnseignant.SalleClasseMatiere.SalleClasseId == salleClasseId &&
            cp.Start.Date == Day.Date).ToList();
        }

        /// <summary>
        /// Retourne la liste d'enseignat officiant dans une classe et dans une matiere donnée
        /// </summary>
        /// <param name="salleClasseId">Identifiant de la salle de classe</param>
        /// <param name="matiereId">Identifiant de la matière</param>
        /// <returns></returns>
        public List<Enseignant> getListEnseignantForSalleClasseAndMatiere(long salleClasseId, long matiereId)
        {
            return _context.PortfolioEnseignants.Where(pe => pe.SalleClasseMatiere.MatiereId == matiereId &&
            pe.SalleClasseMatiere.SalleClasseId == salleClasseId).Select(pe => pe.Enseignant).Distinct().ToList();
        }


        /// <summary>
        /// Liste de cours prevus a partir d'une certaine date au meme jour et meme temps (Heures, min)
        /// </summary>
        /// <param name="salleClasseId">Identifiant salle de classe</param>
        /// <param name="StartDate">Date de début</param>
        /// <param name="EndDate">Date de fin</param>
        /// <param name="jour">Le Jour</param>
        /// <returns></returns>
        public List<CoursPrevu> getAllCourPrevusBetweenDates(long salleClasseId, Jour jour, DateTime StartStartDate, DateTime EndStartDate, 
            DateTime StartEndDate, DateTime EndEndDate)
        {
            DateTimeFactory Factory = new DateTimeFactory();
            DateTime Date = Factory.getFirstDateFromDateAndJour(StartStartDate, jour);
            DateTime FirstDateStart = new DateTime(Date.Year, Date.Month, Date.Day, StartStartDate.Hour, StartStartDate.Minute, StartStartDate.Second);
            DateTime FirstDateEnd = new DateTime(Date.Year, Date.Month, Date.Day, EndStartDate.Hour, EndStartDate.Minute, EndStartDate.Second);
            List<CoursPrevu> ListCoursPrevus = new List<CoursPrevu>();
            do
            {
                List<CoursPrevu> coursPrevus = 
                    _context.CoursPrevus.Where(cp => (DateTime.Compare(cp.Start, FirstDateStart) >= 0 && 
                                                     DateTime.Compare(cp.Start, FirstDateEnd) <= 0 ) ||
                                                     (DateTime.Compare(cp.End, FirstDateStart) >= 0 &&
                                                     DateTime.Compare(cp.End, FirstDateEnd) <= 0) && 
                                                     cp.PortfolioEnseignant.SalleClasseMatiere.SalleClasseId == salleClasseId).ToList();


                FirstDateStart = FirstDateStart.AddDays(7);
                FirstDateEnd = FirstDateEnd.AddDays(7);
                if (coursPrevus.Count > 0) ListCoursPrevus.AddRange(coursPrevus);
            }
            while (FirstDateStart < EndEndDate);

            return ListCoursPrevus;
        }

        /// <summary>
        /// Crée un élément d'emploi du temps (CoursPrevu)
        /// </summary>
        /// <param name="start">Date et heure de debut</param>
        /// <param name="end">Date et heure de fin</param>
        /// <param name="portfoliotEnseignantId">Identifiant du portfolio de l'enseignant</param>
        /// <param name="createdBy">Auteur de la création</param>
        /// <param name="dateCreated">Date de création</param>
        /// <returns></returns>
        public long createCoursPrevu(DateTime start, DateTime end, long portfolioEnseignantId, string createdBy, DateTime dateCreated)
        {
            CoursPrevu cp = new CoursPrevu();
            cp.Start = start;
            cp.End = end;
            cp.PortfolioEnseignantId = portfolioEnseignantId;
            cp.CreatedBy = createdBy;
            cp.DateCreated = dateCreated;

            _context.CoursPrevus.Add(cp);
            _context.SaveChanges();

            return cp.Id;
        }

        /// <summary>
        /// Crée des éléments d'emplois du temps (Cours Prevus) entre 2 date au meme jour
        /// </summary>
        /// <param name="portfolioEnseignantId">Identifiant du portfolio de l'enseignant</param>
        /// <param name="startStartDate">Date et heure du Debut (du debut)</param>
        /// <param name="endStartDate">Date et heure de la Fin (du debut)</param>
        /// <param name="startEndDate">Date et heure du Debut (de la fin)</param>
        /// <param name="endEndDate">Date et heure de la Fin (de la fin)</param>
        /// <param name="createdBy">Auteur de la création</param>
        /// <param name="dateCreated">Date de création</param>
        /// <returns></returns>
        public List<CoursPrevu> createCoursPrevuBetweenDates(long portfolioEnseignantId, DateTime startStartDate, DateTime endStartDate, 
            DateTime startEndDate, DateTime endEndDate, string createdBy, DateTime dateCreated)
        {
            int NumberOfCoursPrevuCreated = 0;
            List<CoursPrevu> ListCoursPrevus = new List<CoursPrevu>();
            DateTime Start = startStartDate;
            DateTime End = new DateTime(startStartDate.Year, startStartDate.Month, startStartDate.Day, endStartDate.Hour, endStartDate.Minute, endStartDate.Second);
            do
            {
                long id = createCoursPrevu(Start, End, portfolioEnseignantId, createdBy, dateCreated);
                ListCoursPrevus.Add(getCoursPrevuById(id));
                NumberOfCoursPrevuCreated++;
                Start = Start.AddDays(7);
                End = End.AddDays(7);
            }
            while (End <= endEndDate);

            return ListCoursPrevus;
        }

        /// <summary>
        /// Retourne le portfolio d'un enseignant selon la matiere et la salle de classe
        /// </summary>
        /// <param name="matiereId">Identifiant matière</param>
        /// <param name="salleClasseId">Identifiant Salle de classe</param>
        /// <param name="enseignantId">Identifiant enseignant</param>
        /// <returns></returns>
        public PortfolioEnseignant getPortfolioEnseignantMatiereSalleClasse(long matiereId, long salleClasseId, long enseignantId)
        {
            return _context.PortfolioEnseignants.Where(p => p.EnseignantId == enseignantId && p.SalleClasseMatiere.MatiereId == matiereId &&
            p.SalleClasseMatiere.SalleClasseId == salleClasseId).FirstOrDefault();
        }


        /// <summary>
        /// Retourne la liste des matieres non encore rajoutées aux matieres enseignées dans une salle de classe
        /// </summary>
        /// <param name="salleClasseId">Identifiant de la salle de classe</param>
        /// <returns></returns>
        public List<Matiere> getMatieresNotInSalleClasseMatiere(long salleClasseId)
        {
            List<Matiere> ListMatieres = getAllMatieres();
            return ListMatieres.Except(_context.SalleClasseMatieres.Where(
                scm => scm.SalleClasseId == salleClasseId)
                .Select(scm => scm.Matiere).Distinct().ToList()).ToList();
        }


        /// <summary>
        /// Crée une instance de salleClasseMatiere
        /// </summary>
        /// <param name="matiereId">Identifiant Matière</param>
        /// <param name="salleClasseId">Identifiant salle de classe</param>
        /// <param name="notes">Notes</param>
        /// <param name="coefficient">Coefficient</param>
        /// <param name="createdBy">Auteur de la création</param>
        /// <param name="dateCreated">Date de la création</param>
        /// <returns></returns>
        public long createSalleClasseMatiere(long matiereId, long salleClasseId, string notes, Double coefficient, string createdBy, DateTime dateCreated)
        {
            SalleClasseMatiere scm = new SalleClasseMatiere();
            scm.MatiereId = matiereId;
            scm.SalleClasseId = salleClasseId;
            scm.Coefficient = coefficient;
            scm.Notes = notes;
            scm.CreatedBy = createdBy;
            scm.DateCreated = dateCreated;

            _context.SalleClasseMatieres.Add(scm);

            _context.SaveChanges();

            return scm.Id;
        }

        public List<Enseignant> getAllEnseignants()
        {
            return _context.Enseignants.ToList();
        }

        public List<SalleClasse> getSalleClassesFromMatiere(long matiereId, long anneeScolaireId)
        {
            return _context.SalleClasseMatieres.Where(scm => scm.SalleClasse.AnneeScolaireId == anneeScolaireId &&
                                                      scm.MatiereId == matiereId).Select(scm => scm.SalleClasse).Distinct().ToList();
        }

        public SalleClasseMatiere getSalleClasseMatiereFromSalleClasseAndMatiere(long salleClasseId, long matiereId)
        {
            return _context.SalleClasseMatieres.Where(scm => scm.SalleClasseId == salleClasseId && scm.MatiereId == matiereId).FirstOrDefault();
        }

        public long createPortfolioEnseignant(long salleClasseMatiereId, long enseignantId, DateTime startDate, DateTime endDate, 
            string notes, string createdBy, DateTime dateCreated)
        {
            PortfolioEnseignant pfe = new PortfolioEnseignant();
            pfe.SalleClasseMatiereId = salleClasseMatiereId;
            pfe.EnseignantId = enseignantId;
            pfe.StartDate = startDate;
            pfe.EndDate = endDate;
            pfe.Notes = notes;
            pfe.CreatedBy = createdBy;
            pfe.DateCreated = dateCreated;

            _context.PortfolioEnseignants.Add(pfe);
            _context.SaveChanges();

            return pfe.Id;
        }

        /// <summary>
        /// Crée une présence
        /// </summary>
        /// <param name="code">Code de la présence</param>
        /// <param name="notes">Notes</param>
        /// <param name="coursPrevuId">Identifiant du cours </param>
        /// <param name="eleveId">Identifiant de l'eleve</param>
        /// <param name="createdBy">Auteur de la creation</param>
        /// <param name="dateCreated">Date de la creation</param>
        /// <returns></returns>
        public long createPresence(CodePresence code, string notes, long coursPrevuId, long eleveId, string createdBy, DateTime dateCreated)
        {
            Presence pr = new Presence();
            pr.Code = code;
            pr.Notes = notes;
            pr.CoursPrevuId = coursPrevuId;
            pr.EleveId = eleveId;
            pr.CreatedBy = createdBy.ToUpper();
            pr.DateCreated = dateCreated;

            _context.Presences.Add(pr);

            return pr.Id;
        }

        public List<Enseignant> getAllEnseignantsFromEcoleAndAnneeScolaire(long ecoleId, long anneeScolaireId)
        {
            return _context.PortfolioEnseignants.Where(p => p.SalleClasseMatiere.SalleClasse.EcoleId == ecoleId &&
            p.SalleClasseMatiere.SalleClasse.AnneeScolaireId == anneeScolaireId).Select(p => p.Enseignant).Distinct().ToList();
        }

        public List<Enseignant> getAllEnseignantsFromSalleClasse(long salleClasseId)
        {
            return _context.PortfolioEnseignants.Where(p => p.SalleClasseMatiere.SalleClasseId == salleClasseId).Select(p => p.Enseignant).Distinct().ToList();
        }

    }
}
