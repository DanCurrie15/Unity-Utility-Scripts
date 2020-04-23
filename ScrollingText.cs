using UnityEngine;

public class ScrollingText : MonoBehaviour 
{
    public float duration = 1f;
    public float speed = 3f;

    // Requires empty game object with text mesh
    private TextMesh textMesh;
    private float startTime;

	void Awake () 
    {
        textMesh = GetComponent<TextMesh>();
        startTime = Time.time;
	}
	
	void Update () 
    {
        if(Time.time - startTime < duration)
        {
            //Scroll up
            transform.LookAt(Camera.main.transform);
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else
        {
            //Destroy
            Destroy(gameObject);
        }
	}

    public void SetText(string text)
    {
        textMesh.text = text;    
    }

    public void SetColor(Color color)
    {
        textMesh.color = color;
    }
}
