using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] BoxCollider spawnArea;

    // Reference to Game Manager script
    [SerializeField] GameManager manager;

    // LERP
    [SerializeField] Transform startPoint;
    [SerializeField] Transform endPoint;
    [SerializeField] float speed;

    //Value between 0 and 1
    [SerializeField] float interpolationAmount;
    private void OnCollisionEnter(Collision collision)
    {
        //if the objects with the tag "foodItem"
        if (collision.transform.CompareTag("foodItem"))
        {
            //Destroy object when collide
            Destroy(collision.gameObject);

            //Change the position
            MoveToRandomPosition();

            //Call Add a point method
            manager.AddPoint();
        }
    }

    void MoveToRandomPosition()
    {
        // var en C# se utiliza para declarar una variable sin especificar explícitamente su tipo de datos.
        // bounds.min y bounds.max. Estas propiedades devuelven los límites mínimos y máximos del collider en cada eje (x, y, z).
        var x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
        var y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
        var z = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);

        // La nueva posicion en los nuevos x, y, x

        transform.position = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        //If the interpolation amount is greater than 1...
        //if(interpolationAmount > 1)
        //{
        //    /// ... bring it back to 0
        //    interpolationAmount = 0;
        //}

        // Increment by the speed value
        interpolationAmount += speed;

        //Set Position
        //Lerp = Midpoint start point and end point 

        transform.position = Vector3.Lerp(startPoint.position, endPoint.position, interpolationAmount);
    }
}
