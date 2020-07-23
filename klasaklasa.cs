using System;

public class klasa
{
    
    
        public string col1 { get; set; }
        public string col2 { get; set; }
        public string col3 { get; set; }
        public string col4 { get; set; }
        
       
        
        public string A()
        //nie czaję tej składni, po chuj te sredniki na poczatku i koncu?
        {
            return $"{String.Join(";", col1, col2, col3, col4)};;";
        }

    
}
