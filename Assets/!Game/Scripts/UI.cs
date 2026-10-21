using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private const string c_wheatText = "Пшеница: ";
    private const string c_goldText = "Золото: ";
    private const string c_workersText = "Рабочие: ";

    [SerializeField] private GameManager _gameManager;

    [Header("Info")]
    [SerializeField] private TMP_Text _wheatText;
    [SerializeField] private TMP_Text _goldText;
    [SerializeField] private TMP_Text _workersText;

    [Header("Timers")]
    [SerializeField] private Image _resTimerImage;
    [SerializeField] private Image _hireTimerImage;

    [Header("Buttons")]
    [SerializeField] private Button _btnHireWorker;

    private int _wheat => _gameManager.WheatCount;
    private int _gold => _gameManager.GoldCount;
    private int _workers => _gameManager.WorkerCount;
    private int _workerCost => _gameManager.WorkerCost;
    private float _resTimer => _gameManager.ResIncomeTimer;
    private float _resBaseTime => _gameManager.ResIncomeTime;
    private float _hireBaseTime => _gameManager.HireTime;
    private float _hireTimer => _gameManager.HireTimer;

    public void UpdateRecources()
    {
        _wheatText.text = c_wheatText + _wheat;
        _goldText.text = c_goldText + _gold;
        _workersText.text = c_workersText + _workers;
    }

    private void Update()
    {
        UpdateHireWorkerButton();
        UpdateTimers();
    }

    private void UpdateTimers()
    {
        if (_hireTimer > 0)
            _hireTimerImage.fillAmount = _hireTimer / _hireBaseTime;
        else
            _hireTimerImage.fillAmount = 1;

        _resTimerImage.fillAmount = 1 - _resTimer / _resBaseTime;
    }

    private void UpdateHireWorkerButton()
    {
        if (_workerCost <= _wheat)
            _btnHireWorker.interactable = true;
        else
            _btnHireWorker.interactable = false;
    }

    public void HireWorker() => _gameManager.Hire(UnitType.Worker);
    public void HireWarrior() => _gameManager.Hire(UnitType.Warrior);
}
