using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class LocationTextDataReceiver : MonoBehaviour
{
    [SerializeField] private GameObject textGo;
    [SerializeField] private CanvasGroup _canvasGroup;
    [SerializeField] private Text _text;
    private float _duration;

    private void Awake()
    {
        LocationTextDataSender.OnSendData += UpdateHUD;
    }

    private void OnDestroy()
    {
        LocationTextDataSender.OnSendData -= UpdateHUD;
    }
    void UpdateHUD(string text, float duration)
    {
        _duration = duration;
        _text.text = text;
        textGo.SetActive(false);
        ShowUpTheBanner();
    }

    private void ShowUpTheBanner()
    {
        textGo.SetActive(true);
        
        Sequence sq = DOTween.Sequence();
        sq.Append(_canvasGroup.DOFade(1f,_duration)).OnComplete(ShowOff);
    }

    private void ShowOff()
    {
        Sequence sq = DOTween.Sequence();
        sq.Append(_canvasGroup.DOFade(0f,_duration)).OnComplete(() => textGo.SetActive(false));
    }
}