biz.dfch.CS.SimpleStateMachine
==============================

d-fens GmbH, General-Guisan-Strasse 6, CH-6300 Zug, Switzerland

A simple Finite State Machine that can be configured via State Transitions

Based on an idea by [Juliet](http://stackoverflow.com/users/40516/juliet) "[Simple state machine example in C#?](http://stackoverflow.com/questions/5923767/simple-state-machine-example-in-c)"

DESCRIPTION

Thie project has a ProcessBase FSM defined that consists of a few simple states and has two conditions ("Continue", "Cancel") that can be used to advance through that state machine.

In addition there are two more FSMs that inherit from the ProcessBase FSM. "StatusEnum" is enhancing the available states (inserting them into the existing state tables). "ProcessCommand" essentially redefines the complete FSM.

There are methods for exporting and importing the configuration along with the states.
