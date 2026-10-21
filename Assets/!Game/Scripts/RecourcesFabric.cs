using System.ComponentModel;
using UnityEngine;

public class RecourcesFabric : MonoBehaviour
{
    [Header("Base settings")]
    [SerializeField] private float _timeForIncome = 3f;
    [SerializeField] private int _baseWheatIncome = 5;
    [SerializeField] private int _baseGoldIncome = 0;

    [Header("Balance")]
    [SerializeField] private int _wheatIncomePerWorker = 5;

    private bool _isInit = false;
    private Wallet _wallet;

    private float _timer = 0;

    public float TimeForIncome => _timeForIncome;
    public float IncomeTimer => _timer;

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
            int wheatIncome = _baseWheatIncome + _wheatIncomePerWorker * _wallet.WorkerCount;

            _wallet.AddGold(_baseGoldIncome);
            _wallet.AddWheat(wheatIncome);
            _timer = 0;
        }
    }
}
