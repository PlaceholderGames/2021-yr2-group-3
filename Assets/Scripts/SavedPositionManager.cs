using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavedPositionManager //remembers players position per scene
{
    public static Dictionary<int, Vector3> savedPositions = new Dictionary<int, Vector3>();
}
