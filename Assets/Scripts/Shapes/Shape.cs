using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Microsoft.MixedReality.Toolkit.Input;

/// <summary>
/// An abstract class which governs behavior of all four shapes
/// </summary>
public class Shape : MonoBehaviour
{
    #region Fields
    private Rigidbody _rb;
    private AudioSource _audioSource;
    #endregion

    #region Methods
    // Start is called before the first frame update
    private void Start()
    {
        _rb = this.gameObject.GetComponent<Rigidbody>();
        _audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void ToggleGravity()
    {
        _rb.useGravity = !_rb.useGravity;
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision coll)
    {
        _audioSource.PlayOneShot(_audioSource.clip);
    }
    #endregion
}
