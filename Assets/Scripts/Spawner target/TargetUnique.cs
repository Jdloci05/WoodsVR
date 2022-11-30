using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetUnique : MonoBehaviour
{

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Arrow")
        {
            
            Destroy(gameObject);
        }
    }
}
