using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace func 
{
	class Class1
	{
		
		public int fact(int a)
		{
			if (a<=1)
				return 1 ;
			else
				return a*fact(a-1);
		}
	}
}
