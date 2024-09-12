namespace Knowledge_Check_2
{
	public class MyClass
	{
		public virtual string Property { get; set; }
		public override string ToString()
		{
			return $"Property: {Property}";
		}
	}

	/*ChildClass inherits from MyClass so it can call the string "Property". both properties have overrides so ToString() can include the values
	of both properties to the list.*/

	public class ChildClass : MyClass
	{
		public string AdditionalProperty { get; set; }

		public override string ToString()
		{
			return $"Property: {Property}, Additional Property: {AdditionalProperty}";
		}
	}
}