
namespace Question1
{

    public interface HSCInfo:PersonalInfo
    {
        public string HSCMarksheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get; set; }
        public double PercentageMarks { get; set; }
        public void ShowHSCMarksheet();
        public void CalculateHSC();
     
    }
}