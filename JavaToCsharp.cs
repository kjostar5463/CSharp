using System;

namespace JavaToCsharp
{
	public interface Stack
	{
		bool isEmpty();
		void push(char item);
		char pop();
		void delete();
		char peek();
	}

	public class StackNode
	{
		public char data;
		public StackNode link;
	}

	public class LinkedStack : Stack
	{
		private StackNode top;

		public bool isEmpty()
		{
			return (top == null);
		}

		public void push(char item)
		{
			StackNode newNode = new StackNode();
			newNode.data = item;
			newNode.link = top;
			top = newNode;
			// System.out.println("Inserted Item : " + item);
		}

		public char pop()
		{
			if (isEmpty())
			{
				Console.WriteLine("Deleting fail! Linked Stack is empty!!");
				return (char)0;
			}
			else
			{
				char item = top.data;
				top = top.link;
				return item;
			}
		}

		public void delete()
		{
			if (isEmpty())
			{
				Console.WriteLine("Deleting fail! Linked Stack is empty!!");

			}
			else
			{
				top = top.link;
			}
		}

		public char peek()
		{
			if (isEmpty())
			{
				Console.WriteLine("Peeking fail! Linked Stack is empty!!");
				return (char)0;
			}
			else
				return top.data;
		}

		public void printStack()
		{
			if (isEmpty())
				Console.WriteLine("Linked Stack is empty!! %n %n");
			else
			{
				StackNode temp = top;
				Console.WriteLine("Linked Stack>> ");
				while (temp != null)
				{
					Console.WriteLine("\t %c \n", temp.data);
					temp = temp.link;
				}
				Console.WriteLine();
			}
		}
	}

	public class OptExp
	{
		private String exp;
		private int expSize;
		private char testCh, openPair;
	
		public bool testPair(String exp)
		{
			this.exp = exp;
			LinkedStack S = new LinkedStack();
			expSize = this.exp.Length;
			for (int i = 0; i < expSize; i++)
			{
				testCh = this.exp[i];
				switch (testCh)
				{
					case '(':
					case '{':
					case '[':
						S.push(testCh);
						break;
					case ')':
					case '}':
					case ']':
						if (S.isEmpty())
							return false;
						else
						{
							openPair = S.pop();
							if ((openPair == '(' && testCh != ')') || (openPair == '{' && testCh != '}')
									|| (openPair == '[' && testCh != ']'))
								return false;
							else
								break;
						}
				}
			}
			if (S.isEmpty())
				return true;
			else
				return false;
		}
	}
	
	public class BracketTest
	{
	
		public static void Main(String[] args)
		{
			OptExp opt = new OptExp();
			String exp = "(3*5)-6/2)";
	
			Console.WriteLine(exp);
	
			if (opt.testPair(exp))
				Console.WriteLine("괄호 맞음!!");

           		else
				Console.WriteLine("괄호 틀림!!");

			//Console.ReadLine(); 출력 테스트
		}
	}
}
