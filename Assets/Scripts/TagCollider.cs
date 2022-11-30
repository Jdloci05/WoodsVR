using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagCollider : MonoBehaviour
{
    public Object Demogorgon { get; private set; }

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)

    {
        if(other.tag == "Axe")
        {
            Destroy(Demogorgon);
        }
    }
}
