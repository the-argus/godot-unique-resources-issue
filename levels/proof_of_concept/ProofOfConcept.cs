using Godot;

namespace Escort.Combat.Scenes
{
	public partial class ProofOfConcept : Node
	{
		public override void _Ready()
		{
			// screenshake whenever an enemy gets hit
			Escort.Combat.EnemyBasic.EnemyBasic.GlobalHit += () => { Camera.Singleton().shaker.Shake(new CameraShaker.ScreenShake(2, 100)); };
		}
	}
}
