using Newtonsoft.Json;
using TShockAPI;

namespace SwitchCommands;
public class Database
{
    public static string databasePath = Path.Combine(TShock.SavePath, "switchcommands.json");

    public Dictionary<string, CommandInfo> switchCommandList = new();

    public void Write(string path)
    {
        File.WriteAllText(path, JsonConvert.SerializeObject(this, Formatting.Indented));
    }

    public static Database Read(string path)
    {
        if (!File.Exists(path))
            return new Database();
        return JsonConvert.DeserializeObject<Database>(File.ReadAllText(path));
    }
}
