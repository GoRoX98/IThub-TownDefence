using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UI _ui;
    [SerializeField] private RecourcesFabric _rFabric;

    [Header("Balance")]
    [SerializeField] private int _startWheat;
    [SerializeField] private int _startGold;
    [SerializeField] private float _hireTime = 3f;
    [SerializeField] private int _workerCost = 10;

    private Wallet _wallet;
    private Queue<UnitType> _hireQueue = new();
    private float _hireTimer = 0f;

    public int GoldCount => _wallet.Gold;
    public int WheatCount => _wallet.Wheat;
    public int WorkerCount => _wallet.WorkerCount;
    public int WorkerCost => _workerCost;
    public float HireTimer => _hireTimer;
    public float HireTime => _hireTime;
    public float ResIncomeTime => _rFabric.TimeForIncome;
    public float ResIncomeTimer => _rFabric.IncomeTimer;

    private void Awake()
    {
        _wallet = new(_startWheat, _startGold, 0);
        _rFabric.Init(_wallet);
    }

    private void Update()
    {
        _ui.UpdateRecources();
        HireUnits();
    }

    private void HireUnits()
    {
        if (_hireQueue.Count > 0)
        {
            _hireTimer += Time.deltaTime;
            if (_hireTimer >= _hireTime)
            {
                UnitType unit = _hireQueue.Dequeue();
                if (unit == UnitType.Worker)
                {
                    _wallet.AddWorker(1);
                }

                _hireTimer = 0;
            }
        }
    }

    public void Hire(UnitType unit)
    {
        _hireQueue.Enqueue(unit);
    }
}

public enum UnitType
{
    Worker,
    Warrior
}
