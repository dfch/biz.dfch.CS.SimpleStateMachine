using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStateMachine
{
    public class ProcessCommand : ProcessBase
    {
        public enum CommandConditionEnum
        {
            Begin
            ,
            End
            ,
            Pause
            ,
            Resume
            ,
            Exit
        }
        public ProcessCommand()
        {
            lock (this)
            {
                ClearStateMachine();
                AddState(InitialState);
                AddState(ActiveState);
                AddState(PausedState);
                AddState(FinalState);
                AddCondition(CommandConditionEnum.Begin.ToString());
                AddCondition(CommandConditionEnum.End.ToString());
                AddCondition(CommandConditionEnum.Pause.ToString());
                AddCondition(CommandConditionEnum.Resume.ToString());
                AddCondition(CommandConditionEnum.Exit.ToString());
                AddCondition(ContinueCondition);
                AddCondition(CancelCondition);

                SetStateTransition(InitialState, CommandConditionEnum.Begin.ToString(), ActiveState);
                SetStateTransition(InitialState, CommandConditionEnum.Exit.ToString(), FinalState);
                SetStateTransition(ActiveState, CommandConditionEnum.End.ToString(), InitialState);
                SetStateTransition(ActiveState, CommandConditionEnum.Pause.ToString(), PausedState);
                SetStateTransition(PausedState, CommandConditionEnum.End.ToString(), ActiveState);
                SetStateTransition(PausedState, CommandConditionEnum.Resume.ToString(), ActiveState);

                SetStateTransition(InitialState, ContinueCondition, ActiveState);
                SetStateTransition(InitialState, CancelCondition, FinalState);
                SetStateTransition(ActiveState, ContinueCondition, InitialState);
                SetStateTransition(ActiveState, CancelCondition, PausedState);
                SetStateTransition(PausedState, ContinueCondition, ActiveState);
                SetStateTransition(PausedState, CancelCondition, InitialState);

                CurrentState = InitialState;
                PreviousState = InitialState;
            }
        }
        public override string InitialState
        {
            get
            {
                return "Inactive";
            }
        }
        public override string FinalState
        {
            get
            {
                return "Terminated";
            }
        }
        public string ActiveState
        {
            get
            {
                return "Active";
            }
        }
        public string PausedState
        {
            get
            {
                return "Paused";
            }
        }
    }
}
