using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetachFromParent : MonoBehaviour
{

    [SerializeField] GameObject referenceGameObject;
    private bool isAttached = true;
    public void Detach()
    {
        Debug.Log("Snapppp");
        if (!isAttached) return;
        isAttached = false;
        referenceGameObject.transform.parent = referenceGameObject.transform.parent.transform.parent;
    }
}
