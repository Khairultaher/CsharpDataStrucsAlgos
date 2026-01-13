using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CsharpDataStrucsAlgos.Educative_99;

public class FirstAndSlowPointers {
    public static int SumOfSquaredDisits(int num) { 
        int totalSum = 0;
        while (num > 0) { 
            int disit = num % 10;
            num = num / 10;
            //totalSum += disit * disit;
            totalSum += (int)Math.Pow(disit, 2);
        }
        return totalSum;
    }

    public static bool IsHappyNumber(int num) {
        int slow = num;
        int fast = num;
        do {
            slow = SumOfSquaredDisits(slow);
            fast = SumOfSquaredDisits(SumOfSquaredDisits(fast));
        } while (slow != fast);
        return slow == 1;
    }

    public static int BinarySearchRoteted(int[] nums, int target) { 
        int low = 0; int high = nums.Length - 1;
        while (low <= high) {
            int mid = low + (high - low) / 2;
            if (nums[mid] == target) {
                return mid;
            }
            if (nums[low] <= nums[mid]) {
                if (nums[low] <= target && target < nums[mid]) { 
                    high = mid - 1;
                }
                else { 
                    low = mid + 1;  
                }
            }
            else {
                if (nums[mid] < target && target <= nums[high]) {
                    
                }
            }
        }
        return -1;
    }
}
