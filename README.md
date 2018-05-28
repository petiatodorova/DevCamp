# DevCamp
Solutions for DevCamp 05/2018

### The Great Samurai Battle

The samurai masters are the great warriors of honor and dignity, they never flee from battle and even when they lose they do it with honor. Nowadays we have more peaceful ways to represent those furious battles.
You will receive a sequence of integers, separated by spaces – the samurai masters, 
which are represented as an array.
You must traverse the elements, from the first till the last. Each element is an attacker index, and its integer value is its target index. If the integer value is greater than the length of the sequence, divide it modulo (%) by the length of the sequence. Example: target = 12, length = 7, target = 12 % 7 - > 5.
When you extract attacker index and the target index, you must calculate the absolute value of the difference between them. 
If the difference is an even number, the attacker wins.
if the difference is an odd number, the target wins.
If the attacker and the target are equal (they are the same indexes), that means that samurai performs harakiri.
If a samurai loses a battle or performs harakiri, they should NOT be able to attack. It can still be a target though.
When you finish traversing the whole sequence, you must remove all elements that have lost or performed harakiri, and then you must start over. The process must be repeated until there is only 1 samurai left in the sequence.
For each attacker and target, you must print “{attacker} x {target} -> {winner} wins”. 
The attacker and the target are indexes, and the winner is the index of the winner.
If a samurai preforms harakiri you must print “{attacker} performed harakiri”.
Input
As input you will receive a single input line containing the sequence of integers, separated by spaces.
Output
As output you must print each action between attacker and target, in the formats specified above.
Constraints
The elements of the sequence will be between 0 and 100.
The integers in the sequence will be in range [0, 1000]. 
Allowed working time / memory: 100ms / 16MB.
Examples
Input
Output
Comment
4 3 2 1 0
0 x 4 -> 0 wins
1 x 3 -> 1 wins
2 performed harakiri
0 performed harakiri
First: Attacker – 0, Target – 4. Difference = 4 (even) Attacker wins, Target lost.
Second: Attacker – 1, Target – 3. Difference = 2 (even) Attacker wins, Target lost.
Third: Attacker – 2, Target – 2. Equal, Attacker performed harakiri.
All other elements have lost. We remove them from the sequence. Sequence – 4 3. Length = 2.
First: Attacker – 0, Target – 4 (% 2) = 0. Equal, Attacker performed harakiri.
There is 1 element left, so we stop the program.


25 31 6 9 2 4 7
0 x 4 -> 0 wins
1 x 3 -> 1 wins
2 x 6 -> 2 wins
5 x 4 -> 4 wins
0 x 1 -> 1 wins
1 performed harakiri

---------------------------------------------------------------------------------------------------

### Survival Message

You are involved in a warfare, of course you are not a typical soldier, instead you are the squad programmer. Your forces were surrounded by enemies, but you are not discovered yet since you are in a deep cover inside a building. You have to send message to the headquarters, but it has to be special, should look more like an interference, because otherwise it will be detected by the enemy.
The message is formed by five elements two numbers from [1…99] and three letters. The elements should be in the following order:
Element 1: number from N to 99
Element 2: uppercase letter from {firstUpper} to 'Z' 
Element 3: lowercase letter from {lowerLetter} to 'z'
Element 4: uppercase letter from {secondUpper} to 'Z' 
Element 5: number from M to 10.
In order for the message to be readable by the allied forces it has to match the following criteria:
The first number should end in 2
The second number should end in 5
There will be total count of allowed valid messages {count}
Your task is to generate all the valid messages and when you reach the maximum number of messages {count}, you have to print on the console the last one which will be the survival message.
Input
The input consists of exactly six lines:
First line: N - number between [10...99]
Second line: {firstUpper} - uppercase letter between [A…Z]
Third line: {lowerLetter} - lowercase letter between [a…z]
Fourth line: {secondUpper} - uppercase letter between [A…Z]
Fifth line: M - number between [10...99]
Sixth line: {count} - number between [1...100]
Output
Print on the console the last message when you reach the maximum count of valid combinations.
Constraints
There will be no invalid input lines.
Allowed working time / memory: 100ms / 16MB.
Example
Input
Output
Обяснение
10
Y
y
Y
20
4
12YzZ15
The first generated message is: 10YyY20, which is invalid according to the validation criteria the first number (10) doesn’t end in 2, also the second number (20) doesn’t end in 5. 
The second message generated - 10YyY19 is again invalid, because the first number doesn’t end in 2 and the second number doesn’t end in 5.
We count only the valid generated messages so we continue to generate more combinations.  We generate the first valid message: 12YyY15 – this time the first number (12) ends in 2 and the seocnd (15) ends in 5.
So we increase the count by 1.
Then we generate the second valid message: 12YyZ15.
And the third valid message is: 12YzY15.
The final valid message is the fourth: 12YzZ15.
The total count of valid messages is now 4, which means we have reached the maximum count (4) of valid messages so we print the fourth message: 12YzZ15.
The program stops.

12
A
b
C
45
8
12AbD15

45
H
r
M
34
10
52HrQ15

---------------------------------------------------------------------------------------------------

