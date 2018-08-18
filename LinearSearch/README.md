A linear search, also known as a sequential search, will search from a starting point, 
through the items, until it either finds the item or has searched through the entire source. 
This source is typically a list. As an example, if we had a list of numbers from 1 through 10 
(1, 2, 3, 4, 5, 6, 7, 8, 9, 10) and we were searching for 5, the search would continue in a 
linear fashion, that is from 1 through to 5. 
Once it found 5, the search would stop. If we searched for 10, we would go through the entire 
list until we found 10 at the end. 
Of course, you might ask why would we not set the search start at a value other than the 
beginning of the list. We could, but if the list is not sorted and we didn't start at the 
beginning, we might miss the value we are looking for.
The basic through process in a linear search is this:
-set a counter equal to 0
-check the item at position (counter) and if it equals search term, end the algorithm
-if search term is not found in step 2, increment counter and repeat step 2