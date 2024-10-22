using UiPath.CodedWorkflows;
using System;

namespace BlankProcess1
{
    public class ExcelFactory
    {
        public ExcelFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class O365MailFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection My_Workspace_Mohamed_Hosney_keitmea_com { get; set; }

        public O365MailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_Mohamed_Hosney_keitmea_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("42e33344-5502-492b-9eb9-a2812a3e91ec", resolver);
        }
    }

    public class OneDriveFactory
    {
        public OneDriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }
}