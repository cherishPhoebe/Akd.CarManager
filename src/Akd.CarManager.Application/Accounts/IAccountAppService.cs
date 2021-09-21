using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Akd.CarManager.Accounts
{
    public interface IAccountAppService :
        ICrudAppService<AccountDto,Guid, PagedAndSortedResultRequestDto, CreateUpdateAccountDto>
    {


    }
}
