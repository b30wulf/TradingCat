﻿namespace Core.DataAccess.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}