using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UIText : MonoBehaviour
{
    public GameObject UIObject;

    private void Awake()
    {
        UIObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            UIObject.SetActive(true);
            StartCoroutine(WithForSec());
        }
    
        IEnumerator WithForSec()
        {
            yield return new WaitForSeconds(3);
            Destroy(UIObject);
            Destroy(gameObject);
        }
    }
}
