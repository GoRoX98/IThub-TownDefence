using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UI _ui;
    [SerializeField] private RecourcesFabric _rFabric;

    [Header("Balance")]
    [SerializeField] private int _startWheat;
    [SerializeField] private int _startGold;

    private Wallet _wallet;

    private void Awake()
    {
        _wallet = new(_startWheat, _startGold);
        _rFabric.Init(_wallet);
    }

    private void Update()
    {
        _ui.UpdateRecources(_wallet.Wheat, _wallet.Gold);
    }
}
