using System;

namespace Lab5{
    abstract class PhoneFactory{
        public abstract Phone CreatePhone(string PhoneType);
        public abstract Phone CheapestPhone();
        public abstract Phone NewestPhone();

        public abstract Phone OldestPhone();

        
    }


}