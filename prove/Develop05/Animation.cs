using System;
public abstract class Animation
    {
    private int _delay;
    private int _fade;
    private int _loopCount;
    private string[] _animation;

        public Animation()
            {
                _delay = 1000;
                _fade = 0;
                _loopCount = 1;
                _animation = [];
            }
        public Animation(int delay, int fade, int loopCount, string[] animation)
            {
                _delay = delay;
                _fade = fade;
                _loopCount = loopCount;
                _animation = animation;
            }
        public abstract void Animate();
    }