using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] private Transform runnersParent;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void Run()
    {
        for (int i = 0; i < runnersParent.childCount; i++)
        {
            Transform runner = runnersParent.GetChild(i);
            Animator runnerAnimator = runner.GetComponent<Animator>();
            runnerAnimator.Play("Run");
        }

    }

    public void Idle()
    {
        for (int i = 0; i < runnersParent.childCount; i++)
        {
            Transform runner = runnersParent.GetChild(i);
            Animator runnerAnimator = runner.GetComponent<Animator>();
            runnerAnimator.Play("Idle");
        }
    }
}
