using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 30f;
    private Rigidbody rb;

    void Start()
    {
        // 往前飛
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // 如果碰撞到的是 Enemy
        if (other.tag == "Enemy")
        {
            // 刪除
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}
