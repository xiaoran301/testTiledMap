using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SwapPositionYAndZ : MonoBehaviour
{
    [SerializeField] private GameObject _targetGO;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

#if UNITY_EDITOR

    void OnValidate()
    {
        if (_targetGO != null)
        {
            Vector3 oldPos;
            var transforms = _targetGO.GetComponentsInChildren<Transform>();
            foreach (var transform in transforms)
            {
                oldPos = transform.localPosition;
                transform.localPosition.Set(oldPos.x, oldPos.z, oldPos.y);
            }

            oldPos = _targetGO.transform.localPosition;
            _targetGO.transform.localPosition.Set(oldPos.x, oldPos.z, oldPos.y);
        }
    }

#endif
}