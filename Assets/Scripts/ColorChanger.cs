using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    // Create a Renderer variable to hold the current objects renderer
    private Renderer capsuleRenderer; 

    // Allow the selection of two colors
    public Color color1;
    public Color color2;

    // Start is called before the first frame update
    void Start()
    {
        // Assign the renderer for the current object
        capsuleRenderer = GetComponent<Renderer>();

        // Call out the coroutine
        StartCoroutine(ChangeColor());      
    }

    // Update is called once per frame
    void Update()
    {
                  
    }

    // Create a function to alternate between the two colors
    private IEnumerator ChangeColor() 
    {
        while (true) 
        {
            if (capsuleRenderer.material.color == color1)
                capsuleRenderer.material.color = color2;
            else
                capsuleRenderer.material.color = color1;
            
            yield return new WaitForSeconds(3);
        }
    }
}
