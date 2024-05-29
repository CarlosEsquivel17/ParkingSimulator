using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNotebook : MonoBehaviour
{
    public GameObject Cover;
    public HingeJoint myHinge;
    // Start is called before the first frame update
    void Start()
    {
        var myHinge = Cover.GetComponent<HingeJoint>();
        myHinge.useMotor = false;
    }

    // Update is called once per frame
    void Abrete()
    {
        myHinge.useMotor = true;
    }
}
