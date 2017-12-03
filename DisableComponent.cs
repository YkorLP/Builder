using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableComponent : MonoBehaviour {

    [Header("Compenent")]
    public Builder component;

    void Start ()
    {
        component = gameObject.GetComponent(typeof(Builder)) as Builder;
    }

    void Update ()
    {
        if (Input.GetKeyDown("b"))
        {
            component.enabled = !component.enabled;
        }
    }
}
