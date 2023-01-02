using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanged : MonoBehaviour
{
    public Color[] colors;
    public Renderer[] mat;

    public void Red()
    {
        for(int i=0; i<mat.Length; i++)
        {
            mat[i].material.color = colors[0];
        }
    }
    public void Black()
    {
        for(int i=0; i<mat.Length; i++)
        {
            mat[i].material.color = colors[1];
        }
    }
    public void Orange()
    {
        for(int i=0; i<mat.Length; i++)
        {
            mat[i].material.color = colors[2];
        }
    }
    public void Green()
    {
        for(int i=0; i<mat.Length; i++)
        {
            mat[i].material.color = colors[3];
        }
    }
    public void Yellow()
    {
        for(int i=0; i<mat.Length; i++)
        {
            mat[i].material.color = colors[4];
        }
    }
}
