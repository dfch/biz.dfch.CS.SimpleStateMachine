using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStateMachine
{
    public class StatusEnum : ProcessBase
    {
        public StatusEnum()
        {
            InsertStateTransition(InitialState, ContinueCondition, WatingState, true);
            SetStateTransition(WatingState, CancelCondition, CancelledState);
        }
        public override string InitialState
        {
            get
            {
                return "Pending";
            }
        }
        public string WatingState
        {
            get
            {
                return "Waiting";
            }
        }
        public override string CancelledState
        {
            get
            {
                return "Failed";
            }
        }
    }
}
