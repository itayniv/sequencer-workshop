using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {
	private int waveNumber;
	public float distanceX, distanceZ;
	public float[] waveAmplitude;
	public float magnitudeDivider;
	public Vector2[] impactPos;
	public float[] distance;
	public float speedWaveSpread;

    public GameObject soundGeneration;


	Mesh mesh;
	// Use this for initialization
	void Start () {
		mesh = GetComponent<MeshFilter>().mesh;
        soundGeneration = GameObject.FindWithTag("soundGeneration");

	}
	
	// Update is called once per frame
	void Update () {
	
		for (int i=0; i<8; i++){

			waveAmplitude[i] = GetComponent<Renderer>().material.GetFloat("_WaveAmplitude" + (i+1));
			if (waveAmplitude[i] > 0)

			{
				distance[i] += speedWaveSpread;
				GetComponent<Renderer>().material.SetFloat("_Distance" + (i+1), distance[i]);
				GetComponent<Renderer>().material.SetFloat("_WaveAmplitude" + (i+1), waveAmplitude[i] * 0.98f);
			}
			if (waveAmplitude[i] < 0.01)
			{
				GetComponent<Renderer>().material.SetFloat("_WaveAmplitude" + (i+1), 0);
				distance[i] = 0;
			}

		}
	}

	void OnCollisionEnter(Collision col){
		if (col.rigidbody)
		{
			waveNumber++;
			if (waveNumber == 9){
				waveNumber = 1;
			}

            Debug.Log(col.gameObject.transform.position);

            //Vector3 hitPosition = col.position;
            soundGeneration.GetComponent<ProceduralAudioController>().playVariables(col.gameObject.transform.position);


			waveAmplitude[waveNumber-1] = 0;
			distance[waveNumber-1] = 0;

            //Debug.Log(col.gameObject.transform.position.x + " " + col.gameObject.transform.position.z);
            //Debug.Log(col.rigidbody.velocity.magnitude);

			distanceX = this.transform.position.x - col.gameObject.transform.position.x;
			distanceZ = this.transform.position.z - col.gameObject.transform.position.z;

            //Debug.Log(distanceX + " " + distanceZ);

			impactPos[waveNumber - 1].x = col.transform.position.x;
			impactPos[waveNumber - 1].y = col.transform.position.z;

			GetComponent<Renderer>().material.SetFloat("_xImpact" + waveNumber, col.transform.position.x);
			GetComponent<Renderer>().material.SetFloat("_zImpact" + waveNumber, col.transform.position.z);

			GetComponent<Renderer>().material.SetFloat("_OffsetX" + waveNumber, distanceX / mesh.bounds.size.x * 2.5f);
			GetComponent<Renderer>().material.SetFloat("_OffsetZ" + waveNumber, distanceZ / mesh.bounds.size.z * 2.5f);

			GetComponent<Renderer>().material.SetFloat("_WaveAmplitude" + waveNumber, col.rigidbody.velocity.magnitude * magnitudeDivider);

		}
	}


    public void rippleClick( Vector3 clickPosition )
    {
        //Debug.Log("click" + clickPosition);
            waveNumber++;
            if (waveNumber == 9)
            {
                waveNumber = 1;
            }

            waveAmplitude[waveNumber - 1] = 0;
            distance[waveNumber - 1] = 0;

            //Debug.Log(clickPosition.x + " " + clickPosition.z);
            //Debug.Log(distanceX + " " + distanceZ);

             distanceX = this.transform.position.x - clickPosition.x;
             distanceZ = this.transform.position.z - clickPosition.z;

            ////Debug.Log(distanceX + " " + distanceZ);

             impactPos[waveNumber - 1].x = clickPosition.x;
             impactPos[waveNumber - 1].y = clickPosition.z;

            GetComponent<Renderer>().material.SetFloat("_xImpact" + waveNumber, clickPosition.x);
            GetComponent<Renderer>().material.SetFloat("_zImpact" + waveNumber, clickPosition.z);

            GetComponent<Renderer>().material.SetFloat("_OffsetX" + waveNumber, distanceX / mesh.bounds.size.x * 2.5f);
            GetComponent<Renderer>().material.SetFloat("_OffsetZ" + waveNumber, distanceZ / mesh.bounds.size.z * 2.5f);

            //GetComponent<Renderer>().material.SetFloat("_WaveAmplitude" + waveNumber, col.rigidbody.velocity.magnitude * magnitudeDivider);
            GetComponent<Renderer>().material.SetFloat("_WaveAmplitude" + waveNumber, 27.4f * magnitudeDivider);

    }




}
