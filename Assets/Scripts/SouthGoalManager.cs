using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SouthGoalManager : MonoBehaviour
{
    public int ballsLost;

    public static SouthGoalManager Instance;


    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }

        Instance = this;
    }

    void Start()
    {
        ballsLost = 0;
    }


    void Update()
    {
        if (ballsLost > 2)
        {
            Debug.Log("You Lost!");
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(("Ball")))
        {
            Destroy(other.gameObject, 0.5f);
            ballsLost += 1;
        }
    }
}
