#include <iostream>
#include <vector>
using namespace std;

class Solution {
public:
    std::vector<int> twoSum(std::vector<int>& nums, int target) {
        int n = nums.size();
        for (int i = 0; i < n - 1; i++) {
            for (int j = i + 1; j < n; j++) {
                if (nums[i] + nums[j] == target) {
                    return { i, j };
                }
            }
        }
        return {}; // No solution found
    }

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
    }
};