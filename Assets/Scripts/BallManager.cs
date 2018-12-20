using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Text text;
    public Owner owner;


    public Rigidbody rb;
    void Start()
    {
        if (rb == null)
            rb = GetComponent<Rigidbody>();

        owner = Owner.Unclaimed;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.x > 0)
        {
            rb.AddForce(10f, 0f, 0f);

        }
        else
        {
            rb.AddForce(-10, 0f, 0f);
        }
    }
}

public enum Owner
{
    Unclaimed = 0,
    North = 1,
    South = 2
}
