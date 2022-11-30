using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaDesplazamiento : MonoBehaviour
{
    public float valocidadM;
    public float valocidadR;
    private Animator animacion;
    public float x, y;
    // Start is called before the first frame update
    void Start()
    {
        valocidadM = 5f;
        valocidadR = 200f;
        animacion = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        transform.Rotate(0, x * Time.deltaTime * valocidadR, 0);
        transform.Translate(0, 0, y * Time.deltaTime * valocidadM);

        animacion.SetFloat("VelocidadX", x);
        animacion.SetFloat("VelocidadY", y);
    }
}
