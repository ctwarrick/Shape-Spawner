using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;

/// <summary>
/// Small class that sets the GazePointer on and hand rays off, so you can focus with gaze.
/// </summary>
public class InputManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PointerUtils.SetGazePointerBehavior(PointerBehavior.AlwaysOn);
        PointerUtils.SetHandRayPointerBehavior(PointerBehavior.AlwaysOff);
    }
}
