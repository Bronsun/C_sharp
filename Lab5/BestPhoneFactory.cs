using System;


namespace Lab5{
    class BestPhoneFactory : PhoneFactory{
  
        public override Phone CreatePhone(string PhoneType){
            if(PhoneType=="iPhone"){
                iPhone x = new iPhone();
               
                return  x;
            }
            else{
                throw new ApplicationException("No phone");
            }

        }
        public override Phone OldestPhone(){
           
            return new Samsung();
        }
        public override Phone CheapestPhone(){
             Samsung x = new Samsung();
            
            return new Samsung();
        }
        public override Phone NewestPhone(){
             Samsung x = new Samsung();
            
            return new Samsung();
        }
      
}
}
