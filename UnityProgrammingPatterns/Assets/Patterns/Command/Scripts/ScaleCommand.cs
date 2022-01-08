using System;

namespace Patterns.Command.Scripts
{
    public class ScaleCommand : Command
    {
        private readonly float _scaleFactor;
        
        public ScaleCommand(IEntity entity, float scaleDirection) : base(entity)
        {
            _scaleFactor = Math.Abs(scaleDirection - 1f) < 0.003 ? 1.1f : 0.9f;
        }

        public override void Execute()
        {
            _entity.transform.localScale *= _scaleFactor;
        }

        public override void Undo()
        {
            _entity.transform.localScale /= _scaleFactor;
        }
    }
}