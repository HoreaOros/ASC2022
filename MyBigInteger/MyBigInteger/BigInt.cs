using System;
using System.Collections.Generic;
using System.Text;

namespace MyBigInteger
{
    public class BigInt
    {
        private string data;
        private List<byte> digits;
        private int sign;

        public BigInt()
        {
            sign = 1;
            data = string.Empty;
            digits = new List<byte>();
        }

        public BigInt(string v)
        {
            this.data = v;
            if (!isValid(v))
            {
                throw new FormatException();
            }
            sign = 1;
            if (data[0] == '-')
            {
                sign = -1;
            }
            if (data[0] == '-' || data[0] == '+')
            {
                data = data.Substring(1);
            }
            digits = new List<byte>();
            for (int i = data.Length - 1; i >= 0; i--)
            {
                digits.Add((byte)(data[i] - '0'));
            }
        }

        private bool isValid(string v)
        {
            string acceptedChar = "+-0123456789";
            foreach (var item in v)
            {
                if (acceptedChar.IndexOf(item) == -1)
                {
                    return false;
                }
            }
            return true;
        }
        public static BigInt operator +(BigInt a, BigInt b)
        {
            BigInt result = new BigInt();
            int d1, d2;
            for (int i = 0, carry = 0; i < a.digits.Count || i < b.digits.Count || carry == 1; i++)
            {
                d1 = i < a.digits.Count ? a.digits[i] : 0;
                d2 = i < b.digits.Count ? b.digits[i] : 0;
                result.digits.Add((byte)((d1 + d2 + carry) % 10));
                carry = (d1 + d2 + carry) / 10;
            }

            return result;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = digits.Count - 1; i >=0 ; i--)
            {
                sb.Append(digits[i].ToString());
            }
            return sb.ToString();
        }
        // TODO
        public static BigInt operator-(BigInt a, BigInt b)
        {
            throw new NotImplementedException();
        }
        public static BigInt operator *(BigInt a, BigInt b)
        {
            throw new NotImplementedException();
        }
        public static BigInt operator %(BigInt a, BigInt b)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Impartire intreaga - rezulatul va fi catul impartirii
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static BigInt operator /(BigInt a, BigInt b)
        {
            throw new NotImplementedException();
        }


        public static BigInt operator ==(BigInt a, BigInt b)
        {
            throw new NotImplementedException();
        }
        public static BigInt operator !=(BigInt a, BigInt b)
        {
            throw new NotImplementedException();
        }
        public static BigInt operator <(BigInt a, BigInt b)
        {
            throw new NotImplementedException();
        }
        public static BigInt operator >(BigInt a, BigInt b)
        {
            throw new NotImplementedException();
        }
        public static BigInt operator <=(BigInt a, BigInt b)
        {
            throw new NotImplementedException();
        }
        public static BigInt operator >=(BigInt a, BigInt b)
        {
            throw new NotImplementedException();
        }
    }
}