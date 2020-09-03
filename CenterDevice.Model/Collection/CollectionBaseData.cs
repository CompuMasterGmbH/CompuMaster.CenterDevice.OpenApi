namespace CenterDevice.Model.Collection
{
    public interface CollectionBaseData
    {
        string Id { get; }
        string Name { get; }
        bool IsShared { get; }
        bool? HasFolders { get; }
        bool Archived { get; }
    }
}
