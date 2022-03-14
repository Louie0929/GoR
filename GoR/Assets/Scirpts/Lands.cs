using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lands : MonoBehaviour
{
    public GameObject land;
    List<GameObject> lands;
    [Header("Set in Inspector")]
    public float speed = 10f;
    public float startPosZ = -20f;
    // Start is called before the first frame update
    void Start()
    {
        lands = new List<GameObject>();
        for(int i = 0; i < 11; i++)
        {
            GameObject newLand = Instantiate(land) as GameObject;
            newLand.transform.localPosition = new Vector3(0, 0, -20 + i * 20);
            newLand.transform.SetParent(this.transform);
            lands.Add(newLand);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
