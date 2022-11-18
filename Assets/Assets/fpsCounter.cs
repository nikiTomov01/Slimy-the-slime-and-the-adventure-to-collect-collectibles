using UnityEngine;
using TMPro;

public class fpsCounter : MonoBehaviour
{
    public TextMeshProUGUI fpsText;

    private float pollingTime = 1f;
    private float time;
    private int frameCount;

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        frameCount++;

        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            fpsText.text = "FPS: " + frameRate.ToString();

            time -= pollingTime;
            frameCount = 0;
        }
    }
}
