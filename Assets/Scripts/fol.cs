using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fol : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.followDamp(transform, transform.root, LeanProp.localY, Random.Range(-0.5f,0.5f));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
