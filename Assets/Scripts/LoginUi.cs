using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class LoginUi : MonoBehaviour
{
    [SerializeField] private LoginManager loginManager;
    [SerializeField] private InputField nameField;
    [SerializeField] private InputField ageField;
    [SerializeField] private InputField weightField;
    [SerializeField] private InputField heightField;
    [SerializeField] private InputField loginField;
    [SerializeField] private Text profileInfo;
    [SerializeField] private Text bmiCount;

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

    public void GetUser()
    {
        int id = int.Parse(loginField.text);
        var user = loginManager.GetUser(id).Result;
        //double bmi = (user.Weight / ((user.HeightCm * 100) * (user.HeightCm * 100)));
        //user.Bmi = Convert.ToInt32(bmi);
        profileInfo.text = $"PROFILE INFO\n\nName: {user.Name}\nAge: {user.Age}\nWeight: {user.Weight}" +
            $"\nHeight: {user.HeightCm} cm\nId: {user.Id}";
    }

    public void CountBmi()
    {
        int id = int.Parse(loginField.text);
        var user = loginManager.GetUser(id).Result;
        double weight = Convert.ToDouble(user.Weight);
        double height = Convert.ToDouble(user.HeightCm);
        double bmi = (weight / height / height) * 10000;
        bmi = Math.Round(bmi, 2);
        Debug.Log(bmi);
        bmiCount.text = Convert.ToString(bmi);
    }
}
