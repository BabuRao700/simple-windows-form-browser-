public class InsertionSort {
    public static void main(String args[])
    {
        int[] listOfElements={9,1,5,6,2,0,10};
        InsertionSort obj=new InsertionSort();
        int[] result=obj.sortMyElements(listOfElements);
        for(int i=0;i<result.length;i++){
            System.out.println(result[i]);
        }

    }
    public int[] sortMyElements(int[] listOfElements ){

        int i, key, j;
        for(i=1;i<listOfElements.length;i++)
        {
            key = listOfElements[i];
            j = i-1;
            while (j >= 0 && listOfElements[j] > key)
            {
                listOfElements[j+1] = listOfElements[j];
                j = j-1;
            }
            listOfElements[j+1] = key;
        }

        return listOfElements;
    }
}


