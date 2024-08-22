using UnityEngine;
using UnityEngine.UI;

public class FillBarDataReceiverImage : MonoBehaviour
{
    [SerializeField] private Image fillImage;
    private bool _isSetUp;
    void Awake()
    {
        FillBarDataSender.OnDataNotify += UpdateHUD;
    }
    private void OnDestroy()
    {
        FillBarDataSender.OnDataNotify -= UpdateHUD;
    }
    private void UpdateHUD(int progress, int full)
    {
        float factor = progress / (float)full;
        Debug.Log(factor);
        fillImage.fillAmount = factor;
        if (!_isSetUp)
        {
            
            _isSetUp = true;
        }
        
    }

}
