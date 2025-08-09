using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/muni.indev"),
                Headers =
    {
        { "x-rapidapi-key", "0d0bd8c37emsh5649996b48d478ep1df91ejsn533cd4ee9612" },
        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto ResultInstagramFollowersDto = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.Followers = ResultInstagramFollowersDto.followers;
                ViewBag.Following = ResultInstagramFollowersDto.following;
                //return View(ResultInstagramFollowersDto);
            }


            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter288.p.rapidapi.com/user/details?username=OguzhanUgur"),
                Headers =
    {
        { "x-rapidapi-key", "0d0bd8c37emsh5649996b48d478ep1df91ejsn533cd4ee9612" },
        { "x-rapidapi-host", "twitter288.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
                ViewBag.v1 = resultTwitterFollowersDto.data.user.result.legacy.followers_count;
                ViewBag.v2 = resultTwitterFollowersDto.data.user.result.legacy.friends_count;
            }
            return View();
        }
    }
}
