using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RegisterUser
{
    public long UserID { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public int YearOfBirth { get; set; }
    public int Height { get; set; }
    public bool IsActive { get; set; }
}
