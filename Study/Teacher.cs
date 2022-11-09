public class Teacher:Person {
       private int numCourses; 
   private String[] courses; 

   public Teacher(String name, String address):base(name, address) {

      numCourses = 0;
   
   }
   
   public override String toString() {
      return "Teacher: " + base.toString();
   }
   
}