### Heroes Selection

Have you seen the unseen magic? Right… It doesn’t actually matter, but there is something growing beneath the northen icecap and it’s growing fast, changing everything on it’s way. The magic changed its colour too and it's, well, we can say prefferences, are not what they used to be. First of all magic preffers to be treated as a lady. “She” can handle the monstrous uprise but she needs your help to find the most worthy hero of them all to join magic and traits in the final blow.  
You will receive input lines with information about current hero in the following format:
{hero’s name} {trait} {traitValue}
The name and trait are a one-word strings. The trait value is an integer in the range [0…100].
If you receive a trait for the same hero twice, you should replace the existing trait value only if the new one is greater.
The magic wielders are to be chosen with great responsibility so if the trait is any of the following its value should become a negative integer:
Greedy
Rude
Dumb
Since the magic is hard to understand and to reason with, some traits seems to be worth more than other, those are considered special and must be multiplied as it follows:
“Kind” gets its trait value multiplied by a factor of 2
“Handsome” gets its trait value multiplied by a factor of 3
“Smart” gets its trait value multiplied by a factor of 5
There may be input lines in the following format:
{hero’s name} does Gyubek!
If you receive the command "{hero’s name} does Gyubek!", The mighty magic – “She” recognizes weakness within this hero’s behavior, because “Gyubek!” is a dark sorcery that should never be performed. If this hero is already added to the data, all of his positive trait’s values are deleted! If the hero doesn’t exist in the database yet, he won`t be affected if added later.
The input ends when you receive the command "Make a decision already!". You must print all heroes, ordered by the total sum of their traits’ values in descending order, and then alphabetically.
The traits must be ordered by their value in descending order.
Input
The input consists of several input lines in one of the formats specified above.
The input ends when you receive the command "Make a decision already!".
Output
As an output you must print all the heroes ordered in the way specified above.
The format is:
 # {hero’s name}: {total sum of traits values}
!!! {trait} -> {traitValue}
Constraints
The hero’s name and trait will be strings, consisting of one word each.
The trait value is an integer in the range [0; 100].
There will be no invalid input lines.
Allowed working time / memory: 100ms / 16MB.
Examples
Input
Output
Tony Handsome 40
Johnny Cool 23
Johnny does Gyubek!
Asen Kind 33
Ivan Greedy 1
Ivan Smart 5
Asen Greedy 20
Make a decision already!
# Tony: 120
!!! Handsome -> 120
# Asen: 46
!!! Kind -> 66
!!! Greedy -> -20
# Ivan: 24
!!! Smart -> 25
!!! Greedy -> -1
# Johnny: 0
Pesho Cool 20
Gosho Rude 20
Kiro Kind 10
Stamat does Gyubek!
Stamat Big 20
Make a decision already!
# Kiro: 20
!!! Kind -> 20
# Pesho: 20
!!! Cool -> 20
# Stamat: 20
!!! Big -> 20
# Gosho: -20
!!! Rude -> -20

---------------------------------------------------------------------------------------------------

### Dragons Hatching

Teamwork is importatn but team points is what matters the most especially if we have a team full of dragons. Your task is to write down a program that calculates the points in a local dragon hatching competition. Never heard of dragon hatching before? Nevermind the rules are simple anyway.
You will receive N, an integer – the count of teams participant in the competition. 
Since drgaons are ancient and their mood changes often you will receive also the current dragon hatching value {dragonHatchingValue}, represented as a floating-point number.
For each team, you will receive an input line in the following format:
“{dragonsHatched} {teamMembersCount}”
The dragonsHatched and the teamMembersCount will be integers. 
You will have to calculate the team points by dividing the number of dragonsHatched by teamMembersCount {teamPoints} = {dragonsHatched /teamMembersCount}.
Your task is to sum all team points for all the participant teams, and then divide that sum by the dragonHatchingValue, and print the result. 

If a division is not possible, just print the sum of all team points.
Input
On the first input line you will receive N – the amount of teams.
On the second input line you will receive the dragonHatchingValue.
On the next N input lines you will receive information about each team in the format specified above.
Output
As output you must print the sum of all team points divided by the dragonHatchingValue.
If a division is not possible you must print the total sum of team points.
The output should be rounded and printed to 3 places after the decimal point.
Constraints
The amount of teams – N will be an integer in range [0, 100].
The dragonHatchingValue will be a floating-point number in range [0, 9].
The dragonsHatched will be an integer in range [-231, 231].
The teamMembersCount will be an integer in range [1, 10000].
Allowed working time / memory: 100ms / 16MB.
Examples
Input
Output
Comment
4
4
2000 10
1000 5
5000 2000
3000 30
125.625
2000 / 10 = 200
1000 / 5 = 200
5000 / 2000 = 2.5
3000 / 30 = 100
200 + 200 + 2.5 + 100 = 502.5
502.5 / 4 = 125.625
2
2
100000 50
200000 25
5000.000
100000 / 50 = 2000
200000 / 25 = 8000
2000 + 8000 = 10000
10000 / 2 = 5000
(rounded to 3rd symbol) = 5000.000

