using System.ComponentModel;
using UnityEngine;

public class RecourcesFabric : MonoBehaviour
{
    [SerializeField] private float _timeForIncome = 3f;
    [SerializeField] private int _baseWheatIncome = 5;
    [SerializeField] private int _baseGoldIncome = 0;

    private bool _isInit = false;
    private Wallet _wallet;

    private float _timer = 0;

    public void Init(Wallet wallet)
    {
        if (!_isInit)
        {
            _wallet = wallet;
            _isInit = true;
        }
    }

    private void Update()
    {
        _timer += Time.deltaTime;

        if (_timer > _timeForIncome)
        {
            _wallet.AddGold(_baseGoldIncome);
            _wallet.AddWheat(_baseWheatIncome);
            _timer = 0;
        }
    }
}
