using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        private object productCountOfCategoryError;

        public ErrorResult(string message) : base(false, message)
        {

        }
        public ErrorResult() : base(false)
        {

        }

        public ErrorResult(object productCountOfCategoryError):base(false)
        {
            this.productCountOfCategoryError = productCountOfCategoryError;
        }
    }
}
