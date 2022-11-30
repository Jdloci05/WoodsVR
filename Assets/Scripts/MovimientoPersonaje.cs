using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    private Animator anie;
    public float x, y;

    // Start is called before the first frame update
    void Start()
    {

        anie = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKey("w"))
        //{
        //    transform.position += new Vector3(0f, 0f, transform.position.z * movementSpeed * Time.deltaTime);
        //}

        //if (Input.GetKey("s"))
        //{
        //    transform.position += new Vector3(0f, 0f, -(transform.position.z * movementSpeed * Time.deltaTime));
        //}

        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0, 0, y * Time.deltaTime * movementSpeed);

        anie.SetFloat("VelX", x);
        anie.SetFloat("VelY", y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anie.SetBool("Saludar", true);
        }
        else
        {
            anie.SetBool("Saludar", false);
        }

    }
}


