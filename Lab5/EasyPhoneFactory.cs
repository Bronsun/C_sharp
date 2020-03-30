using System;


namespace Lab5{
    class EasyPhoneFactory : PhoneFactory{
  
        public override Phone CreatePhone(string PhoneType){
            if(PhoneType=="Alcatel"){
                return new iPhone();
            }
            else{
                throw new ApplicationException("No phone");
            }

        }
        public override Phone CheapestPhone(){
            
            return new Alcatel();
        }
        public override Phone NewestPhone(){
            
            return new Alcatel();
        }
        public override Phone OldestPhone(){
            
            return new Alcatel();
        }
      
}
}
