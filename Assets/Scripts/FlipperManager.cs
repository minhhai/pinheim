using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperManager : MonoBehaviour
{
    public float restPosition = 0f;
    public float pressedPosition = 45f;
    public float hitStrenght = 8000f;
    public float flipperDamper = 150f;
    public HingeJoint hinge;
    public string inputName;
    public Owner owner;

    public JointSpring spring;

    void Start()
    {

        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true;
        //spring = new JointSpring();
        //spring.spring = hitStrenght;
        //spring.damper = flipperDamper;
        //hinge.spring = spring;
        //hinge.useLimits = true;

    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;

        if (Input.GetAxis(inputName) == 1)
        {
            //rb.AddTorque(0f, -100f, 0f, ForceMode.Impulse);
            spring.targetPosition = pressedPosition;
            //Debug.Log("Pressed a!");
        }
        else
        {
            spring.targetPosition = restPosition;
        }

        hinge.spring = spring;
        hinge.useLimits = true;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Ball"))
        {
            other.transform.gameObject.GetComponent<BallManager>().owner = owner;
        }
    }
}
