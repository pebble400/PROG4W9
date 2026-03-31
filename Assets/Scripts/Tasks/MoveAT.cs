using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class MoveAT : ActionTask
	{
		public BBParameter<Vector3> moveDirection;
		public BBParameter<float> moveSpeed;
		public BBParameter<float> turnSpeed;
		
		protected override void OnUpdate() 
		{
			Vector3 planar = new Vector3(moveDirection.value.x, 0, moveDirection.value.z);

			Quaternion desiredRotation = Quaternion.LookRotation(planar);
			Quaternion currentRotation = agent.transform.rotation;

			agent.transform.rotation = Quaternion.RotateTowards(currentRotation, desiredRotation, turnSpeed.value * Time.deltaTime);
			agent.transform.position += moveSpeed.value * Time.deltaTime * agent.transform.forward;

			moveDirection.value = Vector3.zero;
		}
	}
}