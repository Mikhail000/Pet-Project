using UnityEngine;
using UnityEngine.UI;

public abstract class UnitsFactory
{
    public abstract BatonmansStack CreateBatonmanStack();

    public abstract JavelinthrowersStack CreateThrowersStack();

    public abstract ShamanStack CreateShamanStack();
}

