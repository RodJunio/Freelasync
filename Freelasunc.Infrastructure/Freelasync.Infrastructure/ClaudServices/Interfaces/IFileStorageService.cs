namespace Freelasync.Infrastructure.ClaudServices.Interfaces;
public interface IFileStorageService
{
    void UploadFile(byte[] file, string fileName);
}
