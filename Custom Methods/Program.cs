

#region Custom Contains
using Custom_Methods;

string customContains = "Bu bir custom contains methudodur";

Console.WriteLine(customContains.CustomContains("tains"));
#endregion




#region Custom Split
string customSplit = "Bu bir custom slip methodudur";

string[] arraystring = customSplit.CustomSplit();


foreach (var item in arraystring)
{

    Console.WriteLine(item);

}
#endregion