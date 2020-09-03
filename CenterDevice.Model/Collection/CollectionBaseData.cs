namespace CenterDevice.Model.Collection
{
    public interface CollectionBaseData
    {
        string Id { get; }
        string Name { get; }
        bool Shared { get; }
        bool HasFolders { get; }
        bool Archived { get; }
    }
}
