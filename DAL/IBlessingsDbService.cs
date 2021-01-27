using System.Threading.Tasks;
using MicroBlessingsApi.Biz.Models.Core;

namespace MicroBlessingsApi.DAL
{
    public interface IBlessingsDbService
    {
        Task<Blessing> GetBlessing(ModelId<Blessing> blessingId);
    }
}