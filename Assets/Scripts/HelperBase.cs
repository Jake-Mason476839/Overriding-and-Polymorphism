using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperBase : MonoBehaviour
{
    private float speed = 10f;

    protected void Horizontal()
    {
        float moveX = Input.GetAxis ("Horizontal");

        transform.position = transform.position + new Vector3 (moveX * speed * Time.deltaTime, 0 , 0);
    }

    protected void Vertical()
    {
        float moveZ = Input.GetAxis ("Vertical");

        transform.position = transform.position + new Vector3 (0, 0 , moveZ * speed * Time.deltaTime);
    }

    protected void PlayerDamage()
    {
        float damage = 10f;
    }

    protected void PlayerDamageDisplay()
    {
        Debug.Log("10f");
    }
}
