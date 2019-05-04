using CleanArchitecture.Core.SharedKernel;

namespace CleanArchitecture.Core.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        void Handle(T domainEvent);
    }
}