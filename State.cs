using System;

namespace SP{
    public abstract class State{
        public virtual void OffNow(Context context){}
        public virtual void OnNow(Context context){}
    }
}