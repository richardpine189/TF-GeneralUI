using System;
using UnityEngine;

public class LifeDataSender : MonoBehaviour
{
    public static Action<int> OnDataNotify;
    
    public void NotifyData(int data)
    {
        OnDataNotify?.Invoke(data);
    }
}
