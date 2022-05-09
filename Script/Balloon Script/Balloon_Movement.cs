using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon_Movement : MonoBehaviour
{
    [SerializeField] Vector3 movement;
	//[SerializeField] Rigidbody2D rigid;
	[SerializeField] float speed = 10.0f;
	[SerializeField] bool isFacingLeft = true;

   
    public Vector3 pointB;
   
    IEnumerator Start()
    {
        var pointA = transform.position;
        while(true)
        {
            yield return StartCoroutine(MoveObject(transform, pointA, pointB, 1.0f));
            Flip();
            yield return StartCoroutine(MoveObject(transform, pointB, pointA, 1.0f));
            Flip();
        }
    }
   
    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
    {
        var i= 0.0f;
        var rate= 1.0f/time;
        while(i < 1.0f)
        {
            i += Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }
    }

    

    void Flip()
	{
		Vector3 playerScale = transform.localScale;
		playerScale.x = playerScale.x * -1;
		transform.localScale = playerScale;

        isFacingLeft = !isFacingLeft;
	}
}
