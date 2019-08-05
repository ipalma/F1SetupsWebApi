using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAO
{
    public class F1DriversDAO
    {
        private readonly F1SetupContext ctx;
        public F1DriversDAO(F1SetupContext ctx)
        {
            this.ctx = ctx;
        }


        internal List<F1Driver> GetDrivers()
        {
            return ctx.F1Drivers.ToList();
        }

        internal F1Driver GetDriver(int id)
        {
            return ctx.F1Drivers.Single(x => x.IdDriver == id);
        }
    }
}
