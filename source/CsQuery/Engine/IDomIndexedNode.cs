﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsQuery
{
    /// <summary>
    /// An marker and interface exposing properties required for a node that should be indexed
    /// </summary>
    
    public interface IDomIndexedNode: IDomNode
    {
        /// <summary>
        /// A sequence of all the index keys that can be used to access this object
        /// </summary>
        ///
        /// <returns>
        /// An sequence of strings
        /// </returns>

        //IEnumerable<ushort[]> IndexKeysRanged();

        /// <summary>
        /// Enumerates index keys in this collection.
        /// </summary>
        ///
        /// <returns>
        /// An enumerator that allows foreach to be used to process index keys in this collection.
        /// </returns>

        IEnumerable<ushort[]> IndexKeys();

        /// <summary>
        /// The object that is the target of the index (normally, the object itself)
        /// </summary>

        IDomObject IndexReference { get; }


    }
}
