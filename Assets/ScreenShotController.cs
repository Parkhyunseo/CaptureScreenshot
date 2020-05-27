using System.IO;
using UnityEngine;
using UnityEngine.WSA;

public class ScreenShotController : MonoBehaviour
{
    [SerializeField]
    string folderName = "Default";
    [SerializeField]
    int howMany;
    [SerializeField]
    float timeScale = 0.3f;

    bool running;
    int frameCount;
    string folderPath;
    int index;

    private void Update()
    {
        var space = Input.GetKeyDown(KeyCode.Space);

        if (space)
            Initialize();

        if (running)
        {
            if (frameCount > howMany)
            {
                Debug.Log("Capture end");
                running = false;
                Time.timeScale = 1;
            }

            string filename = Path.Combine(folderPath, $"{index++}.png");
            CaptureScreenshot.CaptureTransparentScreenshot(Camera.main, Screen.width, Screen.height, filename);
            frameCount++;
        }
    }

    public void Initialize()
    {
        if (running)
        {
            Debug.LogError("Capture is already running!");
            return;
        }

        Debug.Log("Capture Start!!");

        running = true;
        
        index = 0;
        frameCount = 0;
        Time.timeScale = timeScale;

        folderPath = Path.Combine("Assets", folderName);
        if (Directory.Exists(folderPath) == false)
            Directory.CreateDirectory(folderPath);
    }
}
