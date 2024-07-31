using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BinarySearch : MonoBehaviour
{
    public List<int> numbers;
    public int targetNumber;

    // Start is called before the first frame update
    void Start()
    {
        numbers.Sort();
        print($"Target Index Location: {BinarySearchFindIndex(numbers, targetNumber)}");
    }

    private int BinarySearchFindIndex(List<int> elements, int target)
    {
        int left  = 0;
        int right = elements.Count-1;

        while(left <= right){
            int mid = left + (right - left) / 2; 

            if(elements[mid] == target)
            {
                return mid;
            }

            if(target < elements[mid]){
                right = mid -1;
            }
            else{
                left = mid +1;
            }

        }
        return -1;
    }
}