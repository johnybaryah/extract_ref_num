namespace ExtractRefNumber.App
{
    public class Core
    {
        public static int ExtractRefNumber(string str)
        {
            if (str == "") return 0;
            
            int potential_num = 0;
            int len_counter = 0;
            int expected_len = 7;
            
            for (int i = 0; i < str.Length; i++)
            {
                var _thischar = str[i];

                // If thischar is a digit
                if (char.IsDigit(_thischar))				
                {
                    // we only add number to potential_num is out len_counter hasn't exceeded the expected count (i.e. 7)
                    if (len_counter < expected_len)
                        potential_num = (potential_num * 10) + int.Parse(_thischar.ToString());	

                    len_counter++;	
                    continue;
                }
                
                // if not digit - and we have some num as potential number and (if lencounter is greater / smaller than expected len)
                // we are not interested in this number 
                // as nunmber has to be equals 7 length
                if (!char.IsDigit(_thischar) && potential_num > 0 && len_counter != expected_len)
                {
                    len_counter = potential_num = 0;
                }

                // this satisfied our condition hence we return
                if (potential_num > 0 && len_counter == expected_len)
                    return potential_num;
            }	
            return 0;
        }
    }
}