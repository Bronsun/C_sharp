using System;


namespace Lab5{
    class CheapPhoneFactory : PhoneFactory{
  
        public override Phone CreatePhone(string PhoneType){
            if(PhoneType=="Xiaomi Redmi 4X"){
                return new Xiaomi();
            }
            else{
                throw new ApplicationException("No phone");
            }

        }
        public override Phone CheapestPhone(){
            
            
            return new Xiaomi();
        }
        public override Phone NewestPhone(){
             
            
            return new Xiaomi();
        }
        public override Phone OldestPhone(){
             
            
            return new Xiaomi();
        }
      
}
}
