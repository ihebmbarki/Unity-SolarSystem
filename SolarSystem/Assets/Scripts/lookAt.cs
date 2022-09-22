using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAt : MonoBehaviour
{
    static public GameObject target;

    // Update is called once per frame
    void Update()
    {
        if (target) transform.LookAt(target.transform);
    }
}
