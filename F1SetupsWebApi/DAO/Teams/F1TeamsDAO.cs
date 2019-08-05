using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAO.Teams
{
    public class F1TeamsDAO
    {
        F1SetupContext context;
        public F1TeamsDAO(F1SetupContext context)
        {
            this.context = context;
        }

        internal List<F1Team> GetF1Teams()
        {
            return this.context.F1Teams.ToList();
        }

        internal F1Team GetF1Team(int id)
        {
            return this.context.F1Teams.SingleOrDefault(x => x.IdTeam == id);
        }

        internal F1Team PostF1Team(F1Team model)
        {
            F1Team f1Teams = new F1Team()
            {
                TeamName = model.TeamName,
                IdEngine = model.IdEngine,
                F1Season = model.F1Season,
                Headquarters = model.Headquarters,
                HeadquartersX = model.HeadquartersX,
                HeadquartersY = model.HeadquartersY,
                FoundationYear = model.FoundationYear,
                creationDate = model.creationDate,
                modifiedDate = model.modifiedDate,
                rowguid = model.rowguid
            };
            context.SaveChanges();
            return f1Teams;
        }
    }
}
