using UnityEngine;
public class WaterComponent : MonoBehaviour
{
    [SerializeField]
    private Rigidbody _rigidbody;
    
    [SerializeField]
    private float _speed = 1f;
    
    [SerializeField]
    private float _limit = 1.15f;

    private const float DRAG = 0.99f;
    private const float ANGULARDRAG = 0.8f;
    public void ActivateWaterEffect(float position)
    {
        float difference = (transform.position.y - position) * _speed;
       
        Vector3 forceVector = new Vector3(0f, Mathf.Clamp((Mathf.Abs(Physics.gravity.y) * difference),
            0, Mathf.Abs(Physics.gravity.y) * _limit), 0f);
      
        _rigidbody.AddForce(forceVector);
        _rigidbody.drag = DRAG;
        _rigidbody.angularDrag = ANGULARDRAG;
    }
    
    public void DeactivateWaterEffect()
    {
        _rigidbody.drag = 0;
        _rigidbody.angularDrag = 0.05f;
    }
}
