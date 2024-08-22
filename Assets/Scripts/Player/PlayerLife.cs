using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private int FullEnergy = 10;
    [SerializeField] private int currentEnergy = 2;
    [SerializeField] private int PlayerLifeAmount;

    private float time = 90;

    private float currentTime;
    public Image img;
    // Start is called before the first frame update
    void Start()
    {
        
        img.DOFade(1f, 2f);
        currentTime = time;
        PlayerLifeAmount = 3;
        //TODO:Actualizar al iniciar
        gameObject.GetComponent<LifeDataSender>().NotifyData(PlayerLifeAmount);
        gameObject.GetComponent<FillBarDataSender>().NotifyData(currentEnergy,FullEnergy);
        gameObject.GetComponent<TimeFillBarDataSender>().NotifyData(currentTime,time);
        gameObject.GetComponent<TimeTextDataSender>().NotifyData(currentTime,time, true);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
            gameObject.GetComponent<LocationTextDataSender>().NotifyData("Hola estoy en el nivel 1", 1f);
        if (Input.GetKeyDown(KeyCode.I))
            IncreaseLife();
        if(Input.GetKeyDown(KeyCode.D) && PlayerLifeAmount > 0)
            DecreaseLife();
        if (Input.GetKeyDown(KeyCode.A))
            IncreaseEnergy();
        if (Input.GetKeyDown(KeyCode.S))
            DecreaseEnergy();
        currentTime = time - Time.time;
        Debug.Log(currentTime);
        gameObject.GetComponent<TimeFillBarDataSender>().NotifyData(currentTime,time);
        gameObject.GetComponent<TimeTextDataSender>().NotifyData(currentTime,time, true);
    }

    private void DecreaseEnergy()
    {
        gameObject.GetComponent<FillBarDataSender>().NotifyData(currentEnergy++,FullEnergy);
    }

    private void IncreaseEnergy()
    {
        gameObject.GetComponent<FillBarDataSender>().NotifyData(currentEnergy--,FullEnergy);
    }

    public void IncreaseLife()
    {
        PlayerLifeAmount++;
        gameObject.GetComponent<LifeDataSender>().NotifyData(PlayerLifeAmount);
    }

    private void DecreaseLife()
    {
        PlayerLifeAmount--;
        gameObject.GetComponent<LifeDataSender>().NotifyData(PlayerLifeAmount);
    }
}
