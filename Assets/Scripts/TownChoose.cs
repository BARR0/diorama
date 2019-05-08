using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TownChoose : MonoBehaviour
{
    public Animator animator;
    private bool good;
    // Start is called before the first frame update
    void Start()
    {
        good = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        animator.SetBool("good", good);
    }
}
