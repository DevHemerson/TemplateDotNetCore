using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Application.ViewModels;

namespace Template.Application.Interfaces
{
    public interface IUserService
    {
        public List<UserViewModel> Get();

        bool Post(UserViewModel userViewModel);

        UserViewModel GetById(string id);

        bool Put(UserViewModel userViewModel);
    }
}
