using System;

namespace Systems.Pause
{
    public interface IPauseService
    {
        event Action<bool> OnChanged;
        bool IsPaused { get; }
    }
}