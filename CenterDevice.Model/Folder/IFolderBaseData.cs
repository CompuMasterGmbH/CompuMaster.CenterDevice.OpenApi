namespace CenterDevice.Model.Folder
{
    public interface IFolderBaseData
    {
        string Id { get; set; }
        string Name { get; set; }
        string Collection { get; set; }
        bool IsShared { get; }
        bool? HasSubFolders { get; }
    }
}
