How do we know if an algorithm is faster than another? 
We look at the operations required in that algorithm, 
use the size of the input problem, and then perform the Big O 
evaluation to determine which notation we should use for that algorithm. 
Using the plots on the graph from the Asymptotic Notation topic, 
you can then compare your algorithm against the graph using time and size factors. 

Bubble Sort Let's summarize the bubble sort logic.
A bubble sort performs the following tasks:
i.   Compare adjacent elements, starting with the first two elements
ii.  Swap them if first is larger than second
iii. Repeat previous two actions until we reach the end of the array
iv.  Perform n-1 passes over the array
v.   To optimize this algorithm we should check if any swap occurred after each pass. 
     If no, terminate

So how does this equate to measuring the algorithm performance and determining a Big O notation? 
If you look at the code for the bubble sort, you will note that we have a nested loop. 
The outer loop ensures that we have covered every value in the list (array) while the inner 
array does the comparison and swap tasks. 
The comparison task takes a finite amount of time. 
It never changes on a single computer configuration. 
For example, comparing 2 < 5 takes not more time than comparing 2,500,000 < 4,000,000,000. 
Also, swapping values takes a finite amount of time. 
So we know that we have a fixed amount ot time to complete the comparison and swap tasks. 
We don't know that a swap will occur each time but it is a factor in the time to compute.

So we have perform the inner loop for each iteration of the outer loop. 
This means that we have a Big O notation of O(n2). 
Why? Because every time we iterate in the outer loop, we run a complete array 
iteration in the inner loop. Hence it's a quadratic operation that results in a squared 
value of the number of items in the array. 
If you know how much time the comparison and swap takes, 
you could calculate the total time to complete a bubble sort but really, 
all we need to know is what it's Big O is in order to do a comparison with another algorithm, 
based on input size (array size). 
The actual time to complete isn't relevant for a comparison discussion.

Selection Sort
A selection sort follows this logic:
i.   Compare each element with the first element
ii.  If smaller than the current first element, swap them
iii. Now we have an unsorted array of n-1 elements and a sorted array consisting of 1 element (the first element is the smallest)
iv.  Repeat the procedure on the unsorted array (n-1 elements)
v.   On each iteration our unordered array is reduced reduced by 1, which makes the iterations required less

We perform a compare and potentially a swap. 
We have to iterate over the entire array and compare each element with the current first element. 
When complete on each pass, we still have to iterate over the unordered array 
and perform the same task. 
So in essence, it is really no faster than the bubble sort due to number of 
iterations we make over the array so a selection sort also ends up as O(n2)

Linear Search
Let's now turn our attention to a linear search algorithm. We know the logic behind a linear search and we know that it is relatively simple.
i.   Get search term
ii.  Start at beginning of array
iii. Compare term with first item, if found, end the search algorithm (best case)
iv.  If term is not at the first element, increment counter and try the next index value
The worst case on this search algorithm is that we iterate all the way to the end before we 
find the term, or don't find it at all. 
At any rate, the Big O notation for this search algorithm is O(n). 
Why is that? The first and second steps require no processing time at all. 
They are constant time which is the same O(1). 
We perform a compare and potentially an increment. 
These operations take a finite amount of time. 
That's all that is required. 
A simple compare/iterate so therefore the time to complete the task in worst case 
is equal to the size of the array, which is n.