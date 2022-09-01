using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class heelBehaviour : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    public bool isForceAdded = false;
    private Vector3 targetPos;
    private heelManager _heelManager;
    private Rigidbody rb;
    
    


    public void Initialize(heelManager heelManager)
    {
        _heelManager = heelManager;
    }


    

    void Start()
    {

       // targetPos = transform.position + new Vector3(0f, 0f, 10f);
        rb = GetComponent<Rigidbody>();
      

    }

  
    void Update()
    {
        if (isForceAdded)
        {
            transform.DOMove(transform.position + new Vector3(0f, 0f, 10f), 3).OnComplete(() => { isForceAdded = false; gameObject.SetActive(false); });

        }


    }


    public void failScenerioOn()
    {
        Debug.Log("sa girdim");
      
        _animator.SetBool("shake", true);
        


    }




}
