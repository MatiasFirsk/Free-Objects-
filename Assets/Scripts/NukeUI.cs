using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NukeUI : MonoBehaviour
{
    public TextMeshProUGUI nukeCountText;

    private void Start()
    {
        UpdateNukeCountUI(0);
    }

    public void UpdateNukeCountUI(int nukeCount)
    {
        if (nukeCountText != null)
        {
            nukeCountText.text = "Nukes: " + nukeCount.ToString();
        }
    }
}
