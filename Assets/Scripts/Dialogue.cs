using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour {

    private bool isDisplaying;
    private float timeToDisplay;
    private float currentTime;
    public Text text;
    public Image image;
    public RectTransform rectTransform;
	// Use this for initialization
	void Start () {
        Reset();
        text = GetComponentInChildren<Text>();
        image = GetComponent<Image>();
        rectTransform = GetComponent<RectTransform>();
        Color c = Color.white;
        c.a = 0;
        text.color = c;
        image.color = c;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (isDisplaying)
        {
            currentTime += Time.deltaTime;

            if (currentTime > timeToDisplay)
            {
                Reset();
            }

            text.color = Color.Lerp(text.color, Color.white, Time.deltaTime * 2);
            image.color = Color.Lerp(image.color, Color.black, Time.deltaTime * 2);

        }
        else
        {

            Color col1 = Color.white;
            col1.a = 0;
            Color col2 = Color.black;
            col2.a = 0;

            text.color = Color.Lerp(text.color, col1, Time.deltaTime * 2);
            image.color = Color.Lerp(image.color, col2, Time.deltaTime * 2);
        }

		
	}

    void Reset()
    {
        isDisplaying = false;
        timeToDisplay = 0;
        currentTime = 0;
    }

    public void Display(string tex, float time)
    {

        this.text.text = tex;
        timeToDisplay = time;
        isDisplaying = true;
    }
}
