using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aiming : MonoBehaviour
{
    public Animator animator;
    public Camera camera;
    Coroutine zoomCoroutine;
    public Image crosshair;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            crosshair.enabled = false;
            animator.SetBool("aim", true);

            if (zoomCoroutine != null)
                StopCoroutine(zoomCoroutine);

            zoomCoroutine = StartCoroutine(aimFieldOfView(camera, 50, 0.3f));
        }
        if (Input.GetMouseButtonUp(1))
        {
            crosshair.enabled = true;
            animator.SetBool("aim", false);

            if (zoomCoroutine != null)
                StopCoroutine(zoomCoroutine);

            zoomCoroutine = StartCoroutine(aimFieldOfView(camera, 60, 0.3f));
        }
    }

    IEnumerator aimFieldOfView(Camera targetCamera, float toView, float duration)
    {
        float counter = 0;
        float fromView = targetCamera.fieldOfView;

        while (counter < duration)
        {
            counter += Time.deltaTime;

            float viewTime = counter / duration;

            targetCamera.fieldOfView = Mathf.Lerp(fromView, toView, viewTime);

            yield return null;
        }
    }

}
