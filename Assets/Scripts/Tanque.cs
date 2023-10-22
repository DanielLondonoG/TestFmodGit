using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanque : MonoBehaviour
{
    public float velocidad;
    public float velRotacion;

    void Update()
    {
        transform.Translate(velocidad * Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.Rotate(0, velRotacion * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
    }
}
