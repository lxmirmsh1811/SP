using System;

namespace SP{
    class Context{
        State currentState;
        public State CurrentState {get; set;}
        // public void setCurrentState(State state){
        //     currentState = state;
        // }

        public Context(State initialState){
            currentState = initialState;
        }

        public void on(){
            currentState.onNow(this);
        }

        public void off(){
            currentState.offNow(this);
        }
    }
}