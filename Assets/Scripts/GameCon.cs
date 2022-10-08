using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCon : MonoBehaviour
{
    public BoxProb boxx;
    public GameObject roww;
    public int Row = 3;
    public int Colum = 7;
    // Start is called before the first frame update
    void Start()
    {
        co.Clear();

        for (int i = 0; i < Colum; i++)
        {
            GameObject b = Instantiate<GameObject>(roww, new Vector3(this.transform.position.x, transform.position.y + i*0.92f, 
                transform.position.z), Quaternion.identity, this.transform);
            co.Add(b);
            List<BoxProb> li = new List<BoxProb>();
            for (int j = 0; j < Row; j++)
            {
                BoxProb bo = Instantiate<BoxProb>(boxx, new Vector3(b.transform.position.x + j,
                    b.transform.position.y, b.transform.position.z), Quaternion.identity, b.transform);
                li.Add(bo);
               


            }
            int k = Random.Range(0, Row);
            li[k].Col = true;
            if(Debug)
            li[k].GetComponent<MeshRenderer>().material = mat;


        }
        co[0].transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;
        CoinText.text = coin.ToString();

    }
    public bool Debug = true;
    public float Mul = 2;
    List<GameObject> co = new List<GameObject>();
  public  int index = 0;
    public GameObject success;
    public float Coin
    {
        get { return coin; }
        set { coin = value; CoinText.text = coin.ToString();
        }
    }
    public static GameCon Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
   public Material mat;
    public static float coin = 100;
   public TMPro.TMP_Text CoinText, CoinText2, CoinText3;
    public GameObject CollectBtn;
    public GameObject StartCanva;
    void Update()
    {
        if (start == false)
            return;
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                if (objectHit.parent == co[index].transform)
                {
                    if (objectHit.GetComponent<BoxProb>().Col == true)
                    {
                        coin *=Mul;
                        CoinText.text = coin.ToString();
                        CoinText2.text = coin.ToString();
                        CoinText3.text = coin.ToString();
                        UpodateRow();
                      //  co[index].GetComponent<MeshRenderer>().enabled = false;
                         co[index+1].transform.GetChild(0).GetComponent<MeshRenderer>().enabled=false;
                        co[index].transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true; 
                        LeanTween.moveLocalY(gameObject, -index* 0.92f, 1f).setEase(LeanTweenType.easeOutBounce).setDelay(0.3f);
                        index += 1;
                        success.SetActive(false);
                        success.SetActive(true);
                        CollectBtn.SetActive(true);

                    }
                    else
                    {
                       // coin = 0;
                        GameOver();
                    }
                    Destroy(objectHit.gameObject);
                }
             
                // Do something with the object that was hit by the raycast.
            }
        }
    }
    bool start = false;
    public void StartGame()
    {
        start = true;
        StartCanva.SetActive(false);
    }
    void GameOver()
    {
        
    }
    void UpodateRow()
    {
        
    }
}
 
