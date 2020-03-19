https://learning.oreilly.com/library/view/c-in-depth/9781617294532/kindle_split_028.html

Tuples allow you to create a single composite value from multiple individual values. They’re shorthand for composition with         
no extra encapsulation for situations where values are related to each other but you don’t want the work of creating a new         
type. C# 7 introduces new syntax to make working with tuples simple.                  
As an example, suppose you have a sequence of integers and you want to find both the minimum and the maximum in one pass.         
This sounds like you should be able to put that code into a single method, but what would you make the return type? You could         
return the minimum value and use an out parameter for the maximum value or use two out parameters, but both of those feel fairly clunky. 
You could create a separate named type, but that’s a lot of work for just         
one example. You could return a Tuple<int, int> using the Tuple<,> class introduced in .NET 4, but then you couldn’t easily tell which was the minimum value and which was the maximum (and         
you’d end up allocating an object just to return the two values). Or you could use C# 7’s tuples. You could declare the method         
like this:


Hey Corey,

As promised, here’s the link to my ‘Kata’ GitHub: https://github.com/mtzupan/KataMon
I like using GitHub because it’s free and easy to set up. There are other options out there but I recommend GitHub for sure.

The repo contains:
-	How-to exercises from C#’s ‘Programming Exam Reference’
-	Code challenge exercises from Edabit C#
-	(soon) Code challenge exercises with ‘pandas’ and ‘numpy’ Python libraries

It’d be nice to get a system of mutual Kata review, for learning and motivational purposes… let’s chat about this tomorrow around noon? I can get you set up on GitHub & SourceTree with a practice repository in ~30 mins if we screen share. If we give each other ‘read’ access on our respective repositories, we’d be set to collab. 

Hope it’s a good day so far.

Matt  

https://www.youtube.com/watch?v=aUbXGs7YTGo