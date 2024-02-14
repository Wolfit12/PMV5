using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer8 : MonoBehaviour
{
    public GameObject fondo1;
    public GameObject fondo2;
    public GameObject fondo3;
    public float velocidad1 = 2.19f;
    public float velocidad2 = 3.2f;
    public float velocidad3 = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreaFondo", 0f, 7f);
        InvokeRepeating("CreaFondo2", 0f, 4f);
        InvokeRepeating("CreaFondo3", 0f, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        DestruyeFondo();
    }

    void CreaFondo()
    {
        var position = new Vector3(0, 15, 0);
        Instantiate(fondo1, position, Quaternion.identity);
        Debug.Log("fondo instanciado1");
    }

    void CreaFondo2()
    {
        var position = new Vector3(0, 15, 0);
        Instantiate(fondo2, position, Quaternion.identity);
        Debug.Log("fondo instanciado2");
    }

    void CreaFondo3()
    {
        var position = new Vector3(5, 15, 0);
        Instantiate(fondo3, position, Quaternion.identity);
        Debug.Log("fondo instanciado3");
    }

    void DestruyeFondo()
    {
        GameObject[] fondos1 = GameObject.FindGameObjectsWithTag("Fondo1");
        foreach (GameObject obj in fondos1)
        {
            obj.transform.position += Vector3.down * velocidad1 * Time.deltaTime;
            if (obj.transform.position.y > 20f)
            {
                Destroy(obj);
            }
        }

        GameObject[] fondos2 = GameObject.FindGameObjectsWithTag("Fondo2");
        foreach (GameObject obj in fondos2)
        {
            obj.transform.position += Vector3.down * velocidad2 * Time.deltaTime;
            if (obj.transform.position.y > 20f)
            {
                Destroy(obj);
            }
        }

        GameObject[] fondos3 = GameObject.FindGameObjectsWithTag("Fondo3");
        foreach (GameObject obj in fondos3)
        {
            obj.transform.position += Vector3.down * velocidad3 * Time.deltaTime;
            if (obj.transform.position.y > 20f)
            {
                Destroy(obj);
            }
        }
    }
}
