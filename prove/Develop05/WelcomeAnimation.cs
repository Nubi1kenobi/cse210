using System;
public class WelcomeAnimation
    {
    private int _delay;
    private int _delay2;
    private int _fade;
    private int _loopCount;
    private string[] _animation;
    private string[] _anotherAnimation;

        public WelcomeAnimation()
            {
                _delay = 1000;
                _delay2 = 1000;
                _fade = 0;
                _loopCount = 1;
                _animation = new string[0];
                _anotherAnimation = new string[0];
            }
        public WelcomeAnimation(int delay, int fade, int loopCount, string[] animation, string[] anotherAnimation)
            {
                _delay = delay;
                _delay2 = delay;
                _fade = fade;
                _loopCount = loopCount;
                _animation = animation;
                _anotherAnimation = anotherAnimation;
            }
        public void Animate()
            {
                Console.CursorVisible = false;
                for (int a = _loopCount; a > 0; a--)
                    {
                        int b = 0;
                        foreach (string animateDotMe in _animation)
                            {
                                Console.Clear();
                                Console.WriteLine(_animation[b]);
                                b++;
                                _delay2 = _delay2 - _fade;
                                if (_delay2 is < 100) { _delay2 = 100;}
                                Thread.Sleep(_delay2);
                            }
                        int c = 0;
                        Console.Clear();
                        foreach (string animateDotMeAgain in _anotherAnimation)
                            {                
                                Console.Write(_anotherAnimation[c]);
                                c++;
                                _delay = _delay - _fade;
                                if (_delay is < 100) { _delay = 100;}
                                Thread.Sleep(_delay);
                            }
                    }
                Thread.Sleep(500);
                Console.Clear();
                Console.CursorVisible = true;
            }
    }