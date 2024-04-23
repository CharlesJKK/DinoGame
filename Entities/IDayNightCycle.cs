using Microsoft.Xna.Framework;

namespace DinoGame.Entities
{
    public interface IDayNightCycle
    {
        int NightCount { get; }
        bool IsNight { get; }

        Color ClearColor { get; }

    }
}
