using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable : MonoBehaviour 
{

    public GameObject builder;
    public Builder component;
    public MeshRenderer model;

    void Start ()
    {
        builder = GameObject.Find("Main Camera");
        component = builder.gameObject.GetComponent(typeof(Builder)) as Builder;
        model = gameObject.GetComponent<MeshRenderer>();
    }

    void Update ()
    {
        if (component.enabled == false)
        {
            model.enabled = false;
        }
        else
        {
            model.enabled = true;
        }

        if (component._object == null)
        {
            model.enabled = false;
        }
        else
        {
            model.enabled = true;
        }
    }
}
