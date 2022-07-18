using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text laps, time, recap;
    [SerializeField] GameObject gameCanvas, pauseCanvas;

    void Update()
    {
        UpdateUI();
    }
    public void UpdateUI()
    {
        if (CarMoveScript.instance.laps == 0)
            return;

        Debug.Log("UpdateUI");
        laps.text = "Current Lap: " + CarMoveScript.instance.laps;
        int m, s;
        s = CarMoveScript.instance.time % 60;
        m = (CarMoveScript.instance.time - s) / 60;

        string sS = s.ToString();
        string mS = m.ToString();
        if (s < 10)
            sS = "0" + sS;
        if (m < 10)
            mS = "0" + mS;

        time.text = mS + ":" + sS;
    }

    public void PauseGame()
    {
        pauseCanvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        pauseCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void DisplayRecap(int t)
    {
        int m, s;
        s = t % 60;
        m = t / 60;

        string sS = s.ToString();
        string mS = m.ToString();
        if (s < 10)
            sS = "0" + sS;
        if (m < 10)
            mS = "0" + mS;

        recap.text = "You finished in " + mS + ":" + sS + "!";
        Invoke("HideRecap", 3);
    }
    void HideRecap()
    {
        recap.text = "";
    }
}
