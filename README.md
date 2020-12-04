# yanjiao
三国杀武将张昌蒲技能【严教】计算器
## 性能
在i5-9500上测试，14张及以下可以秒算，之后会有卡顿
## 方法
使用暴力搜索，使用了一次最优剪枝，因此只会返回一个最优解
由于牌的点数有限 (1-13), 因此超过14张的情况可以考虑采用近似最优算法，比如桶方法，建立13个桶，然后模2，余为1的桶使用正整数分解（这个有多项式时间解）
基本可以认为严教问题是NP难题
