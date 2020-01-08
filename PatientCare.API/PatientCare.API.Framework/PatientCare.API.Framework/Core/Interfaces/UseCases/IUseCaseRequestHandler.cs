using System.Threading.Tasks;

namespace PatientCare.API.Framework.Core.Interfaces.UseCases
{
    public interface IUseCaseRequestHandler<in TUseCaseRequest, out TUseCaseResponse> where TUseCaseRequest : IUseCaseRequest<TUseCaseResponse>
    {
        bool Handle(TUseCaseRequest message, IOutputPort<TUseCaseResponse> outputPort);

        Task<bool> HandleAsync(TUseCaseRequest message, IOutputPort<TUseCaseResponse> outputPort);
    }
}