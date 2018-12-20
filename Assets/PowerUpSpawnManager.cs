using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PowerUpSpawnManager : MonoBehaviour
{
    public GameObject PowerUp;
    public List<Collider> PowerUps;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!PowerUps.Any())
        {
            SpawnPowerUp();
        }
        else
        {
            PowerUps.Clear();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            PowerUps.Add(other);
        }
    }


    public IEnumerator SpawnPowerUp()
    {
        yield return  new WaitForSeconds(10);
        float random = Random.Range(0, 10);

        if (random > 5)
        {
            Vector3 position = gameObject.transform.position;
            GameObject clone = Instantiate(PowerUp, position, Quaternion.identity);
        }
    }
}
