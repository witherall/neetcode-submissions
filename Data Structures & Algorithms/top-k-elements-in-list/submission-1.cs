public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int, int> frequencyDict = new Dictionary<int, int>();
	    List<int>[] freq = new List<int>[nums.Length + 1];

	    foreach (int num in nums)
	    {
		    if (!frequencyDict.ContainsKey(num))
		    {
			    frequencyDict[num] = 0;
		    }

		    frequencyDict[num]++;
	    }

	    foreach (var kvp in frequencyDict)
    	{
    		int count = kvp.Value;
    		if (freq[count] == null)
    		{
    			freq[count] = new List<int>();
    		}

        	freq[count].Add(kvp.Key);
    		Console.WriteLine(freq[count]);
	    }

	    var result = new List<int>();
	
    	for (int i = freq.Length - 1; i >= 0; i--)
    	{
	    	if(freq[i] == null)
	    	{
	    		continue;
		    }
	    	foreach (var n in freq[i])
	    	{
	    		result.Add(n);
	    		if (result.Count == k)
			    {
			    	return result.ToArray();
			    }
	    	}
    	}

	    return result.ToArray();
    }
}
