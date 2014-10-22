using SDM.Code.Helper.Specifications;
using System;
using System.Linq.Expressions;

namespace SDM.Code.Helper.Specifications
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        public OrSpecification(ISpecification<T> left, ISpecification<T> right) : base(left, right) { }
        public override Expression<Func<T, bool>> GetExpression()
        {
            return Left.GetExpression().Or(Right.GetExpression());
        }
    }
}
