
namespace SDM.Code.Helper.Specifications
{
    public interface ISpecificationParser<TCriteria>
    { 
        TCriteria Parse<T>(ISpecification<T> specification);
    }
}
