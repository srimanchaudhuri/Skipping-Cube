using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI jumpText;
    // Update is called once per frame

    private void Start()
    {
        jumpText.enabled = false;   
    }
    public void Change()
    {   
        jumpText.enabled=true;
        jumpText.text = "You can now use space to jump";
    }
}
