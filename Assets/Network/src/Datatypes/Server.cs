

public class Server
{
    private string jsonData;

    Server() {
        jsonData = JSONUtils.getJsonStr("../Data/Servers.json");
    }
}
