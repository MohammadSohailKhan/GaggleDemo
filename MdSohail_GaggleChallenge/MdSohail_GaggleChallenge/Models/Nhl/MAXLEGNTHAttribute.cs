using System;

namespace MdSohail_GaggleChallenge.Models.Nhl
{
    internal class MAXLENGNTH : Attribute
    {
        private int v;

        public MAXLENGNTH(int v)
        {
            this.v = v;
        }
    }
}