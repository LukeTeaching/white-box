namespace ServicesLib
{
    public class Services
    {
        public string GetRank(double score)
        {
            if (score < 0 || score > 10) return "Invalid"; 
            if (score >= 8) return "Excellent";           
            if (score >= 5) return "Pass";                
            return "Fail";                                
        }

        //public string ProcessGrades(double[] grades)
        //{
        //    if (grades.Length == 0) return "Empty List";

        //    double sum = 0;
        //    for (int i = 0; i < grades.Length; i++)
        //    {
        //        if (grades[i] < 0 || grades[i] > 10)
        //        {
        //            return "Invalid Grade";
        //        }
        //        sum += grades[i];
        //    }

        //    double avg = sum / grades.Length;

        //    if (avg >= 8.0) return "Excellent";
        //    if (avg >= 5.0) return "Passed";

        //    return "Failed";
        //}
    }
}
