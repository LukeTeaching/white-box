namespace ServicesLib
{
    public class Services
    {
        public string GetRank(double score)
        {
            if (score < 0 || score > 10) return "Invalid"; // Nhánh 1
            if (score >= 8) return "Excellent";           // Nhánh 2
            if (score >= 5) return "Pass";                // Nhánh 3
            return "Fail";                                // Nhánh 4
        }
    }
}
