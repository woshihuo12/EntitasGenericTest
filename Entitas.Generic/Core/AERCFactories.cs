using System;

namespace Entitas.Generic
{
    public class AERCFactories
    {
        public static bool ForceUseUnSafe = false;
        public static readonly Func<IEntity, IAERC> UnsafeAERCFactory = e => new UnsafeAERC();

        public static readonly Func<IEntity, IAERC> SafeAERCFactory = e =>
        {
            if (ForceUseUnSafe)
            {
                return new UnsafeAERC();
            }

            return new SafeAERC(e);
        };
    }
}