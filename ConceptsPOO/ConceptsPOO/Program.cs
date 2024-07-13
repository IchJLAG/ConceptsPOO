


using ConceptsPOO;

Console.WriteLine("Primeros pasos");
Console.WriteLine("============");

try
{
	Console.WriteLine(new Date(2022, 02, 22));
	Console.WriteLine(new Date(2024, 07, 04));
	Console.WriteLine(new Date(2024, 11, 22));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}