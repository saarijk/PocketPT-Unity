using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UserWorkouts
{
    public User UserId { get; set; }
    //DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")
    public string Time { get; set; }
    //cardio or strength training; pulls fields for specific types
    //instead of general fields that apply to both
    public string WorkoutTypeID { get; set; }
    public string WorkoutID { get; set; }

}
