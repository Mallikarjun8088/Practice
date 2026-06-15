using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case.Tasks.SBI_TASK
{
    class Class1
    {
        static void Main(string[] args)
        {
            Vision_Station vision_status = new Vision_Station();
            Pick_Station pickUp_Satuts = new Pick_Station();
             Place_Station placing_status = new Place_Station();

            vision_status.Capture_Image = "Complited";
            vision_status.Inspect_Status = "Complited";

            pickUp_Satuts.PNP_Possition_status = "Complited";
            pickUp_Satuts.PNP_Vacuum_Status = "ON";

            placing_status.Move_To_Position = "Complited";
            placing_status.Vacuum_Status = "OFF";

            vision_status.ccd_status();
            pickUp_Satuts.P_Possition_status();
            placing_status.Possition_status();
            vision_status.ISS_status();




            Console.Read();

        }
    }

    abstract class Machine_station
    {
        string Vision_Inspection_Complited;
        string Pick_Station_complited;
        string Place_Station_complited;
       
    }

    class Vision_Station : Machine_station
    {
        public string Capture_Image, Inspect_Status;
        public void ccd_status()
        {
            Console.WriteLine("Image Stuats " + Capture_Image);
        }
        public void ISS_status()
        {
            Console.WriteLine("Inspection Status " + Inspect_Status);
        }

    }
    class Pick_Station : Machine_station
    {
       public string PNP_Possition_status, PNP_Vacuum_Status;

        public void P_Possition_status()
        {
            Console.WriteLine(" PNP_Possition_status " + PNP_Possition_status);
        }
        public void PNP_Vacuum()
        {
            Console.WriteLine("Vacuum_Status" + PNP_Vacuum_Status);
        }
    }
     class Place_Station : Machine_station
    {
       public string Move_To_Position, Vacuum_Status;


        public void Possition_status()
        {
            Console.WriteLine(" Position Status" + Move_To_Position);
        }
        public void Vacuum()
        {
            Console.WriteLine("Vacuum_Status" + Vacuum_Status);
        }

    }


}
