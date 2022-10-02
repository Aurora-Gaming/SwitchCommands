using TShockAPI;

namespace SwitchCommands;

public class SwitchPos
{
    public int X = 0, Y = 0;

    public SwitchPos()
    {
        X = 0;
        Y = 0;
    }

    public SwitchPos(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return "X: {0}, Y: {1}".SFormat(X, Y);
    }

    public override bool Equals(object obj)
    {
        if (obj is not SwitchPos check) return false;

        return check.X == X && check.Y == Y;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
