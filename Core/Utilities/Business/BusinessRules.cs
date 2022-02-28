using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            //logics: iş kuralları
            foreach (var logic in logics)
            {
                if (!logic.Success) //kurallara uymayan varsa
                {
                    return logic; //kuralı döndür.
                }
            }
            return null;
        }
    }
}
