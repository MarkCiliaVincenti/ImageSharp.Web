// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.Web.Commands;

namespace SixLabors.ImageSharp.Web
{
    /// <summary>
    /// Provides enumeration for handling <see cref="CommandCollection"/> instances
    /// when processing a request.
    /// </summary>
    public enum CommandHandling
    {
        /// <summary>
        /// The command collection will be stripped of any unknown commands.
        /// </summary>
        Sanitize,

        /// <summary>
        /// The command collection will be processed unaltered.
        /// </summary>
        None
    }
}
