namespace _17._6._6
{
    internal class SalaryAccount: Account, ICalculateInterest
    {
        public void CalculateInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;
        }
    }
}