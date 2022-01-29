using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform firePosition;
    public GameObject projectail;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(projectail, firePosition.position, firePosition.rotation);
        }
    }
}
