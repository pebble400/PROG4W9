using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class SeekAT : ActionTask 
	{
		public BBParameter<Transform> seekTarget;
		public BBParameter<Vector3> moveDirection;
		[MinValue(0f)] public float weight;
		
		protected override void OnUpdate()
		{
			moveDirection.value += (seekTarget.value.position - agent.transform.position).normalized * weight;
		}
	}
}