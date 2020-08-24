using System;

namespace SP{
    abstract class State{
        public void offNow(Context context){}
        public void onNow(Context context){}
    }
}