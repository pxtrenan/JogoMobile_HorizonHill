using UnityEngine;

public class SpawnScenary : MonoBehaviour
{

    public GameObject cenarioPrefab;
    public GameObject cenarioPrefab2;
    public GameObject cenarioPrefab3;
    public GameObject cenarioPrefab4;
    public GameObject cenarioPrefab5;
    public GameObject cenarioPrefab6;
    public GameObject cenarioPrefab7;
    public GameObject cenarioPrefab8;
    public GameObject cenarioPrefab9;
    public GameObject cenarioPrefab10;
    public GameObject cenarioPrefab11;
    public GameObject cenarioPrefab12;
    public GameObject cenarioPrefab13;
    public GameObject cenarioPrefab14;



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
            number = Random.Range(1, 15);

            Debug.Log(number);
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
            if (number == 5)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab5) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 6)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab6) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
            if (number == 7)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab7) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
            if (number == 8)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab8) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
            if (number == 9)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab9) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 10)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab10) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
            if (number == 11)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab11) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
        
        if (number == 12)
        {
            GameObject tempPrefab = Instantiate(cenarioPrefab12) as GameObject;
            tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        if (number == 13)
        {
            GameObject tempPrefab = Instantiate(cenarioPrefab13) as GameObject;
            tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        }
        if (number == 14)
        {
            GameObject tempPrefab = Instantiate(cenarioPrefab14) as GameObject;
            tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        }



    }


    }

}

