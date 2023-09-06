#include "TwoSum.h"
using namespace std;

int Run()
{
    std::vector<int> nums;
    int target;

    // Read input
    int size;
    std::cout << "Enter the number of elements in the array: ";
    std::cin >> size;

    nums.resize(size);
    std::cout << "Enter the elements of the array: ";
    for (int i = 0; i < size; i++) {
        std::cin >> nums[i];
    }

    std::cout << "Enter the target sum: ";
    std::cin >> target;

    // Find the indices of the two numbers
    std::vector<int> indices = twoSum(nums, target);

    // Output the result
    std::cout << "Indices of the two numbers that add up to the target: " << indices[0] << " and " << indices[1] << std::endl;

    return 0;
};


