using QuizAdmin.QuizMasterService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizAdmin
{
    /// <summary>
    /// This interface is created for the sole purpose of using design view (WYSIWYG)
    /// QuizMaster form is a IRepository
    /// </summary>
    public interface IRepository
    {
        QuizMasterServiceClient Service { get; }

        User ActiveUser { get; }
    }
}
