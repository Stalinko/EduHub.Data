﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Data Transfer Table
    /// </summary>
    public class ST_TFRIO : EntityBase
    {
#region Navigation Property Cache
        private SKGS _DEST_SCHOOL_SKGS;
#endregion

#region Field Properties
        /// <summary>
        /// 
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Unique Record ID
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string ST_TRANS_ID { get; internal set; }
        /// <summary>
        /// ST.STKEY
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STKEY { get; internal set; }
        /// <summary>
        /// ST.STKEY NEW
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string STKEY_NEW { get; internal set; }
        /// <summary>
        /// ST.REGISTRATION
        /// </summary>
        public short? REGISTRATION { get; internal set; }
        /// <summary>
        /// Y/N
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string TFR_PERMISSION { get; internal set; }
        /// <summary>
        /// Source school ID
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string SOURCE_SCHOOL { get; internal set; }
        /// <summary>
        /// Destination school ID
        /// [Uppercase Alphanumeric (8)]
        /// </summary>
        public string DEST_SCHOOL { get; internal set; }
        /// <summary>
        /// Y or blank, confirmation of receipt at destination
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string RECD_AT_DEST { get; internal set; }
        /// <summary>
        /// TRANSFER, RETRANSFER and COMPLETE
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string TFR_STATUS { get; internal set; }
        /// <summary>
        /// Date of transfer/import
        /// </summary>
        public DateTime? TFR_DATE { get; internal set; }
        /// <summary>
        /// Transfer comments
        /// [Alphanumeric (250)]
        /// </summary>
        public string TFR_COMMENT { get; internal set; }
        /// <summary>
        /// Last Write Date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write Time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last Write User
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [DEST_SCHOOL] => [SKGS].[SCHOOL]
        /// Destination school ID
        /// </summary>
        public SKGS DEST_SCHOOL_SKGS {
            get
            {
                if (DEST_SCHOOL != null)
                {
                    if (_DEST_SCHOOL_SKGS == null)
                    {
                        _DEST_SCHOOL_SKGS = Context.SKGS.FindBySCHOOL(DEST_SCHOOL);
                    }
                    return _DEST_SCHOOL_SKGS;
                }
                else
                {
                    return null;
                }
            }
        }
#endregion
    }
}