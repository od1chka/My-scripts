using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int jumpFactor = 2;

    void OnTriggerEnter(Collider other)
    {
        //���������� �������� ���� ������
        other.GetComponent<Jump>().jumpStrength *= jumpFactor;


    }

    void OnTriggerExit(Collider other)
    {
        //��������� �������� ���� ������    
        other.GetComponent<Jump>().jumpStrength /= jumpFactor;
    }

}
