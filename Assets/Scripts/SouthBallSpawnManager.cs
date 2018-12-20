using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SouthBallSpawnManager : MonoBehaviour
{
    public string inputName;
    public Rigidbody ball;

    void Start()
    {
        SpawnBall();
    }

    // Update is called once per frame
    void Update()
    {
        if (!SouthZoneManager.Instance.balls.Any())
        {
            if (Input.GetAxis(inputName) == 1)
            {
                SpawnBall();
            }
        }
        else
        {
            SouthZoneManager.Instance.balls.Clear();
        }
    }

    public void SpawnBall()
    {
        Vector3 position = new Vector3(9.833f, 0.848f, 5.231f);
        Rigidbody clone;
        clone = Instantiate(ball, position, Quaternion.identity);
        clone.velocity = new Vector3(-25f, 0f, 0f);
        SouthZoneManager.Instance.canSpawnBall = false;
    }
}
