namespace BusinessLogic
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntityBase
    {
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public bool IsValid => Validate();
        public EntityStateOption EntityState { get; set; }

        public abstract bool Validate();

    }
}