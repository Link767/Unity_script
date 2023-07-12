using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjForCoroutines : MonoBehaviour
{
    public GameObject[] obj;

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Q))
            StartCoroutine(Create3DObj(2f));
    }

    private void Create()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject newObject = Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(12f, -15f, 40f));
        }
        //GameObject newObject = Instantiate(obj, new Vector3(-10, 1, 7), Quaternion.Euler(12f, -15f, 40f)) as GameObject;
        //newObject.GetComponent<Transform>().position = new Vector3(-10, 5, 0); 
    }

    private int RandomNumber()
    {
        return UnityEngine.Random.Range(0, 10);
    }

    private IEnumerator Create3DObj(float StartCurot) 
    {
        yield return new WaitForSeconds(StartCurot);
        Create();
    }
}
