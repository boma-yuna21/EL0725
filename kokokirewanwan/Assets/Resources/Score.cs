using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    static int Total_Score;
    public static int Unit_Score;
    void Start()
    {
        Total_Score = 0;
        Unit_Score = 3;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = "Score:" + Total_Score.ToString();
    }

    public static void ScorePlus(Vector3 pos)
    {
        Total_Score += Unit_Score;

        GameObject text = new GameObject("ScoreText");
        text.transform.parent = GameObject.Find("Canvas").transform;
   
        text.AddComponent<Text>();
        Text ScoreText = text.GetComponent<Text>();

        RectTransform trans = text.GetComponent<RectTransform>();

        trans.localPosition = pos;

        trans.sizeDelta = new Vector2(100.0f, 100.0f);


        trans.rotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, 0.0f));

        trans.localScale = new Vector3(1.0f, 1.0f, 1.0f);


        ScoreText.text = "+" + Unit_Score.ToString();

        Font font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;

        ScoreText.font = font;

        ScoreText.fontSize = 50;

        ScoreText.supportRichText = true;

        ScoreText.alignment = TextAnchor.LowerCenter;
        ScoreText.alignment = TextAnchor.MiddleCenter;

        ScoreText.color = Color.black;
        text.transform.position = pos;
        Destroy(text, 1);
    }
}
