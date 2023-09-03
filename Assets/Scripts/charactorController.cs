using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactorController : MonoBehaviour
{
    public Animator myAnim;
    public float moveSpeed = 0.5f;
    public float rotateSpeed = 80f;

    bool isHeart = false;
    bool isStar = false;

    public GameObject clickSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            myAnim.SetInteger("AniWalk", 1);
            this.transform.Translate(0.0f, 0.0f, moveSpeed * Time.deltaTime, Space.Self);

            if (Input.GetKey(KeyCode.A))
            {
                this.transform.Rotate(0.0f, -rotateSpeed * Time.deltaTime, 0.0f);
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.Rotate(0.0f, rotateSpeed * Time.deltaTime, 0.0f);
            }
        }
        else
        {
            myAnim.SetInteger("AniWalk", 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnim.SetTrigger("AniMiao");
            Instantiate(clickSound).SetActive(true);
            if (isHeart)  //���T�ؼ�
            {
                GameObject.Find("Level").SendMessage("Find_Heart");
            }
            else if (isStar)
            {
                GameObject.Find("Level").SendMessage("Find_Star");
            }
        }

    }

    void OnTriggerStay(Collider other)
    {
        // Debug-draw all contact points and normals
        if (other.gameObject.name == "RealHeart")
        {
            Debug.Log("����ؼ�");
            isHeart = true;
        }
        if (other.gameObject.name == "HardStar1")
        {
            Debug.Log("����D�ؼ�");
            isStar = true;
        }
        if (other.gameObject.name == "HardStar2")
        {
            Debug.Log("����D�ؼ�");
            isStar = true;
        }
        if (other.gameObject.name == "HardStar3")
        {
            Debug.Log("����D�ؼ�");
            isStar = true;
        }
        if (other.gameObject.name == "HardStar4")
        {
            Debug.Log("����D�ؼ�");
            isStar = true;
        }
        if (other.gameObject.name == "HardStar5")
        {
            Debug.Log("����D�ؼ�");
            isStar = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        // Debug-draw all contact points and normals
        if (other.gameObject.name == "RealHeart")
        {
            Debug.Log("���}�ؼ�");
            isHeart = false;
        }
        if (other.gameObject.name == "HardStar1")
        {
            Debug.Log("���}�D�ؼ�");
            isStar = false;
        }
        if (other.gameObject.name == "HardStar2")
        {
            Debug.Log("���}�D�ؼ�");
            isStar = false;
        }
        if (other.gameObject.name == "HardStar3")
        {
            Debug.Log("���}�D�ؼ�");
            isStar = false;
        }
        if (other.gameObject.name == "HardStar4")
        {
            Debug.Log("���}�D�ؼ�");
            isStar = false;
        }
        if (other.gameObject.name == "HardStar5")
        {
            Debug.Log("���}�D�ؼ�");
            isStar = false;
        }
    }
}
