using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowHile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
  public  TMPro.TMP_Text te;
    public void Show()
    {
        if (ga.active)
            ga.active = false;
        else
            ga.active = true;
    }
    public void Selec(int t)
    {
        GameCon.Instance.Coin= t;
        te.text = t.ToString();
        ga.active = false;
    }
    public GameObject ga;
    // Update is called once per frame
    void Update()
    {
        
    }
}
