using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SouthZoneManager : MonoBehaviour
{
    public bool canSpawnBall;
    public List<Collider> balls;

    public static SouthZoneManager Instance;

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
