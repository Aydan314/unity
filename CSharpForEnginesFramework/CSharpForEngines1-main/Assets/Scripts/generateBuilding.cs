using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateBuilding : MonoBehaviour
{
    [SerializeField] GameObject[] buildings;
    [SerializeField] GameObject spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newBuilding = Instantiate(buildings[Random.Range(0,buildings.Length)]);
        Vector2 buildingPos;
        buildingPos.x = Mathf.Round(spawnPos.transform.position.x);
        buildingPos.y = Mathf.Round(spawnPos.transform.position.y);

        newBuilding.transform.position = buildingPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
