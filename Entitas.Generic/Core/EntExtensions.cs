using System;

namespace Entitas.Generic
{
    public static class EntExtensions
    {
        public static Boolean IsValid(this IEntity entity, int creationIndex)
        {
            return entity != null
                   && entity.isEnabled
                   && entity.creationIndex == creationIndex;
        }
    }
}