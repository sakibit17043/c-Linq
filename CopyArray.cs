class CopyArray{
     void PrintArray(int[] array){
    foreach(var item in array){
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
public void Test(){
// int[] orginalArray ={2,3,4,5};
// int[] shallowCopy = orginalArray;
// Console.WriteLine($"Before Modification:");
// PrintArray(orginalArray);
// PrintArray(shallowCopy);
// shallowCopy[0] = 10;
// Console.WriteLine("After Modification:");
// PrintArray(orginalArray);
// PrintArray(shallowCopy);

int[] orginalArray2 ={2,3,4,5};
int[] deepCopy = new int[orginalArray2.Length];
Array.Copy(orginalArray2,deepCopy,orginalArray2.Length);
Console.WriteLine($"Before Modification:");
PrintArray(orginalArray2);
PrintArray(deepCopy);
deepCopy[0] = 10;
Console.WriteLine("After Modification:");
PrintArray(orginalArray2);
PrintArray(deepCopy);

}
}