using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STween : MonoBehaviour
{
    public GameObject levelSuccess;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        LeanTween.scale(gameObject, new Vector3(1.5f, 1.5f, 1.5f), 2f).setDelay(.5f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveLocal(gameObject, new Vector3(-30f, 747f, 2f), .7f).setDelay(2f).setEase(LeanTweenType.easeInOutCubic);
        LeanTween.scale(gameObject, new Vector3(1f, 1f, 1f), 2f).setDelay(1.7f).setEase(LeanTweenType.easeInOutCubic);
    }
}
