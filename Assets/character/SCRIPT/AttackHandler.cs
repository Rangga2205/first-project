using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackHandler : MonoBehaviour
{
    public Animator Avatar;
    void Start()
    {
        print("Start jalan");
        Avatar = GetComponent<Animator>();
    }

    void AttackNow()
    {
        Avatar.SetTrigger("goAttack");
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            print("Spasi Kepencet");
            AttackNow();
        }
    }
}
