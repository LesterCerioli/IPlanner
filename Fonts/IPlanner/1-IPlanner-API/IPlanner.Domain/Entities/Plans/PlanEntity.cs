namespace IPlanner.Domain.Entities.Plans
{
    public class PlanEntity
    {
        public PlanEntity(Guid id, string name)
        {
            Id = id;
            Name = name;

        }

        protected PlanEntity() {}
        public string Name {get; set;}
    }
}