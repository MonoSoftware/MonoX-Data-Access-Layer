using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoSoftware.MonoX.DAL.EntityClasses
{
    public partial class SnAlbumEntity
    {
        /// <summary>
        /// Gets or sets album cover file.
        /// <para>
        /// Note: This property must be set manually, if  you use MonoX AlbumRepository then it is set automatically.
        /// </para>
        /// </summary>
        public SnFileEntity AlbumCoverSnFile { get; set; }
    }
}
