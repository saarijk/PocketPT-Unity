using UnityEngine;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

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
}
