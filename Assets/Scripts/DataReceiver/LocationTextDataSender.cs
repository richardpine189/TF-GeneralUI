using System;
using UnityEngine;

public class LocationTextDataSender : MonoBehaviour
{
    public static Action<string, float> OnSendData;

    public void NotifyData(string text, float duration)
    {
        OnSendData?.Invoke(text, duration);
    }
}