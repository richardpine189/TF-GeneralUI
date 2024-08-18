using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private int PlayerLifeAmount;
    // Start is called before the first frame update
    void Start()
    {
        PlayerLifeAmount = 3;
        //TODO:Actualizar al iniciar
        gameObject.GetComponent<LifeDataSender>().NotifyData(PlayerLifeAmount);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            IncreaseLife();
        if(Input.GetKeyDown(KeyCode.D) && PlayerLifeAmount > 0)
            DecreaseLife();
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
