﻿namespace Zhichkin.Metadata.Model
{
    public enum PropertyPurpose
    {
        /// <summary>The property is being used by system.</summary>
        System,
        /// <summary>The property is being used as a property.</summary>
        Property,
        /// <summary>The property is being used as a dimension.</summary>
        Dimension,
        /// <summary>The property is being used as a measure.</summary>
        Measure
    }
}
