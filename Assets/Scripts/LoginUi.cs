using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginUi : MonoBehaviour
{
    [SerializeField] private LoginManager loginManager;
    [SerializeField] private InputField nameField;
    [SerializeField] private InputField ageField;
    [SerializeField] private InputField weightField;
    [SerializeField] private InputField heightField;
    [SerializeField] private InputField loginField;
    [SerializeField] private Text profileInfo;

    public void Create()
    {
        User user = new User
        {
            Name = nameField.text,
            Age = int.Parse(ageField.text),
            Weight = int.Parse(weightField.text),
            HeightCm = int.Parse(heightField.text)
        };
        loginManager.CreateUser(user);
    }

    public async void GetUser()
    {
        int id = int.Parse(loginField.text);
        var user = loginManager.GetUser(id).Result;
        profileInfo.text = $"Name: {user.Name}\nAge: {user.Age}\nWeight: {user.Weight}\nHeight: {user.HeightCm}cm";
    }
}
