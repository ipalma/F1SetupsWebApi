using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAO
{
    public class F1RaceCircuitsDAO
    {
        F1SetupContext ctx;

        public F1RaceCircuitsDAO(F1SetupContext ctx)
        {
            this.ctx = ctx;
        }

        internal List<F1RaceCircuit> Get()
        {
            return ctx.F1RaceCircuits.ToList();
        }

        internal F1RaceCircuit Get(int id)
        {
            return ctx.F1RaceCircuits.Single(x => x.IdCircuit == id);
        }
    }
}
