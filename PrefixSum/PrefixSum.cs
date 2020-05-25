using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrefixSum
{
    class PrefixSum
    {
        public int[] Input { set; get; }

        public int[] Output
        {
            get
            {
                if (_flag)
                {
                    _tmpArray[0] = Input[0];
                    return _tmpArray;
                }
                else
                {
                    return Input; // Input array now contains result (prefix sum)
                }
            }
        }

        public void Calculate()
        {
            int n;

            n = Input.Length;
            _tmpArray = new int[n];

            for (_j = 0; _j <= (int)Math.Ceiling(Math.Log(n, 2)) - 1; _j++)
            {
                _flag = !_flag;
                if (_flag)
                {
                    for (int i = 0; i <= (int)Math.Pow(2,_j)-1; i++)
                    {
                        _tmpArray[i] = Input[i];
                    }
                }
                else
                {
                    for (int i = 0; i <= (int)Math.Pow(2,_j)-1; i++)
                    {
                        Input[i] = _tmpArray[i];
                    }

                }
                System.Threading.Tasks.Parallel.For((int)Math.Pow(2, _j) + 1, n + 1, ForBody);
            }
        }

        private int[] _tmpArray;
        private int _j; // Loop index
        private bool _flag = false;
        private void ForBody(int i)
        {
            if (_flag)
                _tmpArray[i - 1] = Input[i - 1] + Input[i - (int)Math.Pow(2, _j) - 1];
            else
                Input[i - 1] = _tmpArray[i - 1] + _tmpArray[i - (int)Math.Pow(2, _j) - 1];
        }

    }
}