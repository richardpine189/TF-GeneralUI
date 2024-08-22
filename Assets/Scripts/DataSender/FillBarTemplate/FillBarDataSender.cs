using System;
using UnityEngine;

public class FillBarDataSender : MonoBehaviour
{
    public static Action<int, int> OnDataNotify;
    
    /*public void NotifyData(int data)
    {
        OnDataNotify?.Invoke(data);
    }*/

    public void NotifyData(int progress, int full)
    {
        OnDataNotify?.Invoke(progress, full);
    }
}
