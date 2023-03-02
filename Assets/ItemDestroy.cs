using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour
{
    private GameObject UnityChan;

    public float diffrence;

    private GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.UnityChan = GameObject.Find("unitychan");

        this.Camera = GameObject.Find("Main Camera");
        
        //Unityちゃんと障害物の位置(z座標)の差を求める
        this.diffrence = Camera.transform.position.z - this.transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        this.diffrence = Camera.transform.position.z - this.transform.position.z;

        Debug.Log(transform.position.z);
        Debug.Log(diffrence);

        if (this.transform.position.z < this.Camera.transform.position.z )
        {
            
            Destroy(this.gameObject);
        }

    }
}
