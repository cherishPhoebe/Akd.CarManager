using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Akd.CarManager.Accounts
{
    public class AccountAppService : CrudAppService<
            Account, //The Book entity
            AccountDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateAccountDto>, IAccountAppService
    {
        public AccountAppService(IRepository<Account, Guid> repository) : base(repository)
        {
        }
    }
}
