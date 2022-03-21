using ModelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelRecordsServer.db
{
    public partial class Experience
    {
        public static explicit operator ExperienceApi(Experience experience)
        {
            if (experience == null)
                return null;
            return new ExperienceApi
            {
                Id = experience.Id,
                WorkerId = experience.WorkerId,
                PositionName = experience.PositionName,
                WorkPeriod = experience.WorkPeriod,
            };
        }
        public static explicit operator Experience(ExperienceApi experience)
        {
            if (experience == null)
                return null;
            return new Experience
            {
                Id = experience.Id,
                WorkerId = experience.WorkerId,
                PositionName = experience.PositionName,
                WorkPeriod = experience.WorkPeriod,
            };
        }
    }
}
