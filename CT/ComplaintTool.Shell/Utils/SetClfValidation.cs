﻿using ComplaintTool.Shell.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using ComplaintTool.Common;
using ComplaintTool.Processing.CLFValidation;
using ComplaintTool.Common.CTLogger;

namespace ComplaintTool.Shell.Utils
{
    [Cmdlet(VerbsCommon.Set,"ClfValidation")]
    public class SetClfValidation:ComplaintCmdletBase
    {
        ILogger Logger = LogManager.GetLogger();

        public override void Process()
        {
            try
            {
                var clfProcessor = new ClfProcessor();
                clfProcessor.UpdateClfReportStatus();
                clfProcessor.ValidateClf();
            }catch(Exception ex)
            {
                Logger.LogComplaintException(ex);
            }
        }
    }
}
