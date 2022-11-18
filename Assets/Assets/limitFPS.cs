using UnityEngine;

public class limitFPS : MonoBehaviour
{
    public int targetFPS;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = targetFPS;
    }
}
