using System;
using System.Windows.Forms;

namespace FacebookDesktopApplication
{
    internal static class FormFactory
    {
        private static FormMain s_FormMain = null;

        public enum eFormType
        {
            FormMain,
            FormFindMatch,
            FormOptimalTime,
            FormPostStatus
        }

    public static Form CreateNewForm(eFormType i_FormType)
        {
            if(s_FormMain == null && i_FormType != eFormType.FormMain)
            {
                throw new Exception("There is no FormMain. Create it first.");
            }
            else
            {
                Form outputForm = null;

                switch (i_FormType)
                {
                    case eFormType.FormMain:
                        s_FormMain = new FormMain();
                        outputForm = s_FormMain;
                        break;
                    case eFormType.FormFindMatch:
                        outputForm = new FormFindMatch(s_FormMain);
                        break;
                    case eFormType.FormOptimalTime:
                        outputForm = new FormOptimalTime(s_FormMain);
                        break;
                    case eFormType.FormPostStatus:
                        outputForm = new FormPostStatus(s_FormMain);
                        break;
                    default:
                        throw new Exception("invalid form to create.");
                }

                return outputForm;
            }
        }
    }
}
