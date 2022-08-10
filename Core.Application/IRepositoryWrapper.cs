using Core.Application.Services.Addresses;
using Core.Application.Services.Students;
using Core.Application.Services.Teachers;

namespace Core.Application
{
    public interface IRepositoryWrapper
    {
        IStudentRepository Student { get; }
        ITeacherRepository Teacher { get; }
        IAddressRepository Address { get; }

        void Save();

    }
}