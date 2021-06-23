using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ClearObject", 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ClearObject()
    {
        Destroy(this.gameObject);
    }
}
