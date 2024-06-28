using System;
public class Animation
    {
        int _delay;
        int _fade;
        int _loopCount;
        string[] _animation;

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
        public void Animate()
            {
                Console.CursorVisible = false;
                for (int a = _loopCount; a > 0; a--)
                    {
                        int b = 0;
                        foreach (string animateDotMe in _animation)
                            {
                                ;Console.Clear();
                                Console.WriteLine(_animation[b]);
                                b++;
                                _delay = _delay - _fade;
                                if (_delay is < 150) { _delay = 150;}
                                Thread.Sleep(_delay);
                                                            }
                    }
                Console.CursorVisible = true;
            } 

    }