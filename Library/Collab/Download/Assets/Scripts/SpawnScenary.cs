using UnityEngine;

public class SpawnScenary : MonoBehaviour
{

    public GameObject cenarioPrefab;
    public GameObject cenarioPrefab2;
    public GameObject cenarioPrefab3;
    public GameObject cenarioPrefab4;


    public float rateSpawn;
    public float currentTime;
    private float y;

    private int number;


    void Start()
    {

        currentTime = 0;
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= rateSpawn)
        {
            currentTime = 0;
            number = Random.Range(1, 5);
            if (number == 1)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 2)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab2) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
            if (number == 3)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab3) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
            if (number == 4)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab4) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
        }


    }

}

