using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationPOCSystem.DAL.FactoryContextMethod
{
    public interface ICustomDbContextFactory
    {
        FinalSharjahContext CreateFinalSharjahContext(string connectionString);
       // EvaluationContext CreateEvaluationContext(string connectionString);
    }

}
