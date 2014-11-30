biz.dfch.CS.SimpleStateMachine
==============================

d-fens GmbH, General-Guisan-Strasse 6, CH-6300 Zug, Switzerland

A simple Finite State Machine that can be configured via State Transitions

Based on an idea by [Juliet](http://stackoverflow.com/users/40516/juliet) "[Simple state machine example in C#?](http://stackoverflow.com/questions/5923767/simple-state-machine-example-in-c)"

DESCRIPTION

Thie project has a ProcessBase FSM defined that consists of a few simple states and has two conditions ("Continue", "Cancel") that can be used to advance (transition) through that state machine.

1. The "[Continue](./SimpleStateMachine/ProcessBase.cs#L168)" condition makes a transition from an arbitrary state to the next state as the "good case"
1. The "[Cancel](./SimpleStateMachine/ProcessBase.cs#L176)" condition makes a transition from an arbitrary state to the next state as the "bad case"
1. Furthermore you can use the "[GetNext](./SimpleStateMachine/ProcessBase.cs#L321)" method to transit to the next state based on a given condition.

In addition there are two more FSMs as examples that inherit from the ProcessBase FSM.
* "[StatusEnum](./SimpleStateMachine/StatusEnum.cs)" is enhancing the available states (inserting them into the existing state tables)
* "[ProcessCommand](./SimpleStateMachine/ProcessCommand.cs)" essentially redefines the complete FSM.

There are methods for exporting and importing the configuration along with the states.

You can run the [example programme](./SimpleStateMachine/Program.cs) to see the state transitions and its output.
