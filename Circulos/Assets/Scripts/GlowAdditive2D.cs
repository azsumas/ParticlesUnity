using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowAdditive2D : MonoBehaviour {

    public float minGlow;
    public float maxGlow;
    public float smooth;
    public Color glowColor;
    IEnumerator Start()
    {
        //Iniciar variables
        MaterialPropertyBlock block = new MaterialPropertyBlock();
        Renderer rend = GetComponent<Renderer>();
        rend.GetPropertyBlock(block);

        glowColor.a = minGlow;
        block.SetColor("_TintColor", glowColor);

        rend.SetPropertyBlock(block);

        bool glow = true;
        //Bucle Glow
        while(true)
        {
            if(glow)
            {
                if(glowColor.a >= maxGlow) glow = false;
                else glowColor.a += Time.deltaTime * smooth;
            }
            else
            {
                if(glowColor.a <= minGlow) glow = true;
                else glowColor.a -= Time.deltaTime * smooth;
            }

            block.SetColor("_TintColor", glowColor);

            rend.SetPropertyBlock(block);

            yield return null;
        }
    }
}
