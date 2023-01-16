// Given an integer array nums, 
// return true if any value appears at least twice in the array, 
//and return false if every element is distinct.

Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3, 4 }));

bool ContainsDuplicate(int[] nums)
{
    // Using HashSet to abuse the fact that a HashSet can't have duplicate elements
    HashSet<int> noDuplicates = new();
    // Start at the first element
    for (int i = 0; i < nums.Length; i++)
    {
        // Need to check if the HashSet is empty or not
        // otherwise it can throw a null
        // if the element is contained, return false
            if(noDuplicates.Contains(nums[i]) && noDuplicates != null)
            {
                return true;
            }
            // Otherwise, add the element to the HashSet
            else
            {
                noDuplicates.Add(nums[i]);
            }
    }
    // if we get here, we iterate through every element on nums[]
    // and validate that every element is unique
    return false;
}