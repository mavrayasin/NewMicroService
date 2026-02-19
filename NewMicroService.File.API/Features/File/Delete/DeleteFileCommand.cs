
using NewMicroService.Shared;
using static NewMicroService.Shared.ServiceResult;

namespace NewMicroService.File.Api.Features.File.Delete;

public record DeleteFileCommand(string FileName) : IRequestByServiceResult;