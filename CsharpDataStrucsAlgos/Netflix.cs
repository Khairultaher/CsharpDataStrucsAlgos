namespace CsharpDataStrucsAlgos;

public class Netflix {

    public static List<List<string>> GroupTitles(string[] strs) {
        if(strs.Length == 0)
            return new List<List<string>>();

        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();
        int[] count = new int[26];

        foreach(string s in strs) {
            Array.Fill(count, 0);
            foreach(char c in s) {
                count[c - 'a']++;
            }
            string key = string.Join("#", count);
            if(!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }
            map[key].Add(s);
        }

        return new List<List<string>>(map.Values.ToList());
    }
    public static LinkedList<int> MergeSortedLists(List<LinkedList<int>> lists) {
        if (lists.Count > 0) { 
            LinkedList<int> res = lists[0];
            for (int i = 1; i < lists.Count; i++) {
                res = MergeTwoSortedList(res, lists[i]);
            }
            return res;
        }

        return new LinkedList<int>();
    }
    public static LinkedList<int> MergeTwoSortedList(LinkedList<int> l1, LinkedList<int> l2) { 
        LinkedList<int> res = new LinkedList<int>();
        
        var node1 = l1.First;
        var node2 = l2.First;
        while(node1 != null && node2 != null) {
            if(node1.Value < node2.Value) {
                res.AddLast(node1.Value);
                node1 = node1.Next;
            } else {
                res.AddLast(node2.Value);
                node2 = node2.Next;
            }
        }

        while(node1 != null) {
            res.AddLast(node1.Value);
            node1 = node1.Next;
        }
        while(node2 != null) {
            res.AddLast(node2.Value);
            node2 = node2.Next;
        }
        return res;
    }
}
