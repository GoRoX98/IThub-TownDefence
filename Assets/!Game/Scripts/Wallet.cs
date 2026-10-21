public class Wallet
{
    private int _wheat;
    private int _gold;


    public int Wheat => _wheat;
    public int Gold => _gold;

    public Wallet(int wheat, int gold)
    {
        _wheat = wheat;
        _gold = gold;
    }

    public void AddGold(int gold)
    {
        _gold += gold;
    }

    public void RemoveGold(int gold)
    {
        _gold += gold;
    }

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

    public bool GetGold(int gold)
    {
        if (gold >= _gold)
        {
            _gold -= gold;
            return true;
        }

        return false;
    }

    public bool AnouthWheat(int wheat) => _wheat >= wheat;
    public bool AnouthGold(int gold) => _gold >= gold;
}
