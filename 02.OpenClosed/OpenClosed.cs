using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamples
{
    public abstract class OpenClosed
    {
        protected abstract void Validate();

        protected abstract void ExecuteInterestingLogic();

        protected abstract void SendResultsToProcessor();

        public void DemonstrateOpenClosed()
        {
            Validate();

            // Something happens after the validation that never changes

            ExecuteInterestingLogic();

            // Something happens after the interesting logic that never changes

            SendResultsToProcessor();

            // Something happens at the end that never changes
        }
    }

    public class OpenClosedImplementationOne : OpenClosed
    {
        protected override void ExecuteInterestingLogic()
        {
            throw new NotImplementedException();
        }

        protected override void SendResultsToProcessor()
        {
            throw new NotImplementedException();
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
