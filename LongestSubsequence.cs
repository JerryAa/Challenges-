using System; 
using System.Linq; 
using System.Text; 
using System.Collections.Generic; 
/** 

The Challenge 
For example, given the input of S = "abppplee" and D = {"able", "ale", "apple", "bale", "kangaroo"} the correct output would be "apple"
**/ 

namespace Simple 
{ 

	class Run 
	{ 
		/** 

			Algorithm: 
				if S[a] == str[b] 
					add character to word	
						word from above is used to compare the result from the string in d 
					a += 1; 
					b += 1; 
				else 
					a += 1; since we only want to advance the S character once to look	
						ahead from char that wasn't found 

				if (word.Equals(str)) 
					add word to list 
				set word to empty string 
				reset both a and b 

		**/ 

		public static void Main(string [] args) 
		{ 
			string S = "abppplee"; 
			string d =  "able ale apple bale kangaroo"; 

			var lst = subsequence(S, d); 

			foreach(var x in lst) 
			{ 
				Console.WriteLine(x); 
			} 

		} 
		public static List<string> subsequence( string S, string dd) 
		{ 
			List<string> D = new List<string>(dd.Split()); 
			string word = null; 
			List<string> lst = new List<string>(); // store string built and get its length  

			int a = 0; 
			int b = 0; 
			

			foreach(var str in D) // print all the words from D 
			{ 
				while(true) 
				{ 
					if (a >= S.Length || b >= str.Length) // avoid index out of range 
					{ 
						break; 
					} 
					else 
					{ 
						if(S[a] == str[b]) 
						{ 
							word += str[b]; 
							a += 1; 
							b += 1; 
						} 
						else 
						{ 
							a += 1; 
						} 
					} 
				} 

				if(word.Equals(str))  
				{ 
					lst.Add(word); 
				} 
				word = ""; 
				a = 0; 
				b = 0; 
			} 

			return lst; 
		} 
	} 

} 
