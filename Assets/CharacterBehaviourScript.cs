using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviourScript : MonoBehaviour
{
    public GameObject enemy;
    public float threshold = 2f;
    private new Transform transform;
    private Transform enemyTransform;
    private Animator animator;

    void Start()
    {
        transform = GetComponent<Transform>();
        enemyTransform = enemy.GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, enemyTransform.position) < threshold)
        {
            animator.SetBool("isTaunting", true);
        }
        else
        {
            animator.SetBool("isTaunting", false);
        }
    }
}
