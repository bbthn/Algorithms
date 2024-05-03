

namespace Algorithms
{
    public static class Polindrome
    {
        static bool isPolidrome(int x)
        {
            // Negatif sayılar ve 10'un katları olan sayılar palindrom olamaz.
            if (x < 0 || (x != 0 && x % 10 == 0))
            {
                return false;
            }

            int reversedNumber = 0;
            int originalNumber = x;

            // Sayının rakamlarını tersine çeviriyoruz.
            while (x > 0)
            {
                reversedNumber = (reversedNumber * 10) + (x % 10);
                x /= 10;
            }

            // Tersine çevrilen sayı ile orijinal sayıyı karşılaştırıyoruz.
            return originalNumber == reversedNumber;

        }
    }
}
