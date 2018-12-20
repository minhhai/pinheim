using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCatcher : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Starting");
        Debug.Log("name: " + this.gameObject.name);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(("Ball")))
        {
            Destroy(other.gameObject);
            //if (other.attachedRigidbody.position.x > 0)
            //{
            //    NorthZoneManager.Instance.canSpawnBall = true;
            //}
            //else
            //{
            //    SouthZoneManager.Instance.canSpawnBall = true;
            //}
        }
    }

}
