using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NorthBallSpawnManager : MonoBehaviour
{
    public string inputName;
    public GameObject ball;

    void Start()
    {
        SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        if (!NorthZoneManager.Instance.balls.Any())
        {
            if (Input.GetAxis(inputName) == 1)
            {
                SpawnBall();
            }
        }
        else
        {
            NorthZoneManager.Instance.balls.Clear();
        }
    }

    public void SpawnBall()
    {
        Vector3 position = new Vector3(-9.833f, 0.848f, -5.231f);
        GameObject clone = Instantiate(ball, position, Quaternion.identity);

        Rigidbody rb = clone.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.velocity = new Vector3(25f, 0f, 0f);
        }

        NorthZoneManager.Instance.canSpawnBall = false;
    }
}
