using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//之前的题目具体数字记得不是很清楚了，所以我自己设了几个数字，
//起步距离2公里，起步价10元，2公里到8公里之间每公里1元，8公里
//以后每公里1.2元，等时费是每分钟0.5元
namespace Calculator
{
    public class Calculator
    {
        private double fee_for_first_step = 10; //起步价10元
        private double length_for_first_step = 2; //起步距离是2公里
        private double fee_for_ordinary_travel = 1; // 2公里以后8公里以内每公里收1元
        private double length_for_ordinary_travel = 8; // 2公里以后8公里以内每公里收1元
        private double fee_for_high_travle = 1.2; //8公里以后每公里收1.2元
        private double fee_for_wait = 0.5; //每等1分钟收0.5元
        public double Calculate(double length, double time = 0)
        {
            return feeForFirstStep(length) +
                   feeForOrdinary(length) +
                   feeForHigh(length) +
                   feeForWait(time);
        }

        //起步价
        private double feeForFirstStep(double length)
        {
            return fee_for_first_step;
        }

        //2公里以外8公里以内的收费
        private double feeForOrdinary(double length)
        {
            if(length <= length_for_first_step)
            {
                return 0;
            }else if(length <= length_for_ordinary_travel)
            {
                return (length - length_for_first_step) * fee_for_ordinary_travel;
            }
            else
            {
                return (length_for_ordinary_travel - length_for_first_step) * fee_for_ordinary_travel;
            }
        }

        //8公里以外的收费
        private double feeForHigh(double length)
        {
            if(length <= length_for_ordinary_travel)
            {
                return 0;
            }
            else
            {
                return (length - length_for_ordinary_travel) * fee_for_high_travle;
            }
        }

        //等时费
        private double feeForWait( double time)
        {
            return time * fee_for_wait;
        }
    }
}
