﻿using Make3D.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Make3D.DAL.Interfaces
{
    public interface IUtilisateurRepository
    {
        void RegisterUtilisateur(UtilisateurData data);

        UtilisateurData LoginUtilisateur(string email, string password);

        UtilisateurData GetUtilisateurById(int id);
    }
}
