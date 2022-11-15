namespace Question1
{
    

    public interface UGInfo:PersonalInfo
    {
        public string UGMarkSheetNumber { get; set; }
        public double SemesterOne { get; set; }
        public double SemesterTwo { get; set; }
        public double SemesterThree { get; set; }
        public double SemesterFour { get; set; }
        public double TotalMarks { get; set; }
        public double Percentage { get; set; }
        public void ShowHSCMarksheet();
        public void CalculateUG();
        
    }
}