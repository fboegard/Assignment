using System;

namespace Assignment
{
    public class CallCenter
    {
        public void StartCallCenter()
        {
            var fresher1 = new Fresher { Name = "Anna",Status = PersonStatus.CanTakeCall};
            var fresher2 = new Fresher { Name = "Peter", Status = PersonStatus.Occupied };
            var techlead1 = new TechLead { Name = "Sara", Status = PersonStatus.CanTakeCall };
            var pm1 = new ProductManager { Name = "Maria", Status = PersonStatus.CanTakeCall };            
            var techlead2 = new TechLead { Name = "Magnus", Status = PersonStatus.CanTakeCall };  // Should result in exception
        }
        
    }
    public abstract class Person
    {
        public string Name { get; set; }
        public PersonStatus Status { get; set; }
    }
    public enum PersonStatus
    {
        CanTakeCall,
        Occupied,
        Lunch,
        Vacation,
        Other
    };

    public class Fresher: Person
    {

    }
    public class TechLead : Manager
    {

    }
    public class ProductManager : Manager
    {

    }

    public abstract class Manager: Person
    {
        private static int techLead;
        private static int productManager;

        public Manager()
        {
            if (this.GetType() == typeof(TechLead))
            {
                if (techLead == 1)
                { throw new InvalidOperationException("Only 1 instance of TechLead are allowed"); }

                techLead++;
            }

            if (this.GetType() == typeof(ProductManager))
            {
                if (productManager == 1)
                { throw new InvalidOperationException("Only 1 instance of ProductManager are allowed"); }

                productManager++;
            }

        }
    }
}
