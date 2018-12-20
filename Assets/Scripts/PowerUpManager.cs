using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            float random = Random.Range(0f, 10f);

            if (random < 7)
            {
                InvertOpponentControllers(other);
            }
            else
            {
                BlockCamera();
            }
        }
    }


    private IEnumerator InvertOpponentControllers(Collider other)
    {
        if (other.GetComponent<BallManager>().owner == Owner.South)
        {
            ReferenceController.Instance.NorthLFlipper.GetComponent<FlipperManager>().inputName = "NorthRFlipper";
            ReferenceController.Instance.NorthRFlipper.GetComponent<FlipperManager>().inputName = "NorthLFlipper";

            yield return new WaitForSeconds(10);

            ReferenceController.Instance.NorthLFlipper.GetComponent<FlipperManager>().inputName = "NorthLFlipper";
            ReferenceController.Instance.NorthRFlipper.GetComponent<FlipperManager>().inputName = "NorthRFlipper";
        }
        else if (other.GetComponent<BallManager>().owner == Owner.North)
        {
            ReferenceController.Instance.SouthLFlipper.GetComponent<FlipperManager>().inputName = "SouthRFlipper";
            ReferenceController.Instance.SouthRFlipper.GetComponent<FlipperManager>().inputName = "SouthLFlipper";

            yield return new WaitForSeconds(10);

            ReferenceController.Instance.SouthLFlipper.GetComponent<FlipperManager>().inputName = "SouthLFlipper";
            ReferenceController.Instance.SouthRFlipper.GetComponent<FlipperManager>().inputName = "SouthRFlipper";
        }
    }


    private IEnumerator BlockCamera()
    {
        ReferenceController.Instance.CameraBlocker.SetActive(true);
        yield return new WaitForSeconds(5);
        ReferenceController.Instance.CameraBlocker.SetActive(false);

    }
}
