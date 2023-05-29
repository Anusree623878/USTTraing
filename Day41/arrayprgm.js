function search( a, k, x)
{
    var j;
     
    for ( j = k - 1; j > -1 ; j--)
    {
        if(a[j] == x)
            return j ;
    }
                 
        return -1 ;
}
 
// Function to generate an array
// of size N by following the given rules
function genArray(arr, N)
{
 
    // Loop to fill the array
    // as per the given rules
    for(var i = 0; i < N - 1; i++)
    {
 
        // Check for the occurrence
        // of arr[i - 1]
        if(search(arr, i, arr[i]) == -1)
                arr[i + 1] = 0 ;
 
        else
            arr[i + 1] = (i-search(arr, i, arr[i])) ;
    }
}
 
// Driver code
var N = 5 ;
var size = N + 1 ;
var a = [0, 0, 0, 0, 0];
genArray(a, N) ;
document.write("["+a+"]");