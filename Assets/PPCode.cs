using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class PPCode : MonoBehaviour
{
    public PostProcessVolume volume;
    private Vignette vignette;
    private LensDistortion lens;

    // Start is called before the first frame update
    void Start()
    {
        volume.profile.TryGetSettings(out vignette);
        volume.profile.TryGetSettings(out lens);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            vignette.intensity.value = 0.7f;
            lens.intensity.value = 85;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            vignette.intensity.value = 0f;
            lens.intensity.value = 0;
        }
    }
}
