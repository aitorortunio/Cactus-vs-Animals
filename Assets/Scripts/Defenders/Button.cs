using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Button : MonoBehaviour
{
    public abstract void OnMouseDown();

    public abstract void DestroyButton();
}
