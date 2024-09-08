using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Camera _cam;
    [SerializeField] private Transform _turret;
    [SerializeField] private Transform _barrel;
    [SerializeField] private LayerMask _bgLayer;

    [SerializeField, Range(1f, 100f)] private float _horizontalRotationSpeed;
    [SerializeField, Range(1f, 100f)] private float _verticalRotationSpeed;

    private void LateUpdate()
    {
        RaycastHit hit;
        Ray ray = _cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 1000f, _bgLayer))
        {
            Vector3 dir = hit.point - transform.position;
            Vector3 xz = dir;
            xz.y = 0;

            _turret.rotation = Quaternion.RotateTowards(_turret.rotation, Quaternion.LookRotation(xz), _horizontalRotationSpeed * Time.deltaTime);
            _barrel.rotation = Quaternion.RotateTowards(_barrel.rotation, Quaternion.LookRotation(dir), _verticalRotationSpeed * Time.deltaTime);
        }
    }
}
