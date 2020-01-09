using System;
using System.Collections.Generic;
using System.Collections;

namespace phonemvc
{
public class Book
	{
		public string title { get; set; }
    public string author { get; set; }
    public double price { get; set; }
    public int inStock { get; set; }
	}
	
	public class Books
	{
		 public List<Book> books { get; set; }
	}

}