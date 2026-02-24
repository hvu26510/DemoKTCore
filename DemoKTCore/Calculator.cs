using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKTCore
{
    public class Calculator
    {

        // nhập vào số nguyên n, tính tổng từ 1-n
        // 

        public bool CheckChanLe(int i)
        {
            if(i%2 == 0) return false;
            return true;
        }
        public long Sum1ToN(int n)
        {
            if(n<1) return 0;

            long sum = 0;
            for(int i = 0; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

    }
}
