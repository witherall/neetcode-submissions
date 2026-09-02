public class Solution {

    public string Encode(IList<string> strs) 
	{
        var encodedString = "";
		foreach(var str in strs)
		{
			encodedString += str.Length + "#" + str;
		}
		Console.WriteLine(encodedString);
		return encodedString;
    }

    public List<string> Decode(string s)
	{
		var decodedStrings = new List<string>();

		int i = 0;
		int j = 0;
		while(i < s.Length)
		{
			j = i;
			
			while (s[j] != '#')
			{
				j++;
			}

			var length = int.Parse(s.Substring(i, j - i));
			var str = s.Substring(j + 1, length);
			Console.WriteLine(str);
			decodedStrings.Add(str);
			i=j + length + 1;
		}

		return decodedStrings;
	}
}
