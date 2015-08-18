﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Census Application Message Data
    /// </summary>
    public class SCEN_APP : EntityBase
    {
#region Navigation Property Cache
#endregion

#region Field Properties
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string ITEMNAME { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string ITEMVALUE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string ITEMTYPE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string ITEMMINITYPE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (255)]
        /// </summary>
        public string ITEMCOMMENTS { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}