public class Wallet
{
    private int _wheat;
    private int _gold;
    private int _workerCount;


    public int Wheat => _wheat;
    public int Gold => _gold;
    public int WorkerCount => _workerCount;

    public Wallet(int wheat, int gold, int workers)
    {
        _wheat = wheat;
        _gold = gold;
        _workerCount = workers;
    }
#region Gold
    public void AddGold(int gold)
    {
        _gold += gold;
    }

    public void RemoveGold(int gold)
    {
        _gold += gold;
    }

    public bool GetGold(int gold)
    {
        if (gold >= _gold)
        {
            _gold -= gold;
            return true;
        }

        return false;
    }

    public bool AnouthGold(int gold) => _gold >= gold;
    #endregion
#region Wheat
    public void AddWheat(int wheat)
    {
        _wheat += wheat;
    }

    public void RemoveWheat(int wheat)
    {
        _wheat -= wheat;
    }

    public bool GetWheat(int wheat)
    {
        if (_wheat >= wheat)
        {
            _wheat -= wheat;
            return true;
        }

        return false;
    }

    public bool AnouthWheat(int wheat) => _wheat >= wheat;
    #endregion
#region Worker
    public void AddWorker(int worker)
    {
        _workerCount += worker;
    }

    public void RemoveWorker(int worker)
    {
        _workerCount -= worker;
    }
#endregion
}
