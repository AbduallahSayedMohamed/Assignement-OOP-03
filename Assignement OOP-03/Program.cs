namespace Assignement_OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1
            /* 
             * Q1 :
             * Identify the type of relationship in each scenario below 
             * (Inheritance, Association, Aggregation, Composition, or Dependency):
             * --------------------------------------------------------------------
             * --------------------------------------------------------------------
             * a) A University has Departments. If the university is closed, the departments no longer exist?
             * -----> Composition Relationship (HAS-A – Strong)
             * b) A Driver uses a Car. The driver does not own the car?
             * -----> Assiciation Relationship 
             * c) A Dog is an Animal.
             * -----> Inheritance IS-A 
             * d) A Team has Players. If the team is deleted, the players still exist.
             * -----> Aggregation (Has-A) Weak.
             * e) A method receives a Logger as a parameter and calls it inside the method only.
             * -----> Dependency Relationship
             */
            #endregion

            #region Question 2
            /*
             * Q2 : Answer the following questions about access modifiers and sealed:
             * ----------------------------------------------------------------------
             * ----------------------------------------------------------------------
             * a) A parent class has a protected field. Can a child class in a different assembly access it? What about through an object instance from outside?
             * ----> With inheritance: Yes. A child class can access the protected member, even if it is in a different assembly.
             * ----> Without inheritance: No. A non-derived class cannot access a protected member.
             * ----> With inheritance: No. The protected member cannot be accessed through a Parent object instance.
             * ----> Without inheritance: No. It also cannot be accessed through an object instance from outside the 
             * ----------------------------------------------------------------------------------------------------
             * b) What is the difference between protected internal and private protected?
             * ----> without inheritance :
             * ----> In protected Internal can  The member is accessible within the same assembly [project]
             * ----> but in private protected can The member is accessible within the same class.
             * ----> with Inheritance :
             * ----> protected internal = same assembly OR child anywhere (more open). private protected = child in same assembly only (more restrictive).
             * ---------------------------------------------------------------------------------
             * c) What does the sealed keyword do when applied to a class? What about when applied to a method?
             * ----> sealed keyword in class is used to prevent inheritance 
             * ----> sealed keyword in methods is used to prevent further overriding down the chain.
             * ------------------------------------------------------------------------------------
             * d) Can you create an object from a sealed class using new? Why or why not?
             * ----> yes we can take an object from sealed class
             * 
             *    sealed public class Child 
             *     {
             *         public string place { get; set; }
             *         public string name { get; set; }
             *     }
             * 
             *      Child c1 = new Child();
             */

            #endregion
        }
    }
}
