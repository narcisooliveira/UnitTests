namespace NetworkUtility.Ping;

public class NetworkService
{
    public string SendPing(string address)
    {
        return $"Success: Pinging... {address}";
    }

    public int GetPingTimeOut(int a, int b)
    {
        return a + b;
    }
}
