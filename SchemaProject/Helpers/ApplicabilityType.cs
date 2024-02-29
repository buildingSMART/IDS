using Ids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ids
{
    public partial class ApplicabilityType 
    {
        public enum ApplicabilityCardinality
        {
            Required,
            Optional,
            Prohibited
        }

        public static ApplicabilityType CreateApplicabilityType(ApplicabilityCardinality cardinality) 
        {
            ApplicabilityType t = new ApplicabilityType();
            switch (cardinality)
            {
                case ApplicabilityCardinality.Required:
                    t.MinOccurs = "1";
                    t.MaxOccurs = "unbounded";
                    break;
                case ApplicabilityCardinality.Optional:
                    t.MinOccurs = "0";
                    t.MaxOccurs = "unbounded";
                    break;
                case ApplicabilityCardinality.Prohibited:
                    t.MinOccurs = "0";
                    t.MaxOccurs = "0";
                    break;
            }
            return t;
        }
    }
}
