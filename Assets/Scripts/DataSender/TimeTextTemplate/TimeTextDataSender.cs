using System;
using UnityEngine;

public class TimeTextDataSender : MonoBehaviour
{
    public static Action<float, float, bool> OnDataNotify;
    
    public void NotifyData(float progress, float full, bool isFormated)
    {
        OnDataNotify?.Invoke(progress, full, isFormated);
    }
}