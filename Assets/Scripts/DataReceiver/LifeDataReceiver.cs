using System;
using UnityEngine;
using UnityEngine.UI;

public class LifeDataReceiver : MonoBehaviour
{
    [SerializeField] private Text lifeText;
    void Awake()
    {
        LifeDataSender.OnDataNotify += UpdateHUD;
    }

    private void OnDestroy()
    {
        LifeDataSender.OnDataNotify -= UpdateHUD;
    }

    private void UpdateHUD(int obj)
    {
        lifeText.text = obj.ToString();
    }
}

