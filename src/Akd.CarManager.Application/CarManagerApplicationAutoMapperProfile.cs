using Akd.CarManager.Accounts;
using AutoMapper;

namespace Akd.CarManager
{
    public class CarManagerApplicationAutoMapperProfile : Profile
    {
        public CarManagerApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Account, AccountDto>();
            CreateMap<CreateUpdateAccountDto,Account>();

        }
    }
}
