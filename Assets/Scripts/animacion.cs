using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion : MonoBehaviour
{
    Animator animator;
    public GameObject prefab;
    //start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    //// Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("wow", true);

        }
        else
        {
            animator.SetBool("wow", false);
        }

    }

    public void InstanciarPrefab()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
