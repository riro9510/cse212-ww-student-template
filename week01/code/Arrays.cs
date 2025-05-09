using System;
using System.Linq;
public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        // Plan for create MultiplesOf:
        // Crete and array of numbers between 1 - number of multiplers
        // Multiply each of them for the first number
        // Return the numbers

        var numbers = Enumerable.Range(1,length);
        var results = numbers.Select(num => num * number).ToArray();

        return results; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    /// 
   
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
         /// SOlution:
    /// Split in the list in length - amount
    /// put together the split data but now with the second part at the begginning.
    /// 
    /// 
    /// 
    /// After the testing was cleart to me that  the solution should also change the original value in data, because is a void function
        var split1 = data.Take(data.Count - amount).ToArray(); 
        var split2 = data.Skip(data.Count - amount).ToArray();
        var rotated = split2.Concat(split1).ToList();

       data.Clear();
       data.AddRange(rotated);

    }


}
