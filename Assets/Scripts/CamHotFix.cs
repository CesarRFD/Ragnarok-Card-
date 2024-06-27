using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamHotFix : MonoBehaviour
{
    [SerializeField] private Transform cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.transform;
        StartCoroutine(FixCam());
    }
    private IEnumerator FixCam()
    {
        yield return new WaitForSeconds(1f);
        cam.position = new Vector3(0, 0, -10);
        cam.rotation = Quaternion.Euler(0, 0, 0);
    }
}
