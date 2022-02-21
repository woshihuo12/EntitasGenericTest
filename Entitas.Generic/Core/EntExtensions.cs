namespace Entitas.Generic
{
    public static class EntExtensions
    {
        public static bool IsValid(this IEntity entity, int creationIndex)
        {
            return entity != null
                   && entity.isEnabled
                   && entity.creationIndex == creationIndex;
        }
    }
}