using System;
using System.Collections.Generic;
using System.Text;

namespace Nishaan.Solutions.Core.Maps
{
    public interface IUserMap
    {
        UserViewModel Create(UserViewModel viewModel);
        bool Update(UserViewModel viewModel);
        bool Delete(int id);
        List<UserViewModel> GetAll();
        UserViewModel DomainToViewModel(User domain);
        List<UserViewModel> DomainToViewModel(List<User> domain);
        User ViewModelToDomain(UserViewModel officeViewModel);
    }
}