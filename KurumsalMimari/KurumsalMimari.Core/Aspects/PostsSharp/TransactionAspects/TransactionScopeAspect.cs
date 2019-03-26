using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using PostSharp.Aspects;

namespace KurumsalMimari.Core.Aspects.PostsSharp.TransactionAspects
{
    public class TransactionScopeAspect:OnMethodBoundaryAspect
    {
        TransactionScopeOption _option;

        public TransactionScopeAspect()
        {

        }
        public TransactionScopeAspect(TransactionScopeOption option)
        {
            _option = option;
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            args.MethodExecutionTag = new TransactionScope(_option);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Complete();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Dispose();
        }
    }
}
