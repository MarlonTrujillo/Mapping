using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Cube : MonoBehaviour
{

    public int miPosicionEnX;
    public int miPosicionEnY;
    public int miPosicionEnZ;
    public int miID;
    public GameObject quad;
    public Material material;
    public Texture m_TextOrig;
    public Texture m_TextWinter;
    public Texture m_TextFall;
    public Texture m_TextSpring;
    public float miOffSetX;
    public float miOffSetY;
    public bool esParID=false;
    public bool esParX = false;
    public bool esParY = false;
    // Use this for initialization



    private void Awake()
    {
        material = quad.GetComponent<Renderer>().material; // Obtiene la textura del quad que está en el prefab
        


    }
    void Start()
    {
        material.SetTexture("_MainTex", m_TextOrig);
        material.SetTextureOffset("_MainTex", new Vector2(miOffSetX, miOffSetY)); // Aquí cambio el offset del material
       
        // Para chequear si es par el id. id empieza en 1
        if (miID%2 == 0)
        {
            esParID = true;
        }

        // Para chequear si es par en x
        if (miPosicionEnX%2 == 0)
        {
            esParX = true;
        }

        // para chequear si es par en y
        if (miPosicionEnY % 2 == 0)
        {
            esParY = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("space"))
        {
            //StartCoroutine("Rotate");
            StartCoroutine("RutinaCompleta");
        }
    }

    IEnumerator Rotate()
    {
        if (esParY)
        {
            Tween myTween = transform.DORotate(new Vector3(0, 360, 0), 5f, RotateMode.FastBeyond360); // Pares rotan a la izquierda
            yield return myTween.WaitForCompletion();
        }
        else
        {
            Tween myTween = transform.DORotate(new Vector3(0, -360, 0), 5f, RotateMode.FastBeyond360); // Impares rotan a la derecha
            yield return myTween.WaitForCompletion();
        }
    }

    IEnumerator RutinaCompleta()
    {
        // Frontline
        if (esParY && esParX)
        {
            Tween myTween = transform.DOMoveZ(-1f, 5f, false);
            yield return myTween.WaitForCompletion();

            myTween = transform.DOShakeRotation(2.25f, 10f, 15, 90f, false);
            yield return myTween.WaitForCompletion();
            myTween = transform.DOShakeRotation(0.5f, 20f, 25, 90f, false);
            yield return new WaitForSeconds(0.25f);
            material.SetTexture("_MainTex", m_TextSpring);
            myTween = transform.DOShakeScale(1f, 1.08f, 10, 10f, true);
            yield return new WaitForSeconds(0.25f);
            myTween = transform.DOShakeRotation(2.25f, 10f, 15, 90f, true);
            yield return myTween.WaitForCompletion();

            myTween = transform.DOMoveZ(0f, 5f, false);
            yield return myTween.WaitForCompletion();

            myTween = transform.DORotate(new Vector3(0, 180, 0), 2f, RotateMode.FastBeyond360);
            yield return myTween.WaitForCompletion();
            material.SetTexture("_MainTex", m_TextOrig);
            myTween = transform.DORotate(new Vector3(0, 360, 0), 3f, RotateMode.FastBeyond360);

        }
        // Middle
        else if (!esParY && !esParX)
        {
            Tween myTween = transform.DOMoveZ(0f, 5f, false);
            yield return myTween.WaitForCompletion();

            myTween = transform.DOShakeRotation(2.25f, 10f, 15, 90f, false);
            yield return myTween.WaitForCompletion();
            myTween = transform.DOShakeRotation(0.5f, 20f, 25, 90f, false);
            yield return new WaitForSeconds(0.25f);
            material.SetTexture("_MainTex", m_TextFall);
            myTween = transform.DOShakeScale(1f, 1.08f, 10, 10f, true);
            yield return new WaitForSeconds(0.25f);
            myTween = transform.DOShakeRotation(2.25f, 10f, 15, 90f, true);
            yield return myTween.WaitForCompletion();

            myTween = transform.DOMoveZ(0f, 5f, false);
            yield return myTween.WaitForCompletion();

            myTween = transform.DORotate(new Vector3(0, 180, 0), 2.5f, RotateMode.FastBeyond360);
            yield return myTween.WaitForCompletion();
            material.SetTexture("_MainTex", m_TextOrig);
            myTween = transform.DORotate(new Vector3(0, 360, 0), 2.5f, RotateMode.FastBeyond360);
        }
        // Backline
        else
        {
            Tween myTween = transform.DOMoveZ(1f, 5f, false); // Se mueve hacia atrás
            yield return myTween.WaitForCompletion();

            myTween = transform.DOShakeRotation(2.25f, 10f, 15, 90f, false);
            yield return myTween.WaitForCompletion();
            myTween = transform.DOShakeRotation(0.5f, 20f, 25, 90f, false);
            yield return new WaitForSeconds(0.25f);
            material.SetTexture("_MainTex", m_TextWinter);
            myTween = transform.DOShakeScale(1f, 1.08f, 10, 10f, true);
            yield return new WaitForSeconds(0.25f);
            myTween = transform.DOShakeRotation(2.25f, 10f, 15, 90f, true);
            yield return myTween.WaitForCompletion();

            myTween = transform.DOMoveZ(0f, 5f, false);
            yield return myTween.WaitForCompletion();

            myTween = transform.DORotate(new Vector3(0, 180, 0), 3f, RotateMode.FastBeyond360);
            yield return myTween.WaitForCompletion();
            material.SetTexture("_MainTex", m_TextOrig);
            myTween = transform.DORotate(new Vector3(0, 360, 0), 2f, RotateMode.FastBeyond360);
        }
        
    }

    void ChangeMaterial()
    {
        material.SetTexture("_MainTex", m_TextWinter);
    }

}
