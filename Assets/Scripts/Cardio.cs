using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Cardio
{
    public long CardioId { get; set; }
    public string CardioName { get; set; }
    public int CardioDuration { get; set; }
    public int CardioDistance { get; set; }
    public double CardioKcal { get; set; }
}
