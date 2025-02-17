﻿// Copyright (c) 2007 Joel Bennett
// This File is license under the Ms Reciprocal License

// Copyright Grant- Subject to the terms of this license, each contributor grants you 
// a non-exclusive, worldwide, royalty-free copyright license to reproduce its contribution, 
// prepare derivative works of its contribution, and distribute its contribution or any 
// derivative works that you create.

// Conditions and Limitations

// Reciprocal Grants- For any file you distribute that contains code from the software
// (in source code or binary format), you must provide recipients the source code to that 
// file along with a copy of this license, which license will govern that file. You may 
// license other files that are entirely your own work and do not contain code from the 
// software under any terms you choose.

// *****************************************************************************
// NOTE: For current and complete licensing information please see:
// http://www.codeplex.com/WASP/Project/License.aspx
//

using System.Management.Automation;
using System.Windows.Automation;

namespace Huddled.Wasp
{
    [Cmdlet(VerbsCommunications.Send, "Keys", DefaultParameterSetName = "Default", SupportsShouldProcess = true)]
    public class SendKeysCommand : AutomationElementCmdletBase
    {
        [Alias("Text", "Value")]
        [Parameter(Position = 1, Mandatory = true, ParameterSetName = "Default")]
        public string Keys { get; set; }

        public override void ProcessAutomationElement(AutomationElement element)
        {
            // TODO: if(!hWnd.IsInvalid) hWnd.Activate();
            element.SetFocus();
            System.Windows.Forms.SendKeys.SendWait(Keys);
        }
    }
}
