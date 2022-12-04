using UnityEngine;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

public class LoginManager : MonoBehaviour
{
    private static string url = "https://localhost:5001/api/Users";
    public async void CreateUser(User user)
    {
        var json = JsonConvert.SerializeObject(user);
        var data = new StringContent(json, Encoding.UTF8, "application/json");
        using var client = new HttpClient();
        var response = await client.PostAsync(url, data);
        var result = await response.Content.ReadAsStringAsync();
        Debug.Log(response.IsSuccessStatusCode);
    }   

    public async Task<User> GetUser(int id)
    {
        var newUrl = $"{url}/{id}";
        using var client = new HttpClient();
        var response = client.GetAsync(newUrl);
        Debug.Log(await response.Result.Content.ReadAsStringAsync());
        var user = JsonConvert.DeserializeObject<User>(await response.Result.Content.ReadAsStringAsync());
        return user;
    }
}
