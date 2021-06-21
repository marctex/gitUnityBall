using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject objectBall;
    private Vector3 positionInitial;
    // Start is called before the first frame update
    void Start()
    {
        positionInitial = transform.position - objectBall.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = objectBall.transform.position + positionInitial;
    }
}
