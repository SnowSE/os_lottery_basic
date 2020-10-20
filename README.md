For this assignment, you will be 
GIVEN:
- Repository with code of a functional LOTTERY program

For this assignment, you will be expected to
DEVELOP & SUBMIT:

<li>
  Step 1)
- Currently your thread had 3 hard-coded threads (see Program.cs)
  You need to modify the code to use a LIST - and I suggest you make it a list of Thread objects.  Perhaps the following snippet will help :)
    List<Thread> vTList = new List<Thread>();
  You need to create a loop of some sort to create FOUR threads, and store them in this vTList that you just made.
  You will know you used the list right when you can reference them by calling:
     /*create*/      vTList.Add(new Thread(tLotteryVendor));
     /*start */      t.Start(); //start each thread running 
     /*join  */      t.Join(); //start each thread running
  (commit this to main - make the comment "List of tLotteryVendor Threads") {10 points: 5pts it works using vTList, 3pts I can clearly see you understand List and how it can be used in a Thread context.  2pts commit name}

Step 2)
- modify the code to have 4 threads, each selling 1,000,000 lottery tickets
 (commit this to main - make the comment "4Threads@10M each") {10 points:  2pts commit exists, 2 pts comment, 4pt correct code # of tickes sold, 2pts I can clearly see you understand Thread control.}

Step 3)
- modify the code to use local & global counters.
  Currently, your code has 4 Threads, each locking the global stack called 'soldTickets' 1M each (that is 4M locks - lots of opportunity for blocking and OS delay)
  You need to use local/global counters to break up this choke-point.
  (commit this to main - make the comment "Global/Local counters") {15 points: 10 pts it works, 1pts comment name, 4 points I can clearly see you understand local/global counter philosophy}

Note:  You may have many other commits - that is OK, but you should have only 3 commits having the comments specified here (for grading clarity)
IF you fail to have the commit, you would loose out on the commit exists points and the correct comment name points - so commit these 3 different times! :)

