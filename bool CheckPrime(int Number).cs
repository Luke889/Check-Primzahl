bool CheckPrime(int Number)
{
    for (int i = 2; i <= Number - 1; i++)
    {
        if (Number % i == 0) return true;
    }
    return false;
}