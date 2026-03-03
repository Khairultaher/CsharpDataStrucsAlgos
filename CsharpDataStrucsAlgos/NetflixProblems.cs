namespace CsharpDataStrucsAlgos;

public class NetflixProblems {
    public static LinkedList<int> MergedTwoSortedLinkList(LinkedList<int> firstList, LinkedList<int> secondList) {
        LinkedList<int> mergedList = new LinkedList<int>();
        var firstNode = firstList.First;
        var secondNode = secondList.First;
        while (firstNode != null && secondNode != null) {
            if (firstNode.Value < secondNode.Value) {
                mergedList.AddLast(firstNode.Value);
                firstNode = firstNode.Next;
            } else {
                mergedList.AddLast(secondNode.Value);
                secondNode = secondNode.Next;
            }
        }
        while (firstNode != null) {
            mergedList.AddLast(firstNode.Value);
            firstNode = firstNode.Next;
        }
        while (secondNode != null) {
            mergedList.AddLast(secondNode.Value);
            secondNode = secondNode.Next;
        }
        return mergedList;
    }
    // Merge K sorted LinkedList<int>
    public static LinkedList<int> MergeKSortedLists(List<LinkedList<int>> lists) {
        if (lists == null || lists.Count == 0)
            return new LinkedList<int>();

        LinkedList<int> result = lists[0];

        for (int i = 1; i < lists.Count; i++) {
            result = MergedTwoSortedLinkList(result, lists[i]);
        }

        return result;
    }


}

public class MedianOfAges {
    PriorityQueue<int, int> maxHeap; // For the first half of the ages
    PriorityQueue<int, int> minHeap; // For the second half of the ages
    public MedianOfAges() {
        maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a,b) => b.CompareTo(a)));
        minHeap = new PriorityQueue<int, int>();
    }

    public void AddAge(int age) {
        if (maxHeap.Count == 0 || age <= maxHeap.Peek()) {
            maxHeap.Enqueue(age, age);
        } else {
            minHeap.Enqueue(age, age);
        }
        // Balance the heaps
        if (maxHeap.Count > minHeap.Count + 1) {
            int movedAge = maxHeap.Dequeue();
            minHeap.Enqueue(movedAge, movedAge);
        } else if (minHeap.Count > maxHeap.Count) {
            int movedAge = minHeap.Dequeue();
            maxHeap.Enqueue(movedAge, movedAge);
        }
    }
    public int GetMedianAge() {
        if (maxHeap.Count == minHeap.Count) {
            return (maxHeap.Peek() + minHeap.Peek()) / 2;
        } else {
            return maxHeap.Peek();
        }
    }
}

public class LRUCache {
    private int capacity;
    private Dictionary<int, LinkedListNode<(int key, int value)>> cache;
    private LinkedList<(int key, int value)> lruList;
    public LRUCache(int capacity) {
        this.capacity = capacity;
        cache = new Dictionary<int, LinkedListNode<(int key, int value)>>();
        lruList = new LinkedList<(int key, int value)>();
    }
    public int Get(int key) {
        if (cache.TryGetValue(key, out var node)) {
            lruList.Remove(node);
            lruList.AddFirst(node);
            return node.Value.value;
        }
        return -1; // Not found
    }
    public void Put(int key, int value) {
        if (cache.TryGetValue(key, out var node)) {
            lruList.Remove(node);
        } else if (cache.Count >= capacity) {
            var lruNode = lruList.Last;
            cache.Remove(lruNode.Value.key);
            lruList.RemoveLast();
        }
        var newNode = new LinkedListNode<(int key, int value)>((key, value));
        lruList.AddFirst(newNode);
        cache[key] = newNode;
    }
}