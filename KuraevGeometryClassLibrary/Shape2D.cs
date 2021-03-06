﻿namespace KuraevGeometryClassLibrary
{
    public abstract class Shape2D
    {
        public Shape2D(string type)
        {
            Type = type;
        }
        public string Type { get; }
        public abstract double GetArea();
    }
}
