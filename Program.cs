/*
5. Write a C# Sharp program in to count duplicate elements in an array.
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 5
element - 1 : 1
element - 2 : 1
Expected Output :
Total number of duplicate elements found in the array is : 1
*/
Console.WriteLine("How many elements do you want the array to be?");
int length = Convert.ToInt32 (Console.ReadLine());
int[] numbers = new int[length];
int[] dupes = new int[length];

Console.WriteLine("Please input " + length + " elements");

for (int i = 0; i < numbers.Length; i++){
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
if (length == 1){
    Console.WriteLine("The number is");
}
else{
    Console.WriteLine("The numbers are");
}
int numdupes = 0;
for (int j = 0; j < numbers.Length; j++){
    int lolololol = numbers[j];
    bool duped = false;
    for (int k = 0; k < dupes.Length; k++)
    {
        if (dupes[k] == lolololol) {
            numdupes++;
            duped = true;
        }
    }
    if (!duped) {
        dupes[dupes.Length + 1] = lolololol;
    }
}