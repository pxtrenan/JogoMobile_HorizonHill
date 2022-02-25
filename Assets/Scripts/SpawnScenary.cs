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
    public GameObject cenarioPrefab15;
    public GameObject cenarioPrefab16;
    public GameObject cenarioPrefab17;
    public GameObject cenarioPrefab18;
    public GameObject cenarioPrefab19;
    public GameObject cenarioPrefab20;
    public GameObject cenarioPrefab21;
    public GameObject cenarioPrefab22;
    public GameObject cenarioPrefab23;
    public GameObject cenarioPrefab24;
    public GameObject cenarioPrefab25;
    public GameObject cenarioPrefab26;
    public GameObject cenarioPrefab27;
    public GameObject cenarioPrefab28;
    public GameObject cenarioPrefab29;
    public GameObject cenarioPrefab30;
    
    public float rateSpawn;
    public float currentTime;
    private float y;

    private int number, temp = 0;
    
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
            number = Random.Range(1, 31);
           
            while (temp == number)
            {
                number = Random.Range(1, 31);
            }
       
            temp = number;

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
            if (number == 15)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab15) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 16)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab16) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
            if (number == 17)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab17) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 18)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab18) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
            if (number == 19)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab19) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 20)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab20) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
            if (number == 21)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab21) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 22)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab22) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
            if (number == 23)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab23) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
            if (number == 24)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab24) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 25)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab25) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
            if (number == 26)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab26) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 27)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab27) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
            if (number == 28)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab28) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }
            if (number == 29)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab29) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
            if (number == 30)
            {
                GameObject tempPrefab = Instantiate(cenarioPrefab30) as GameObject;
                tempPrefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            }





        }


    }

}

