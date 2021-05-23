using System.Threading.Tasks;
using TitleInfoClient.DTOs;

namespace TitleInfoClient.DataServices
{
    public interface ITitlesDataService
    {
         Task<TitleInfoSearchDTO[]> GetAllTitles();
    }
}