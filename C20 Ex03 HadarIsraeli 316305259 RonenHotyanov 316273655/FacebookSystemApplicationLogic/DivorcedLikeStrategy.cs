namespace FacebookSystemApplicationLogic
{
    public class DivorcedLikeStrategy : IFactorStrategy
    {
        private int m_Threshold = 5;

        public int CurrentFactors(int i_FirstFactor, int i_SecondFactor)
        {
            return (i_FirstFactor * m_Threshold) + i_SecondFactor;
        }
    }
}
