using System;
using UnityEngine;

public class TimeFillBarDataSender : MonoBehaviour
{
    public static Action<float, float> OnDataNotify;
    
    /*public void NotifyData(int data)
    {
        OnDataNotify?.Invoke(data);
    }*/

    public void NotifyData(float progress, float full)
    {
        OnDataNotify?.Invoke(progress, full);
    }
}
