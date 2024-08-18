
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class LifeDataReceiverImage : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    private List<GameObject> _gameObjectsToHandle = new();
    private bool _isSetUp;
    private int count;
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
        Debug.Log(obj + " " + count);
        if (!_isSetUp)
        {
            for (int i = 0; i < obj; i++)
            {
                _gameObjectsToHandle.Add(Instantiate(_prefab, gameObject.transform));
            }
            count = obj;
            _isSetUp = true;
        }
        else
        {
            if (count < obj)
                _gameObjectsToHandle.Add(Instantiate(_prefab, gameObject.transform));
            else if (count > obj)
            {
                Destroy(_gameObjectsToHandle.Last());
                _gameObjectsToHandle.Remove(_gameObjectsToHandle.Last());
            }
            count = obj;
        }
    }

}
