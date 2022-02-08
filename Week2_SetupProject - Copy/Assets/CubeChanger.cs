using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeChanger : MonoBehaviour
{
    public Mesh cubeMesh;
    public Mesh sphereMesh;
    public Mesh capsuleMesh;
    private MeshFilter meshFilter;
    public int meshCounter;

    public float scaleX;
    public float scaleY;
    public float scaleZ;

    public float scaleX_new;
    public float scaleY_new;
    public float scaleZ_new;

    private Renderer meshRenderer;


    // Start is called before the first frame update
    void Start()
    {
        meshFilter = gameObject.GetComponent<MeshFilter>();
        meshCounter = 0;
        meshRenderer = gameObject.GetComponent<Renderer>();

        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
        scaleZ = transform.localScale.z;

        scaleX_new = scaleX;
        scaleY_new = scaleY;
        scaleZ_new = scaleZ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void MeshChanger()
    {
        if (meshCounter == 0)
        {
            meshFilter.mesh = cubeMesh;
        }
        if (meshCounter == 1)
        {
            meshFilter.mesh = sphereMesh;
        }
        if (meshCounter == 2)
        {
            meshFilter.mesh = capsuleMesh;
        }
        meshCounter++;
        if (meshCounter > 2)
        {
            meshCounter = 0;
        }
        
    }

    public void MeshPainter()
    {
        // meshRenderer.material = SetColor("_Color", Color.red);
        float color1 = Random.Range(0f, 1f);
        float color2 = Random.Range(0f, 1f);
        float color3 = Random.Range(0f, 1f);

        meshRenderer.material.color = new Color(color1, color2, color3);
    }

    public void MeshScaler()
    {
         scaleX_new = scaleX_new + 0.01f;
         scaleY_new = scaleY_new + 0.01f;
         scaleZ_new = scaleZ_new + 0.01f;

      // transform.localScale = new Vector3(scaleX+0.2f, scaleY+0.2f, scaleZ+0.2f);

        transform.localScale = new Vector3(scaleX_new, scaleY_new, scaleZ_new);


    }

    public void MeshScaler_Orig()
    {
        transform.localScale = new Vector3(scaleX, scaleY, scaleZ);


    }
}
