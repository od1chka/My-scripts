using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int jumpFactor = 2;

    void OnTriggerEnter(Collider other)
    {
        //Увеличение скорости бега игрока
        other.GetComponent<Jump>().jumpStrength *= jumpFactor;


    }

    void OnTriggerExit(Collider other)
    {
        //Понижение скорости бега игрока    
        other.GetComponent<Jump>().jumpStrength /= jumpFactor;
    }

}
