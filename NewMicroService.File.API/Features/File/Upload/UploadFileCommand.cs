
using NewMicroService.Shared;
using static NewMicroService.Shared.ServiceResult;

namespace NewMicroService.File.Api.Features.File.Upload;

public record UploadFileCommand(IFormFile File) : IRequestByServiceResult<UploadFileCommandResponse>;