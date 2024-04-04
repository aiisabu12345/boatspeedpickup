using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prefab;

    void Start()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
