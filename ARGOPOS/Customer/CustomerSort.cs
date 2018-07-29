using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARGOPOS.Customer
{
    public static class CustomerSort
    {
        private static void Quick_Sort( ref pos_customer[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(ref arr, left, right);

                if (pivot > 1)
                {
                    Quick_Sort(ref arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    Quick_Sort( ref arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(ref pos_customer[] arr, int left, int right)
        {
            decimal pivot = arr[left].loyaltypoint;
            while (true)
            {

                while (arr[left].loyaltypoint < pivot)
                {
                    left++;
                }

                while (arr[right].loyaltypoint > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    pos_customer temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
    }
}
