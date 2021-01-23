using System;
using System.Collections.Generic;
using System.Text;

namespace Study03.Data
{
    /// <summary>
    /// The type of a directory item
    /// </summary>
    public enum DirectoryItemType
    {
        /// <summary>
        /// A logical drive
        /// </summary>
        Drive, 

        /// <summary>
        /// A Physical file
        /// </summary>
        File, 

        /// <summary>
        /// A folder
        /// </summary>
        Folder
    }
}
