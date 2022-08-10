using Core.Application.Services.Addresses;
using Core.Application.Services.Students;
using Core.Application.Services.Teachers;
using Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application
{
    public class RepositoryWrapper:IRepositoryWrapper
    {
        private RepositoryContext _repositoryContext;
        private IStudentRepository _studentRepository;
        private ITeacherRepository _teacherRepository;
        private IAddressRepository _addressRepository;

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public IStudentRepository Student
        {
            get {
                if (_studentRepository == null)
                {
                    _studentRepository = new StudentRepository(_repositoryContext);
                }
                return _studentRepository; 
            }
        }
        public ITeacherRepository Teacher
        {
            get
            {
                if (_teacherRepository == null)
                {
                    _teacherRepository  = new TeacherRepository(_repositoryContext);
                }
                return _teacherRepository;
            }
        }
        public IAddressRepository Address
        {
            get
            {
                if (_addressRepository == null)
                {
                    _addressRepository = new AddressRepository(_repositoryContext);
                }
                return _addressRepository;
            }
        }


        public void Save()
        {
            _repositoryContext.SaveChanges();
        }

      
    }
}
