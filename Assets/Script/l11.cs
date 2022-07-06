using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class l11 : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public static int turac;
    int i, x;
    // Start is called before the first frame update
    void Start()
    {
        x=0;
        turac = 0;
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<TMP_Text>().text = " ";
            turac = 0;
        }
        if(GameObject.Find("ll11").GetComponent<TMP_Text>().text == GameObject.Find("ll22").GetComponent<TMP_Text>().text && 
            GameObject.Find("ll22").GetComponent<TMP_Text>().text== GameObject.Find("ll33").GetComponent<TMP_Text>().text && GameObject.Find("ll33").GetComponent<TMP_Text>().text!=" ")
        {
            x++;
        }
        else if (GameObject.Find("ll13").GetComponent<TMP_Text>().text == GameObject.Find("ll22").GetComponent<TMP_Text>().text &&
            GameObject.Find("ll22").GetComponent<TMP_Text>().text == GameObject.Find("ll31").GetComponent<TMP_Text>().text && GameObject.Find("ll31").GetComponent<TMP_Text>().text != " ")
        {
            x++;
        }
        else if (GameObject.Find("ll11").GetComponent<TMP_Text>().text == GameObject.Find("ll12").GetComponent<TMP_Text>().text &&
            GameObject.Find("ll12").GetComponent<TMP_Text>().text == GameObject.Find("ll13").GetComponent<TMP_Text>().text && GameObject.Find("ll11").GetComponent<TMP_Text>().text != " ")
        {
            x++;
        }
        else if (GameObject.Find("ll22").GetComponent<TMP_Text>().text == GameObject.Find("ll21").GetComponent<TMP_Text>().text &&
            GameObject.Find("ll12").GetComponent<TMP_Text>().text == GameObject.Find("ll23").GetComponent<TMP_Text>().text && GameObject.Find("ll21").GetComponent<TMP_Text>().text != " ")
        {
            x++;
        }
        else if (GameObject.Find("ll33").GetComponent<TMP_Text>().text == GameObject.Find("ll32").GetComponent<TMP_Text>().text &&
            GameObject.Find("ll32").GetComponent<TMP_Text>().text == GameObject.Find("ll31").GetComponent<TMP_Text>().text && GameObject.Find("ll31").GetComponent<TMP_Text>().text != " ")
        {
            x++;
        }
        else if (GameObject.Find("ll11").GetComponent<TMP_Text>().text == GameObject.Find("ll21").GetComponent<TMP_Text>().text &&
            GameObject.Find("ll21").GetComponent<TMP_Text>().text == GameObject.Find("ll31").GetComponent<TMP_Text>().text && GameObject.Find("ll21").GetComponent<TMP_Text>().text != " ")
        {
            x++;
        }
        else if (GameObject.Find("ll12").GetComponent<TMP_Text>().text == GameObject.Find("ll22").GetComponent<TMP_Text>().text &&
            GameObject.Find("ll22").GetComponent<TMP_Text>().text == GameObject.Find("ll32").GetComponent<TMP_Text>().text && GameObject.Find("ll22").GetComponent<TMP_Text>().text != " ")
        {
            x++;
        }
        else if (GameObject.Find("ll13").GetComponent<TMP_Text>().text == GameObject.Find("ll23").GetComponent<TMP_Text>().text &&
            GameObject.Find("ll23").GetComponent<TMP_Text>().text == GameObject.Find("ll33").GetComponent<TMP_Text>().text && GameObject.Find("ll23").GetComponent<TMP_Text>().text != " ")
        {
            x++;
        }
        if(x==1)
        {
            x = 2;
            Debug.Log("U Loser");
            GameObject.Find("Text (TMP)").GetComponent<TMP_Text>().text = " ";
            GameObject.Find("ll11").GetComponent<TMP_Text>().text = " ";
            GameObject.Find("ll12").GetComponent<TMP_Text>().text = " ";
            GameObject.Find("ll13").GetComponent<TMP_Text>().text = " ";
            GameObject.Find("ll23").GetComponent<TMP_Text>().text = " ";
            GameObject.Find("ll22").GetComponent<TMP_Text>().text = " ";
            GameObject.Find("ll21").GetComponent<TMP_Text>().text = " ";
            GameObject.Find("ll33").GetComponent<TMP_Text>().text = " ";
            GameObject.Find("ll32").GetComponent<TMP_Text>().text = " ";
            GameObject.Find("ll31").GetComponent<TMP_Text>().text = " ";
            GameObject.Find("Text (TMP)").GetComponent<TMP_Text>().text = "S-a terminat bozo";
            Invoke("ResetGame", 5);
        }


    }

    void ResetGame()
    {
        x = 0;
        turac = 0;
        GameObject.Find("Text (TMP)").GetComponent<TMP_Text>().text = " ";
        GameObject.Find("ll11").GetComponent<TMP_Text>().text = " ";
        GameObject.Find("ll12").GetComponent<TMP_Text>().text = " ";
        GameObject.Find("ll13").GetComponent<TMP_Text>().text = " ";
        GameObject.Find("ll23").GetComponent<TMP_Text>().text = " ";
        GameObject.Find("ll22").GetComponent<TMP_Text>().text = " ";
        GameObject.Find("ll21").GetComponent<TMP_Text>().text = " ";
        GameObject.Find("ll33").GetComponent<TMP_Text>().text = " ";
        GameObject.Find("ll32").GetComponent<TMP_Text>().text = " ";
        GameObject.Find("ll31").GetComponent<TMP_Text>().text = " ";
    }

    void OnMouseDown()
    {
        Debug.Log(turac);
        if(turac == 0 && GetComponent<TMP_Text>().text == " ")
        {
            GetComponent<TMP_Text>().text = "X";
            turac = (turac + 1) % 2;
        }
        else if(turac == 1 && GetComponent<TMP_Text>().text ==" ")
        {
            GetComponent<TMP_Text>().text = "0";
            turac = (turac + 1) % 2;
        }
        
    }
}
