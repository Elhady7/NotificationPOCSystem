using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationPOCSystem.DAL.FactoryContextMethod
{
    public class CustomDbContextFactory : ICustomDbContextFactory
    {
        public FinalSharjahContext CreateFinalSharjahContext(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FinalSharjahContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new FinalSharjahContext(optionsBuilder.Options);
        }

        //public EvaluationContext CreateEvaluationContext(string connectionString)
        //{
        //    var optionsBuilder = new DbContextOptionsBuilder<EvaluationContext>();
        //    optionsBuilder.UseSqlServer(connectionString);

        //    return new EvaluationContext(optionsBuilder.Options);
        //}
    }

}
