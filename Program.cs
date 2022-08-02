// 1. Print 1-255
static void PrintNumbers()
{
    // Print all of the integers from 1 to 255.
    for( int i = 1; i <= 255; i++ )
    {
        Console.WriteLine( i );
    }
}
PrintNumbers();



// 2. Print odd numbers between 1-255
static void PrintOdds()
{
    // Print all of the odd integers from 1 to 255.
    for( int i = 1; i <= 255; i++ )
    {
        if( i % 2 != 0 )
        {
            Console.WriteLine( i );
        }
    }
}
PrintOdds();



// 3. Print Sum
static void PrintSum()
{
    // Print all of the numbers from 0 to 255, 
    // but this time, also print the sum as you go. 
    // For example, your output should be something like this:
    
    // New number: 0 Sum: 0
    // New number: 1 Sum: 1
    // New number: 2 Sum: 3
    int sum = 0;
    for( int i = 0; i <= 255; i++ )
    {
        sum += i;
        Console.WriteLine( $"New number: {i} Sum: {sum}" );
    }
}
PrintSum();



// 4. Iterating through an Array
static void LoopArray(int[] numbers)
{
    // Write a function that would iterate through each item of the given integer array and 
    // print each value to the console. 
    foreach( int number in numbers )
    {
        Console.WriteLine( number );
    }
}
int[] numbers = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
LoopArray( numbers );



// 5. Find Max
static int FindMax(int[] numbers)
{
    // Write a function that takes an integer array and prints and returns the maximum value in the array. 
    // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
    // or even a mix of positive numbers, negative numbers and zero.
    return numbers.Max();
}
int[] positives = { 3, 5, 7 };
int[] negatives = { -3, -5, -7 };
int[] mix = { -1, 1, 4 };
Console.WriteLine( $"Max of positives: {FindMax( positives )}" );
Console.WriteLine( $"Max of negatives: {FindMax( negatives )}" );
Console.WriteLine( $"Max of mix: {FindMax( mix )}" );



// 6. Get Average
static void GetAverage(int[] numbers)
{
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.
    Console.WriteLine( numbers.Sum() / numbers.Length );
}
int[] nums = { 2, 10, 3 };
GetAverage( nums );



// 7. Array with Odd Numbers
static int[] OddArray()
{
    // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
    // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
    int[] odds = new int[ 256/2 ];
    for( int i = 1; i <= 255; i += 2 )
    {
        odds[ i / 2 ] = i;
    }
    return odds;
}
Console.WriteLine( OddArray() );
int[] arrOfOdd = OddArray();
foreach( int num in arrOfOdd )
{
    Console.WriteLine( num );
}



// 8. Greater than Y
static int GreaterThanY(int[] numbers, int y)
{
    // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
    // That are greater than the "y" value. 
    // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
    // (since there are two values in the array that are greater than 3).
    int count = 0;
    foreach( int num in numbers )
    {
        if( num > y )
        {
            count++;
        }
    }
    return count;
}
int[] testArray = { 1, 3, 5, 7 };
Console.WriteLine( GreaterThanY( testArray, 3 ) );



// 9. Square the Values
static void SquareArrayValues(int[] numbers)
{
    // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
    // For example, [1,5,10,-10] should become [1,25,100,100]
    for( int i = 0; i < numbers.Length; i++ )
    {
        numbers[i] = numbers[i] * numbers[i];
    }
    foreach( int number in numbers )
    {
        Console.WriteLine( number );
    }
}
int[] testSquare = { 1, 5, 10, -10 };
SquareArrayValues( testSquare );



// 10. Eliminate Negative Numbers
static void EliminateNegatives(int[] numbers)
{
    // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
    // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
    for( int i = 0; i < numbers.Length; i++ )
    {
        if( numbers[i] < 0 )
        {
            numbers[i] = 0;
        }
    }
    foreach( int number in numbers )
    {
        Console.WriteLine( number );
    }
}
int[] testNegatives = { 1, 5, 10, -2 };
EliminateNegatives( testNegatives );



// 11. Min, Max, and Average
static void MinMaxAverage(int[] numbers)
{
    // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
    // the minimum value in the array, and the average of the values in the array.
    int min = numbers.Min();
    int max = numbers.Max();
    int sum = 0;
    foreach( int number in numbers )
    {
        sum += number;
    }
    int avg = sum / numbers.Length;
    Console.WriteLine( $"Min: {min}, Max: {max}, Avg: {avg}");
}
int[] minMax = { 1, 5, 10, -2 };
MinMaxAverage( minMax );



// 12. Shifting the values in an array
static void ShiftValues(int[] numbers)
{
    // Given an integer array, say [1, 5, 10, 7, -2], 
    // Write a function that shifts each number by one to the front and adds '0' to the end. 
    // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
    // it should become [5, 10, 7, -2, 0].
    for( int i = 0; i < numbers.Length - 1; i++ )
    {
        numbers[ i ] = numbers[ i + 1 ];
    }
    numbers[ numbers.Length - 1 ] = 0;
    foreach( int number in numbers )
    {
        Console.WriteLine( number );
    }
}
int[] testValues = { 1, 5, 10, 7, -2 };
ShiftValues( testValues );



// 13. Number to String
static object[] NumToString(int[] numbers)
{
    // Write a function that takes an integer array and returns an object array 
    // that replaces any negative number with the string 'Dojo'.
    // For example, if array "numbers" is initially [-1, -3, 2] 
    // your function should return an array with values ['Dojo', 'Dojo', 2].
    object[] answer = new object[ numbers.Length ];
    for( int i = 0; i < numbers.Length; i++ )
    {
        if( numbers[i] < 0 )
        {
            answer[i] = "Dojo";
        }
        else 
        {
            answer[i] = numbers[i];
        }
    }
    return answer;
}
int[] testNumString = { -1, -3, 2 };
object[] numStringArr = NumToString( testNumString );
foreach( object thing in numStringArr )
{
    Console.WriteLine( thing );
}











