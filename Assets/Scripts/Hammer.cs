using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Hammer : MonoBehaviour
{
    public bool Vurdumu = false;
    public CinemachineSmoothPath Path;

    private float _distanceOnPath;
    [SerializeField] private float _lifeCounter = 2;
    [SerializeField] private float _speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Path.EvaluatePositionAtUnit(_distanceOnPath, CinemachinePathBase.PositionUnits.Distance);
        if (!Vurdumu)
        {

        _distanceOnPath += _speed * Time.deltaTime;

        }

        if (_distanceOnPath >= Path.PathLength)
        {
            
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetMouseButton(0) && !Vurdumu)
        {

            if (other.CompareTag("successTrigger"))
            {
                other.GetComponent<heelBehaviour>().isForceAdded = true;
                
               
            }
            else if (other.CompareTag("failTrigger"))
            {
                other.GetComponentInParent<heelBehaviour>().failScenerioOn();
                _lifeCounter--;

            }

            Vurdumu = true;
            
            StartCoroutine(vurdumuCo());
        }
    }

    IEnumerator vurdumuCo()
    {
        yield return new WaitForSeconds(3);
        Vurdumu = false;
        
    }


}
