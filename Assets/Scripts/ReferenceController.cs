using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceController : MonoBehaviour
{
    public static ReferenceController Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
            return;
        }

        Instance = this;
    }

    [SerializeField]
    public GameObject NorthLFlipper;

    [SerializeField]
    public GameObject NorthRFlipper;

    [SerializeField]
    public GameObject SouthLFlipper;

    [SerializeField]
    public GameObject SouthRFlipper;

    [SerializeField]
    public GameObject CameraBlocker;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
