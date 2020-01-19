using UnityEngine;
// using Valve.VR;

public class Interactable : MonoBehaviour
{
    protected bool isAvailable = true;

    public virtual void StartInteraction(Hand hand)
    {
        print("Start");
    }

    public virtual void Interaction(Hand hand)
    {
        print("Interaction");
    }

    public virtual void EndInteraction(Hand hand)
    {
        print("End");
    }

    public bool GetAvailability()
    {
        return isAvailable;
    }
}
