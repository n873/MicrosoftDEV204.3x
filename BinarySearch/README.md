A binary search is a search algorithm that finds a value in a list with one important aspect. 
The list must be sorted before the binary search can work. 
The reason is that a binary search divides the list in repeating fashion until it finds the value. 
It starts at the half-way point in the list and compares that value with your search term. 
If the search term is less than the middle value in the list, the second half of the list is 
discarded for the next search and the total number of values to search is now reduced by half. 
This compare and divide process continues until the value is found or, until the list is 
completely discarded (no value found)

The logic behind this search goes something like this:
1. Get the list to search
2. Find the mid-point and get an index to mark that mid-point
3. Compare the value at the mid-point and the search term
4. If the two match, the search is done. If not, proceed to the next step
5. Is the term greater or less than the mid-point value?
6. if greater, get index for mid-point between current mid-point and end of list. Repeat steps 3 to 5 and a. or b. until term is found or not
7. if less than, get the index for mid-point between current mid-point and beginning of list. Repeat steps 3 to 5 and a. or b. until term is found or not
8. If term is found above, end and return index of term
9. If term is not found above, end and return search failed result