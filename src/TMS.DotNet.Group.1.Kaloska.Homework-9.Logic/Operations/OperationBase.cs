using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.DotNet.Group._1.Kaloska.Homework_9.Logic.Operations
{
    public abstract class OperationBase
    {
        public abstract int Id { get; }

        public abstract string Name { get; }

        public abstract Task ShowData();
    }
}
