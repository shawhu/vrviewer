using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public Material skyboxMat;
    public List<Texture2D> textures = new List<Texture2D>();

    private int currentIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            if (currentIndex >5)
            {
                currentIndex = 0;
            }
            skyboxMat.SetTexture("_MainTex", textures[currentIndex]);
            currentIndex++;
        }
    }
}
