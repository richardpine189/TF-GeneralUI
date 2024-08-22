using UnityEngine;
using UnityEngine.UI;

public class TimeFillBarDataReceiverImage : MonoBehaviour
{
    [SerializeField] private Image fillImage;
    private bool _isSetUp;
    void Awake()
    {
        TimeFillBarDataSender.OnDataNotify += UpdateHUD;
    }
    private void OnDestroy()
    {
        TimeFillBarDataSender.OnDataNotify -= UpdateHUD;
    }
    private void UpdateHUD(float progress, float full)
    {
        float factor = progress / full;
        //Debug.Log(progress);
        fillImage.fillAmount = factor;
        if (!_isSetUp)
        {
            
            _isSetUp = true;
        }
        
    }

}
