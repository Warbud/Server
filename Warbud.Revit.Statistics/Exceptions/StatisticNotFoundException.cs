using System.Net;
using Warbud.Shared.Abstraction.Exceptions;

namespace Warbud.Revit.Statistics.Exceptions
{
    public class StatisticNotFoundException : WarbudException
    {
        public override HttpStatusCode StatusCode => HttpStatusCode.NotFound;

        public StatisticNotFoundException() : base("The requested element was not found.")
        {
        }
    }
}