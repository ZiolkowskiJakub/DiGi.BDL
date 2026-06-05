using DiGi.BDL.Constants;
using System;

namespace DiGi.BDL.Classes
{
    /// <summary>
    /// Specifies that a field belongs to a particular group.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class Group : Attribute
    {
        /// <summary>
        /// Gets the unique identifier of the group.
        /// </summary>
        public string? Id { get; }

        /// <summary>
        /// Gets the display name of the group.
        /// </summary>
        public string? Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Group"/> class with a specified identifier and name.
        /// </summary>
        /// <param name="id">The unique identifier for the group.</param>
        /// <param name="name">The descriptive name for the group.</param>
        public Group(string? id, string? name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Group"/> class with a specified identifier.
        /// </summary>
        /// <param name="id">The unique identifier for the group.</param>
        public Group(string? id)
        {
            Id = id;
            Name = Query.Name(typeof(Name.Group), id);
        }
    }
}
