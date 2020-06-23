using System;
using Training.Data.Domain;
using System.Collections.Generic;
using System.Text;

namespace Training.Data.EF
{
    public class StudioRepository :  Repository<Studio, Guid>, IStudioRepository
    {
        public StudioRepository(UnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
