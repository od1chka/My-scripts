using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // ����� ��������� �������� � ������
    public int Health = 10;
    public int Level = 5;
    public float speed = 1.2f;
    
    


    void Start()
    {
        Health += Level;
        //����� � ������� Hello world
        print(Health);

    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
    
}
