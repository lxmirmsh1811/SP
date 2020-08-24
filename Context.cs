using System;

namespace SP{
    public class Context{
        public State currentState {get; set;}
        //public State CurrentState {get; set;}
        // public void setCurrentState(State state){
        //     currentState = state;
        // }

        

        public Context(State initialState){
            currentState = initialState;
        }

        public void on(){
            Console.WriteLine("Calling on");
            currentState.OnNow(this);
        }

        public void off(){
            currentState.OffNow(this);
        }
    }
}