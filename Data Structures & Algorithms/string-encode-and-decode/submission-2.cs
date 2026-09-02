public class Solution {

    public string Encode(IList<string> strs) 
    {
        string encodedString = "";
	    foreach(string str in strs)
	    {
		    int stringLength = str.Length;
		    encodedString += stringLength;
		    encodedString += '#';
		    encodedString += str;
	    }
	
	    return encodedString;
        }

    public List<string> Decode(string s) 
    {
        		if(s.Length == 2)
	{
		return new List<string>() {""};
	}
    var decodedStrings = new List<string>();

	var readingCount = true;
	string countString = "";
	var count = 0;
	var stringBeingRead = "";
	
	foreach (var character in s)
	{
		if (readingCount)
		{
			if (character == '#')
			{
				count = int.Parse(countString);
				readingCount = false;
				countString = "";
				continue;
			}
			
			countString += character;
		}
		else
		{
            if(count == 0)
			{
				decodedStrings.Add(stringBeingRead);
				stringBeingRead = "";
				readingCount = true;
				countString += character;
				continue;
			}
			stringBeingRead += character;
			
			if (stringBeingRead.Length == count)
			{
				decodedStrings.Add(stringBeingRead);
				stringBeingRead = "";
				readingCount = true;
			}
		}
	}
	
	return decodedStrings;
   }
}
