using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoGame.Graphics
{
    public class SpriteAnimationFrame
    {
        private Sprite _sprite;

        public Sprite Sprite { 
            get
            {
                return _sprite;
            } 
            set
            {
                if (value == null) {
                    throw new ArgumentNullException("value", "O sprite não pode ser nulo.");
                }
                _sprite = value;
            } 
        }

        public float TimeStamp { get; }

        public SpriteAnimationFrame(Sprite sprite, float timeStamp)
        {
            Sprite = sprite;
            TimeStamp = timeStamp;
        }
    }
}
