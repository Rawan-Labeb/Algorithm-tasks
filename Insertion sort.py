def insertionSort(arr):

    for step in range(1, len(arr)):
        key = arr[step]
        j = step - 1
        
        # Compare key with each element on the left of it until an element smaller than it is found
        # For descending order, change key<array[j] to key>array[j].        
        while j >= 0 and key < arr[j]:
            arr[j + 1] = arr[j]
            j = j - 1
        
        # Place key at after the element just smaller than it.
        arr[j + 1] = key


data = [9, 5, 1, 4, 3]
insertionSort(data)
print('Sorted Array in Ascending Order:')
print(data)