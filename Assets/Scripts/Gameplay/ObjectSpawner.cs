using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.UI;

public class ObjectSpawner : MonoBehaviour
{
    #region Serialized Fields
    [SerializeField]
    Shape prefabCapsule;

    [SerializeField]
    Shape prefabCube;

    [SerializeField]
    Shape prefabCylinder;

    [SerializeField]
    Shape prefabSphere;
    #endregion

    #region Fields
    // Minimum and maximum distance for holograms in meters
    const float MinDistance = 0.85f;
    const float MaxDistance = 2.0f;

    private float _spawnDistance;
    private ShapeType _activeShape;
    #endregion

    #region Properties
    public float SpawnDistance
    {
        get { return _spawnDistance; }
    }
    #endregion

    #region Methods
    // Start is called before the first frame update
    void Start()
    {
        // Start spawn distance at 1 meter
        _spawnDistance = 1.0f;
    }

    // Update keeps the current gaze as a vector, because of weirdness in spawning doing it otherwise

    public void SpawnObject()
    {
        // Separate method call because you can't use new on a MonoBehaviour
        Shape newShape = SpawnShape();

        // put new shape at spawn position
        Vector3 origin = CoreServices.InputSystem.EyeGazeProvider.GazeOrigin;
        Vector3 spawnVector = CoreServices.InputSystem.EyeGazeProvider.GazeDirection.normalized * _spawnDistance;
        Vector3 newPosition = origin + spawnVector;
        newShape.transform.position = newPosition;
    }

    public void UpdateDistance(SliderEventData eventData)
    {
        _spawnDistance = (eventData.NewValue * (MaxDistance - MinDistance)) + MinDistance;
    }

    public void UpdateShape(string shape)
    {
        switch (shape)
        {
            case "Capsule":
                _activeShape = ShapeType.Capsule;
                break;
            case "Cube":
                _activeShape = ShapeType.Cube;
                break;
            case "Cylinder":
                _activeShape = ShapeType.Cylinder;
                break;
            default:
                _activeShape = ShapeType.Sphere;
                break;
        }
    }

    private Shape SpawnShape()
    {
        switch (_activeShape)
        {
            case ShapeType.Capsule:
                Shape newShape = Instantiate(prefabCapsule);
                return newShape;
            case ShapeType.Cube:
                newShape = Instantiate(prefabCube);
                return newShape;
            case ShapeType.Cylinder:
                newShape = Instantiate(prefabCylinder);
                return newShape;
            default:
                newShape = Instantiate(prefabSphere);
                return newShape;
        }
    }
    #endregion
}
