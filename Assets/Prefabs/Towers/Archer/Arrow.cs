using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    protected GameObject enemy;

    protected float Speed;
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(enemy.transform);
        Speed = 15.0f;
        Destroy(gameObject, 0.6f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(enemy.transform);
        transform.Translate(Vector3.forward * Time.deltaTime*Speed);
    }

    public void SetEnemy(GameObject m_enemy)
    {
        enemy = m_enemy;
    }

   
}
