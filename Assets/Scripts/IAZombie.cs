using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAZombie : MonoBehaviour
{
    public Transform personajeAseguir;
    public Animator anim;
    public float distanciaDeDeteccion;
    public float velocidadCaminando;
    public float velocidadCorriendo;

    private NavMeshAgent agente;
    public Transform[] recorrido;
    private int indiceRecorrido;
    Vector3 objetivo;

    void Start()
    {
        personajeAseguir = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        agente = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        anim.SetBool("PuedePerseguir", false);
        anim.SetBool("Caminar", true);
        hacerRecorrido();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position,personajeAseguir.position) < distanciaDeDeteccion)
        {
            agente.speed = velocidadCorriendo;
            anim.SetBool("Caminar", false);
            anim.SetBool("PuedePerseguir", true);
            agente.destination = personajeAseguir.position;
        }
        else
        {
            anim.SetBool("PuedePerseguir", false);
            anim.SetBool("Caminar", true);

            if (Vector3.Distance(transform.position, objetivo) > 1)
            {
                agente.speed = velocidadCaminando;
                hacerRecorrido();
            }
            else if(Vector3.Distance(transform.position, objetivo) < 1)
            {
                actualizarIndiceRecorrido();
                hacerRecorrido();
            }
        }
    }

    public void actualizarIndiceRecorrido()
    {
        indiceRecorrido++;

        // Si el índice llega al último elemento del array, resetea el valor del índice.
        if (indiceRecorrido == recorrido.Length)
        {
            indiceRecorrido = 0;
        }
    }

    public void hacerRecorrido()
    {
        //anim.SetBool("PuedePerseguir", true);
        // Obtenemos la posición de un elemento del arreglo de puntos 'recorrido'
        objetivo = recorrido[indiceRecorrido].position;
        agente.SetDestination(objetivo);
    }
}


