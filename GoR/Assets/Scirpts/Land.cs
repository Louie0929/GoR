using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float speed = 10F;

    public GameObject coin;
    List<GameObject> objects;
    // Start is called before the first frame update
    void Start()
    {
        objects = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 0, speed * Time.deltaTime);
        if (transform.position.z <= -20)
        {
            setObjects();
            movetoFront();
        }
    }

    void movetoFront()
    {
        transform.position = new Vector3(0, 0, 180.0F);
    }

    void setObjects()
    {
        float r = Random.Range(0f, 1f);
        if (r <= 0.25)
        {

        }
        else
        {
            for (int i = 0; i < 8; i++)
            {
                float r1 = Random.Range(0f, 1f);
                GameObject obj;
                float posX = 0f;
                if (r1 <= 0.35f) // 35% bomb
                {

                }
                else // 65% coin
                {
                    obj = Instantiate(coin) as GameObject;
                    int r2 = Random.Range(-1, 2);
                    posX = 3.0f * r2;
                    obj.transform.localPosition = new Vector3(posX, 0.58f, -4.0f + i);
                    obj.transform.SetParent(this.transform);
                }
            }
        }
    }
}
