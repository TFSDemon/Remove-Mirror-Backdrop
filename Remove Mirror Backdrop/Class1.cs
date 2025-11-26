using BepInEx;
using UnityEngine;

[BepInPlugin("com.tfsdemon.disablemirrorbackdrop", "Disable Mirror Backdrop", "1.0.0")]
public class DisableMirrorBackdrop : BaseUnityPlugin
{
    private GameObject mirrorBackdrop;

    private void Awake()
    {
        Logger.LogInfo("Disable Mirror Backdrop mod loaded~");
    }

    private void Update()
    {
        if (mirrorBackdrop == null)
        {
            mirrorBackdrop = GameObject.Find("Mirror Backdrop");
        }

        if (mirrorBackdrop != null && mirrorBackdrop.activeSelf)
        {
            mirrorBackdrop.SetActive(false);
            Logger.LogInfo("Mirror Backdrop was enabled and has been forcibly turned off again.");
        }
    }
}
