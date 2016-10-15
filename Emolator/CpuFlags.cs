using System;

namespace Emolator
{
    [Flags]
    public enum CpuFlags : byte
    {
        Carry            = 1 << 0,
        Zero             = 1 << 1,
        InterruptDisable = 1 << 2,
        DecimalMode      = 1 << 3,
        Break            = 1 << 4,
        Unused           = 1 << 5,
        Overflow         = 1 << 6,
        Negative         = 1 << 7,
    }
}