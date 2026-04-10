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
    }
}
