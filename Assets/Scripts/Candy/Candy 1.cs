using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class Candy1 : MonoBehaviour
{

    [SerializeField] private Transform Spawn;
    [SerializeField] private GameObject SpawnObj;
    [SerializeField] private Vector2 SpawnVec;
    [SerializeField] private Rigidbody2D CandyA;
    [SerializeField] private Rigidbody2D CandyB;
    [SerializeField] private Rigidbody2D CandyC;
    [SerializeField] private Rigidbody2D CandyD;
    [SerializeField] private Rigidbody2D CandyE;
    [SerializeField] private Rigidbody2D CandyF;
    

    public float TimeLeft;
    public float Regen;
    public int RandomSpawn;
    public int RandomCandySpawn;
    public float RandomSpawnSpawn;

    // Start is called before the first frame update
    void Start()
    {
        RandomSpawn = Random.Range(0, 10);
        
    }
    public Text valueText;

    

    

    // Update is called once per frame
    void Update()
    {
        

        TimeLeft -= Time.deltaTime;
        
        if (TimeLeft < RandomSpawn)
        {
           RandomCandySpawn = Random.Range(1, 6);
            TimeLeft = 11;
            RandomSpawn = Random.Range(8, 10);
            RandomSpawnSpawn = Random.Range(-8, 8);
            SpawnVec = new Vector2(RandomSpawnSpawn, 5.7f);
            SpawnObj.transform.position = SpawnVec;
            if (RandomCandySpawn == 1 )
            {
                Rigidbody2D currentProj = Instantiate(CandyA, Spawn.position, Quaternion.identity);
                Destroy(currentProj.gameObject, 4);
            }
            if (RandomCandySpawn == 2)
            {
                Rigidbody2D currentProj = Instantiate(CandyB, Spawn.position, Quaternion.identity);
                Destroy(currentProj.gameObject, 4);
            }
            if (RandomCandySpawn == 3)
            {
                Rigidbody2D currentProj = Instantiate(CandyC, Spawn.position, Quaternion.identity);
                Destroy(currentProj.gameObject, 4);
            }
            if (RandomCandySpawn == 4)
            {
                Rigidbody2D currentProj = Instantiate(CandyD, Spawn.position, Quaternion.identity);
                Destroy(currentProj.gameObject, 4);
            }
            if (RandomCandySpawn == 5)
            {
                Rigidbody2D currentProj = Instantiate(CandyE, Spawn.position, Quaternion.identity);
                Destroy(currentProj.gameObject, 4);
            }
            if (RandomCandySpawn == 6)
            {
                Rigidbody2D currentProj = Instantiate(CandyF, Spawn.position, Quaternion.identity);
                Destroy(currentProj.gameObject, 4);
            }
        }
    }

    
}
