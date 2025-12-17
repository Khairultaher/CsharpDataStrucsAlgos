namespace CsharpDataStrucsAlgos;

public class GreedyTechniques {
    /// <summary>
    /// jump game example
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public bool CanJump(int[] nums) {
        int target = nums.Length - 1;
        for (int i = nums.Length - 2; i >= 0; i--) {
            if (target <= i + nums[i])
                target = i;
        }

        if (target == 0)
            return true;

        return false;
    }

    /// <summary>
    /// Calculates the minimum number of boats required to rescue all people, given their individual weights and a
    /// weight limit per boat.
    /// </summary>
    /// <remarks>Each boat can carry at most two people at a time, and the sum of their weights must not
    /// exceed the specified limit. All people must be rescued.</remarks>
    /// <param name="people">An array of integers representing the weights of each person to be rescued. Each value must be non-negative.</param>
    /// <param name="limit">The maximum total weight that a single boat can carry. Must be a positive integer.</param>
    /// <returns>The minimum number of boats needed to rescue all people without exceeding the weight limit per boat.</returns>
    public int RescueBoats(int[] people, int limit) {
        int target = 0;
        // Sort people array ascending
        //Array.Sort(people);
        // sort people array descending
        //Array.Sort(people, (a,b) => b.CompareTo(a));

        Array.Sort(people, (a, b) => a.CompareTo(b));

        int left = 0;
        int right = people.Length - 1;
        while (left <= right) {
            if (people[left] + people[right] <= limit) {
                left++;
                right--;
            }
            else {
                right--;
            }
            target++;
        }
        return target;
    }
    /// <summary>
    /// Find the index of the gas station in the integer array gas such that if we start from that index we may return to the same index by traversing through all the elements
    /// </summary>
    /// <param name="gas"></param>
    /// <param name="cost"></param>
    /// <returns></returns>
    public int GasStationJourney(int[] gas, int[] cost) {

        if (cost.Sum() > gas.Sum())
            return -1;

        int startingIndex = 0;
        int currentGas = 0;

        for (int i = 0; i < gas.Length; i++) {
            currentGas += gas[i] - cost[i];
            if (currentGas < 0) {
                startingIndex = i + 1;
                currentGas = 0;
            }
        }

        return startingIndex;
    }

    public static int MinRefuelStops(int target, int startFuel, int[][] stations) { 

        if(startFuel > target)
            return 0;

        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        int i = 0;
        int n = stations.Length;
        int stops = 0;
        int maxDistance = startFuel;
        while (maxDistance < target) {
            if (i < n && stations[i][1] <= maxDistance) {
                maxHeap.Enqueue(stations[i][1], stations[i][1]);
                i++;
            }
            else if (maxHeap.Count > 0) {
                maxDistance += maxHeap.Dequeue();
                stops++;
            }
            else {
                return -1;
            }
        }
        return stops;
    }
}
