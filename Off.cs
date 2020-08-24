using System;

namespace SP{
    class Off : State{
        public void onNow(Context context){
            Console.WriteLine("You are in On State");
            context.CurrentState = new On();
        }
    }
}