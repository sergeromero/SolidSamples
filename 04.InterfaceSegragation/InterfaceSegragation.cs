using System;
using System.Collections.Generic;
using System.Text;

namespace SolidExamples
{
    public interface MyInterface
    {
        void Save();
        bool Validate();
        void Create();
        void Transfer();
        string GetDescription();
        int GetCodeFromLastError();
        void ReportFailuresForMaintenance();
        bool CloseTicket();
        void AddToWorkflow();
    }

    public class InterfaceUser : MyInterface
    {
        public void AddToWorkflow()
        {
            // no op
        }

        public bool CloseTicket()
        {
            // This class has no relationships to tickets
            return true;
        }

        public void Create()
        {
            // This does have some implementation
        }

        public int GetCodeFromLastError()
        {
            // This class does not have error codes associated to it
            return 0;
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public void ReportFailuresForMaintenance()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Transfer()
        {
            throw new NotImplementedException();
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }

    public interface IGoodInterfaceOne
    {
        void Save();
        bool Validate();
        void Create();
        void Transfer();
    }

    public interface IGoodInterfaceTwo
    {
        string GetDescription();
        int GetCodeFromLastError();
        void ReportFailuresForMaintenance();
        bool CloseTicket();
        void AddToWorkflow();
    }


    public class DoingTooMuch : IGoodInterfaceOne, IGoodInterfaceTwo
    {
        public void AddToWorkflow()
        {
            throw new NotImplementedException();
        }

        public bool CloseTicket()
        {
            throw new NotImplementedException();
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public int GetCodeFromLastError()
        {
            throw new NotImplementedException();
        }

        public string GetDescription()
        {
            throw new NotImplementedException();
        }

        public void ReportFailuresForMaintenance()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Transfer()
        {
            throw new NotImplementedException();
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }

    public class DoingJustEnough : IGoodInterfaceOne
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Transfer()
        {
            throw new NotImplementedException();
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
    
    public class InterfaceSegragation
    {
        public void DoSomething()
        {
            var doingTooMuch = new DoingTooMuch();

            var doingEnough = new DoingJustEnough();
        }
    }
}
