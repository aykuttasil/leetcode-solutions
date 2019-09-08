/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 *
 * https://leetcode.com/problems/two-sum/description/
 *
 * algorithms
 * Easy (40.30%)
 * Total Accepted:    1.4M
 * Total Submissions: 3.5M
 * Testcase Example:  '[2,7,11,15]\n9'
 *
 * Given an array of integers, return indices of the two numbers such that they
 * add up to a specific target.
 * 
 * You may assume that each input would have exactly one solution, and you may
 * not use the same element twice.
 * 
 * Example:
 * 
 * 
 * Given nums = [2, 7, 11, 15], target = 9,
 * 
 * Because nums[0] + nums[1] = 2 + 7 = 9,
 * return [0, 1].
 * 
 * 
 * 
 * 
 */

fun main() {
    val sourceArray = listOf(2,3,3,4,5)
    val targetNumber = 9
    val result = twoSum(sourceArray, targetNumber)
    println(result)
}

fun twoSum(nums: List<Int>, target: Int): IntArray {
    val mm = mutableMapOf<Int,Int>()
    for ((index, value) in nums.withIndex()) {
        mm.put(value, index)
    }

    for((index, value) in nums.withIndex()){
        val t = target - value
        if(mm.containsKey(t) && mm.get(t) as Int != index){
            return IntArray(2).apply{ 
                set(0, index)
                set(1, mm.get(t)!!)
             }
        }
    }

   return IntArray(2)
}

