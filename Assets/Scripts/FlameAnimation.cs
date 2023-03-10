using System.Collections;
using UnityEngine;

public class FlameAnimation : MonoBehaviour
{

    public int LightMode;
    public GameObject FlameLight;

    void Update()
    {
        if (LightMode == 0)
        {
            StartCoroutine(AnimateLight());
        }
    }
    IEnumerator AnimateLight()
    {

        LightMode = Random.Range(1, 4);
        if (LightMode == 1)
        {
            FlameLight.GetComponent<Animation>().Play("torchAnim1");
        }
        if (LightMode == 2)
        {
            FlameLight.GetComponent<Animation>().Play("torchAnim2");
        }
        if (LightMode == 3)
        {
            FlameLight.GetComponent<Animation>().Play("torchAnim1");
        }
        yield return new WaitForSeconds(0.99f);
    }
}
