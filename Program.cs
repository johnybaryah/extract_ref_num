using System;

namespace ExtractRefNumber.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var strs = new string[]
            {
                "wes-djhgjhgd-56526--3876387-1-wo.pdf",
                "3456782.pdf",
                "3456789000.5543542.pdf",
                "unknwon.kusdfh.4567890.5678933.pdf",
                ""
            };
            
            foreach(var str in strs)
            {
                var ref_num = Core.ExtractRefNumber(str);		
                Console.WriteLine($"Extracted {ref_num} from {str}");	
            }	
            
        }
    }
}
