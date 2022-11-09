
public class Student:Person {
   private int numCourses; 
   private String[] courses;
   private int[] grades;   
    private List<Object>list;
     public Student(String name, String address):base(name, address) {
      numCourses = 0;
      list = new List<Object>();
   }
   public    override String toString() {
      return "Student: " +base.toString();
   }
   
   
   public void addCourseGrade(String course, int grade,List<object> list) {
      
      ++numCourses;
   }
   
 
   public void printGrades() {
   
      for (int i = 0; i < numCourses; ++i) {
        System.Console.WriteLine(" " + courses[i] + ":" + grades[i]);
      }

   }
   
  
   public double getAverageGrade() {
      int sum = 0;
      for (int i = 0; i < numCourses; i++ ) {
         sum += grades[i];
      }
      return (double)sum/numCourses;
   }
}