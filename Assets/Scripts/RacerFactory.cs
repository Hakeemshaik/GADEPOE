using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RacerFactory : MonoBehaviour
{
    public abstract GameObject CreateRacer(string racerType);
}
