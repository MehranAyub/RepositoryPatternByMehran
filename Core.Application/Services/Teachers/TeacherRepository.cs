using Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Services.Teachers
{
    public class TeacherRepository:ITeacherRepository
    {
        RepositoryContext _repositoryContext;

        public TeacherRepository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
    }
}
