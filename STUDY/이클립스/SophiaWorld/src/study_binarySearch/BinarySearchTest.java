package study_binarySearch;

public class BinarySearchTest {
  public static void main(String[] args) {
    int[] arr = new int[200000];
    for (int i = 0; i < arr.length; i++) 
      arr[i] = i+1;

    bSearch(arr, 100000);
  }
  public static void bSearch(int[] arr, int value) {

    int left = 0;
    int right = arr.length-1;
    int mid;
    int cnt = 0;
    

    while(left <= right) {
      mid = (left+right)/2;
      if(arr[mid] == value) {
        System.out.printf("cnt : %d\n", cnt);
        System.out.println("찾음\n");
        return;
      }
      if(arr[mid] < value) {
        left = mid + 1;
      }
      else if(arr[mid] > value) {
        right = mid - 1;
      }
      cnt++;
    }
    System.out.println("못찾음\n");
  }
}
