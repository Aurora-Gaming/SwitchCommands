using TShockAPI;

namespace SwitchCommands;

public static class StringManipulator
{
    public static string ReplaceTags(this string s, TSPlayer player)
    {
        List<string> response = s.Split(' ').ToList();

        for (int x = response.Count - 1; x >= 0; x--)
            if (response[x] == "$name")
                response[x] = "\"" + player.Name + "\"";

        return string.Join(" ", response);
    }
}
