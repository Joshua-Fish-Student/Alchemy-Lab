using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyobject : MonoBehaviour
{
    private Rigidbody rigidbody;
    public float multiplier;

    void Start(){
        rigidbody = GetComponent<Rigidbody>();
    }

    public void fly(){
        Vector3 position = Vector3.up * multiplier;
        rigidbody.AddForce(position, ForceMode.Acceleration);
    }
}