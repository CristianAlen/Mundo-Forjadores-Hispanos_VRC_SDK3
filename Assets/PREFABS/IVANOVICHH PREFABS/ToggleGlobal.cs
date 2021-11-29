
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class OBJECT : UdonSharpBehaviour
{
    public GameObject toggleObject;

    [UdonSynced]
    bool isEnabled;

    private void Start()
    {
        isEnabled = toggleObject.activeSelf;
    }

    public override void OnDeserialization()
    {
        if (!Networking.IsOwner(gameObject))
            toggleObject.SetActive(isEnabled);
    }

    public override void Interact()
    {
        if (!Networking.IsOwner(gameObject))
            Networking.SetOwner(Networking.LocalPlayer, gameObject);

        isEnabled = !isEnabled;
        toggleObject.SetActive(isEnabled);

        RequestSerialization();
    }
}

