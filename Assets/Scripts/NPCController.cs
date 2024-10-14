using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCController : MonoBehaviour
{
    private Transform ClosestTarget;

    [SerializeField] private GameObject NPCText;


    private void FixedUpdate()
    {
        ClosestTarget = GameObject.FindWithTag("Player").transform;

        if (DistanceToTarget() < 25)
        {
            NPCText.SetActive(true);
        }
        else
        {
            NPCText.SetActive(false);
        }
    }

    protected float DistanceToTarget()
    {
        return Vector3.Distance(transform.position, ClosestTarget.position);
    }



}
