using ModelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonnelRecordsServer.db
{
    public partial class Worker
    {
        public static explicit operator WorkerApi(Worker worker)
        {
            return new WorkerApi
            {
                Id = worker.Id,
                Surname = worker.Surname,
                Patronymic = worker.Patronymic,
                Name = worker.Name,
                EducationId = worker.EducationId,
                Email = worker.Email,
                PassportId = worker.PassportId,
                Phone = worker.Phone
            };
        }

        public static explicit operator Worker(WorkerApi worker)
        {
            return new Worker
            {
                Id = worker.Id,
                Surname = worker.Surname,
                Patronymic = worker.Patronymic,
                Name = worker.Name,
                EducationId = worker.EducationId,
                Email = worker.Email,
                PassportId = worker.PassportId,
                Phone = worker.Phone
            };
        }
    }
}
