namespace TrainSystem
{
    public class EngineData
    {
        //Data fields

        private int _HorsePower;
        private string _InService;
        private string _Model;
        private string _SerialNumber;
        private string _Weight;

        public int HorsePower
        {
            get
            {
                
                return _HorsePower;
            }

            set 
            {



            }

        }

        public bool InService
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }

        public string SerialNumber
        {
            get 
                {
                return _SerialNumber;
                    }
            
            
            set { }
        }

        public int Weight
        {
            get;
            set;
        }












    }
}