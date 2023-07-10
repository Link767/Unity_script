using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjekt : MonoBehaviour
{
    public GameObject[] obj;

    private void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject newObject = Instantiate(obj[Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(12f, -15f, 40f));
        }
        //GameObject newObject = Instantiate(obj, new Vector3(-10, 1, 7), Quaternion.Euler(12f, -15f, 40f)) as GameObject;
        //newObject.GetComponent<Transform>().position = new Vector3(-10, 5, 0); 
    }
    
    private int RandomNumber()
    {
        return Random.Range(0, 10);
    }
}
