using System;
using System.Collections.Generic;

namespace GenericsOOP
{
    public class Path
    {
        public GenericList<Point> Points { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:GenericsOOP.Path"/> class.
        /// </summary>
        /// <param name="capacity">GenericList Capacity.</param>
        public Path(int capacity = 5)
        {
            Points = new GenericList<Point>(capacity);
        }
    }
}