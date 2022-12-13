using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StrengthTraining
{
    public long StrengthTrainingId { get; set; }
    public BodyPart MuscleName { get; set; }
    public int StrengthTrainingWeight { get; set; }
    public int StrengthTrainingReps { get; set; }
    public int StrengthTrainingSets { get; set; }
}
