using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StepEditText
{
    class RunReport
    {
        public static void PositiveResult(string Actual)
        {
            Ranorex.Report.Success("Sucessfully Perforemed", Actual);
        }

        public static void NegativeResult(string Actual, string Expected)
        {
            Ranorex.Report.Error("STOP THE VERSION", Actual);
            Ranorex.Report.Error("THE EXPECTED TEXT MUST BE", Expected);
        }
    }
    class UtilityRun
    {
        public static void InspectText(string Actual, string Hardcoded)
        {
            string strActualText = Actual;
            string strExpectedText = Hardcoded;

            bool bCompareText = true;

            bCompareText = strActualText.CompareTo(strExpectedText) == 0;

            if (bCompareText)
                RunReport.PositiveResult(strActualText);

            else
                RunReport.NegativeResult(strActualText, strExpectedText);


                
        }
    }
}
