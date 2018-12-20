using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerManager : MonoBehaviour
{
    public Transform originalObject;
    public Transform reflectedObject;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(("Ball")))
        {
            
           


            // Makes the reflected object appear opposite of the original object,
            // mirrored along the z-axis of the world
            //reflectedObject.position = Vector3.Reflect(originalObject.position, Vector3.right);
        }
    }
}
