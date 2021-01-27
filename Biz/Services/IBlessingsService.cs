using System.Threading.Tasks;
using MicroBlessingsApi.Biz.Models.Core;

namespace MicroBlessingsApi.Biz.Services
{
    public interface IBlessingsService
    {
        Task<Blessing> GetBlessing(ModelId<Blessing> blessingId);
    }
}