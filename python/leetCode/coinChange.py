# 322. Coin Change

from typing import List

class Solution:
    def coinChange(self, coins: List[int], amount: int) -> int:
        dp = [amount + 1] * (amount + 1)
        dp[0] = 0

        for a in range(1, amount + 1):
            for c in coins:
                if a - c >= 0:
                    dp[a] = min(dp[a], 1 + dp[a - c])
                    
        return dp[amount] if dp[amount] != amount + 1 else -1
    


arr = [1,2,5]
am = 11
obj = Solution()
print(obj.coinChange(arr, am))