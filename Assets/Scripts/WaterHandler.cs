using UnityEngine;

public class WaterHandler : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent(out WaterComponent waterComponent))
        {
            waterComponent.ActivateWaterEffect(transform.position.y);
        }
    }

    private void OnTriggerExit(Collider other)
    {
         if (other.TryGetComponent(out WaterComponent waterComponent))
         {
             waterComponent.DeactivateWaterEffect();
         }
    }
}
