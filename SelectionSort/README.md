A selection sort is considered to be an "in-place comparison sort". 
What do we mean by in-place comparison? The algorithm will iterate through the entire list in 
search of the smallest value in the list. Once it finds that, it moves it to position zero. 
Position zero is now known as the "sorted" portion of the list while the 
remaining values are in the "unsorted" portion.
The algorithm repeats, finding the next smallest value and moving that to the next available 
position in the "sorted" portion if the list. 
This continues until we have placed the last value in the last position of the list.
This is actually a potentially slow sorting algorithm and is certainly slower than a 
comparable insertion sort but it is simple. 
Part of the reason it can be slower is due to the fact that it iterates over the entire 
unsorted portion of the list on each search for the smallest value. 
Granted, this unsorted portion gets smaller and smaller after each iteration but initially, 
if the list is quite large, this can take a long time to complete.