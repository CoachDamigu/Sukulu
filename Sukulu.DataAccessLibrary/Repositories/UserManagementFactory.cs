using Sukulu.DataAccessLibrary.Enums;
using Sukulu.DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sukulu.DataAccessLibrary.Repositories
{
    public class UserManagementFactory
    {
        private readonly SKLContext _context = new SKLContext();

        /// <summary>
        /// Retourne vrai ou faux si un nom d'utilisateur est déjà utilisé ou pas.
        /// </summary>
        /// <param name="login"> Nom d'utilisateur</param>
        /// <returns></returns>
        public Boolean isLoginExist(string login)
        {
            SKLUser user = _context.SKLUsers.Where(u => u.Login.ToUpper() == login.ToUpper()).FirstOrDefault();
            if (user == null) return false; else return true; 
        }

        /// <summary>
        /// Crée un utilisateur 
        /// </summary>
        /// <param name="login">Nom d'utilisateur</param>
        /// <param name="firstName">Prenom</param>
        /// <param name="lastName">Nom</param>
        /// <param name="email">Email</param>
        /// <param name="passwordHashed"></param>
        /// <param name="passwordSalt"></param>
        /// <param name="isFirtTimeLogging">Est-ce la premiere fois que l'utilisatuer va se connecter</param>
        /// <param name="accountLocked">Le compte est-il bloqué</param>
        /// <param name="userType">Type d'utilisateur</param>
        /// <param name="lastTimeLogging">Date et heure de la dernière fois que l'utilisateur s'est connecté</param>
        /// <param name="createdBy">Auteur de la création</param>
        /// <param name="dateCreated">Date de création</param>
        /// <returns>Identifiant de l'utilisateur</returns>
        public long createSKLUser(string login, string firstName, string lastName, string email, string passwordHashed, byte[] passwordSalt, Boolean isFirtTimeLogging, 
            Boolean accountLocked, SKLUserType userType, string createdBy, DateTime dateCreated)
        {
            SKLUser user = new SKLUser();
            user.UserType = userType;
            user.Login = login;
            user.FirstName = firstName;
            user.LastName = lastName;
            user.Email = email;
            user.PasswordHashed = passwordHashed;
            user.PasswordSalt = passwordSalt;
            user.FirstTimeLogging = isFirtTimeLogging;
            user.AccountLocked = accountLocked;
            user.CreatedBy = createdBy;
            user.DateCreated = dateCreated;

            _context.SKLUsers.Add(user);
            _context.SaveChanges();

            return user.Id;
        }

        public long createUserResource(long SKLUserId, SKLResourceType resourceType, long resourceId, Boolean IsLocked, string createdBy, DateTime dateCreated)
        {
            SKLUserResource userResource = new SKLUserResource();
            userResource.SKLUserId = SKLUserId;
            userResource.ResourceType = resourceType;
            userResource.ResourceId = resourceId;
            userResource.ResourceLocked = IsLocked;
            userResource.CreatedBy = createdBy;
            userResource.DateCreated = dateCreated;

            _context.SKLUserResources.Add(userResource);
            _context.SaveChanges();

            return userResource.Id;
        }

        public List<SKLUser> getAllUsers()
        {
            return _context.SKLUsers.ToList();
        }

        /// <summary>
        /// Retourne un utilisateur à partir de son nom d'utilisateur
        /// </summary>
        /// <param name="login">Nom d'utilisateur</param>
        /// <returns></returns>
        public SKLUser getUserFromLogin(string login)
        {
            return _context.SKLUsers.Where(u => u.Login.ToLower() == login.ToLower()).FirstOrDefault();
        }


        public SKLUser getUserById(long userId)
        {
            return _context.SKLUsers.Where(u => u.Id == userId).FirstOrDefault();
        }

        
        public string getUserHash(string login)
        {
            return _context.SKLUsers.Where(u => u.Login.ToLower() == login.ToLower()).FirstOrDefault().PasswordHashed;
        }


        public Ecole getSKLEcoleAdminResource(long userId)
        {
            long ecoleId = _context.SKLUserResources.Where(u => u.SKLUserId == userId && (int)u.ResourceType == 0).FirstOrDefault().ResourceId;
            EcoleFactory factory = new EcoleFactory();
            return factory.getEcoleById(ecoleId);
        }

        /// <summary>
        /// Retourne tous les clients de SUKULU
        /// </summary>
        /// <returns></returns>
        public List<SKLClient> getAllClient()
        {
            return _context.SKLClients.ToList();
        }

        /// <summary>
        /// Retorune un Client de SUKULU à partir de son identifiant
        /// </summary>
        /// <param name="clientId">Identifiant du client SUKULU</param>
        /// <returns></returns>
        public SKLClient getSKLClientById(long clientId)
        {
            return _context.SKLClients.Where(c => c.Id == clientId).FirstOrDefault();
        }

        /// <summary>
        /// Retourne la liste de écoles d'un client SUKULU
        /// </summary>
        /// <param name="clientId">Identifiant du client</param>
        /// <returns></returns>
        public List<Ecole> getClientEcoles(long clientId)
        {
            return _context.SKLClientEcoles.Where(ce => ce.SKLClientId == clientId).Select(ce => ce.Ecole).ToList();
        }


        /// <summary>
        /// Retourne la list de tous les utilisateurs d'un client et d'une école 
        /// </summary>
        /// <param name="clientId">Identifiant du client</param>
        /// <param name="ecoleId">Identifiant de l'écol</param>
        /// <returns></returns>
        public List<SKLUser> getClientEcoleUsers(long clientId, long ecoleId)
        {
            //List<SKLUser> ListUsers = new List<SKLUser>();
            //List<Ecole> ListEcoles = getClientEcoles(clientId);
            //if (ListEcoles.Count > 0)
            //    foreach(Ecole ecole in ListEcoles)
            //    {
            //        ListUsers.AddRange(_context.SKLUserResources.Where(ur => ur.ResourceType == SKLResourceType.Ecole && ur.ResourceId == ecole.Id)
            //            .Select(ur => ur.SKLUser).Distinct().ToList());
            //    }
            //return ListUsers;

            return _context.SKLClientEcoleUsers.Where(ceu => ceu.SKLClientEcole.EcoleId == ecoleId && ceu.SKLClientEcole.SKLClientId == clientId)
                .Select(ceu => ceu.SKLUser).ToList();
        }

        /// <summary>
        /// Retourne les resources(SalleClasse) d'un utilisateur
        /// </summary>
        /// <param name="userId">Identifiant de l'utilisateur</param>
        /// <returns></returns>
        public List<SKLUserResource> getUserResourcesSalleClasses(long userId)
        {
            return _context.SKLUserResources.Where(ur => ur.SKLUserId == userId && ur.ResourceType == SKLResourceType.Classe).ToList();
        }


        /// <summary>
        /// Retourne les resources(Eleves) d'un utilisateur
        /// </summary>
        /// <param name="userId">Identifiant de l'utilisateur</param>
        /// <returns></returns>
        public List<SKLUserResource> getUserResourcesEleves(long userId)
        {
            return _context.SKLUserResources.Where(ur => ur.SKLUserId == userId && ur.ResourceType == SKLResourceType.Eleve).ToList();
        }


        public Boolean isUserHasAccesstoEcole(long userId, long ecoleId)
        {
            SKLUserResource resource = _context.SKLUserResources.Where(ur => ur.SKLUserId == userId &&
            ur.ResourceType == SKLResourceType.Ecole && ur.ResourceId == ecoleId).FirstOrDefault();

            if (resource == null) return false; else return true;
        }

        public List<SKLUserResource> getUserAllResources(long userId)
        {
            return _context.SKLUserResources.Where(ur => ur.SKLUserId == userId).ToList();
        }

        public long createSKLClient(string name, string notes, string createdBy, DateTime dateCreated)
        {
            SKLClient client = new SKLClient();
            client.Name = name;
            client.Notes = notes;
            client.CreatedBy = createdBy;
            client.DateCreated = dateCreated;

            _context.SKLClients.Add(client);
            _context.SaveChanges();

            return client.Id;
        }


        public long createSKLClientEcole(long clientId, long ecoleId, string createdBy, DateTime dateCreated)
        {
            SKLClientEcole clientEcole = new SKLClientEcole();
            clientEcole.EcoleId = ecoleId;
            clientEcole.SKLClientId = clientId;
            clientEcole.CreatedBy = createdBy;
            clientEcole.DateCreated = dateCreated;

            _context.SKLClientEcoles.Add(clientEcole);
            _context.SaveChanges();

            return clientEcole.Id;
        }


        public List<Ecole> getEcolesNotPartOfClientPortfolio(long clientId)
        {
            List<Ecole> ListAllEcoles = _context.Ecoles.ToList();
            List<Ecole> ListEcoleWithClient = _context.SKLClientEcoles.Where(ce => ce.SKLClientId == clientId).Select(ec => ec.Ecole).Distinct().ToList();
            foreach (Ecole ecole in ListEcoleWithClient)
                ListAllEcoles.Remove(ecole);
            return ListAllEcoles;
        }

        public List<Ecole> getEcolesWithoutClient()
        {
            List<Ecole> ListAllEcoles = _context.Ecoles.ToList();
            List<Ecole> ListEcolesWithClient = _context.SKLClientEcoles.Select(ce => ce.Ecole).Distinct().ToList();
            foreach (Ecole ecole in ListEcolesWithClient)
                ListAllEcoles.Remove(ecole);
            return ListAllEcoles;
        }

        public Boolean isClientEcoleExist(long clientId, long ecoleId)
        {
            SKLClientEcole clientEcole = _context.SKLClientEcoles.Where(ce => ce.SKLClientId == clientId && ce.EcoleId == ecoleId).FirstOrDefault();
            if (clientEcole != null) return true; else return false;
        }

        //public List<SKLUser> getUsersFromEcoleAndClient(long clientId, long ecoleId)
        //{
        //    List<SKLClientEcole> ListClientEcoles = _context.SKLClientEcoles.Where(ce => ce.EcoleId == ecoleId && ce.SKLClientId == clientId).ToList();

        //    List<SKLUser> ListUsers = new List<SKLUser>();
        //    List<SKLClientUser> ListClientUsers = _context.SKLClientUsers.Where(cu => cu.SKLClientId == clientId).ToList();
        //    foreach(SKLClientUser ClientUser in ListClientUsers)
        //    {
        //        SKLClientEcole clienEcole = _context.SKLClie
        //    }
        //}

    }
}
