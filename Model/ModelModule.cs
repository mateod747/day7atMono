using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Model.Common;

namespace Model
{
    public class ModelModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PepperModel>().As<IModel>();
            base.Load(builder);
        }
    }
}
