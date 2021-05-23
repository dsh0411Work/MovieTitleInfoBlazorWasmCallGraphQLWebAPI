using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using TitleInfoClient.DataServices;
using TitleInfoClient.DTOs;

namespace TitleInfoClient.Pages
{
    public partial class FetchData
    {
        [Inject]
        ITitlesDataService TitlesGraphQLService { get; set; }

        [Inject]
        IJSRuntime JSRuntime { get; set; }
        private TitleInfoSearchDTO[] titles;

        protected override async Task OnInitializedAsync()
        {
            titles = await TitlesGraphQLService.GetAllTitles();
            await JSRuntime.InvokeAsync<object>("TestDataTablesAdd", "#titles");
            //titles = await TitlesGraphQLService.GetAllTitles();
            //titles = await Http.PostAsJsonAsync<TitleInfoSearchDTO[]>("http://localhost:5000/graphql/");
        }



    }
}