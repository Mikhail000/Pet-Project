using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalEventBus
{
    public static readonly EventBus CameraBus = new EventBus();
    public static readonly EventBus InputSystemBus = new EventBus();
}
