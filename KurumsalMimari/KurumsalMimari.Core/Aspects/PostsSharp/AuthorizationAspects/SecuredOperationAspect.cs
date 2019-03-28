using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace KurumsalMimari.Core.Aspects.PostsSharp.AuthorizationAspects
{
    [Serializable]
    public class SecuredOperationAspect : OnMethodBoundaryAspect
    {
        public string Roles { get; set; }

        public override void OnEntry(MethodExecutionArgs args)
        {
            string[] roles = Roles.Split(',');
            bool isAuthorized = false;
            for (int i = 0; i < roles.Length; i++)
            {
                if (!System.Threading.Thread.CurrentPrincipal.IsInRole(roles[i]))
                {
                    isAuthorized = true;
                }
            }

            if (!isAuthorized)
            {
                throw new SecurityException("You are not authorized!");
            }

            base.OnEntry(args);
        }
    }
}
