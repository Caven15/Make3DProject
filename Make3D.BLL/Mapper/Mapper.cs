﻿using Make3D.BLL.Models;
using Make3D.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make3D.BLL.Mapper
{
    public static class Mapper
    {
        /*--------------------------------------* Utilisateur *----------------------------------------*/

        internal static UtilisateurData BllToDal(this UtilisateurModel model)
        {
            return new UtilisateurData()
            {
                Id_utilisateur = model.Id_utilisateur,
                Nom = model.Nom,
                Prenom = model.Prenom,
                Email = model.Email,
                DateNaissance = model.DateNaissance,
                Password = model.Password,
                IsAdmin = model.IsAdmin
            };
        }

        internal static UtilisateurModel DalToBll(this UtilisateurData data)
        {
            return new UtilisateurModel()
            {
                Id_utilisateur = data.Id_utilisateur,
                Nom = data.Nom,
                Prenom = data.Prenom,
                Email = data.Email,
                DateNaissance = data.DateNaissance,
                IsAdmin = data.IsAdmin
            };
        }
    }
}