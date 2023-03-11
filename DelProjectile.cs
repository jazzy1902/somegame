using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelProjectile : MonoBehaviour
{

    private float prjctlLifeTime = 1f;
    private float prjctlAliveTime = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        prjctlAliveTime += Time.deltaTime;
        if(prjctlAliveTime >= prjctlLifeTime)
            Destroy(gameObject);
    }
}
