using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NorthZoneManager : MonoBehaviour
{
    public bool canSpawnBall;
    public List<Collider> balls;

    public static NorthZoneManager Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }

        Instance = this;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag(("Ball")))
        {
            balls.Add(other);
        }
    }
}
