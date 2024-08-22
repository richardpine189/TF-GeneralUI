using UnityEngine;
using UnityEngine.UI;

public class TimeTextDataReceiver : MonoBehaviour
{
    [SerializeField] private Text _timeText; 
    private string _formatedTime;
    private void Awake()
    {
        TimeTextDataSender.OnDataNotify += UpdateHUD;
    }

    private void OnDestroy()
    {
        TimeTextDataSender.OnDataNotify += UpdateHUD;
    }

    private void UpdateHUD(float progress, float maxTime, bool isFormated)
    {
        if (isFormated)
        {
            int minutes = Mathf.FloorToInt(progress / 60);
            int seconds = Mathf.FloorToInt(progress % 60);
            _formatedTime = $"{minutes}:{seconds}";
            _timeText.text = _formatedTime;
        }
    }
}