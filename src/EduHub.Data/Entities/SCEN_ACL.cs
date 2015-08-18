﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Archived Census Class Sizes Data
    /// </summary>
    public class SCEN_ACL : EntityBase
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
        /// </summary>
        public int? ID_RETURN { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? CAMPUSNUMBER { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (5)]
        /// </summary>
        public string CLASSCODE { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string CLASSTYPE { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public double? FTETEACHERS { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? PREP { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? SCHOOL_YEAR01 { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? SCHOOL_YEAR02 { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? SCHOOL_YEAR03 { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? SCHOOL_YEAR04 { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? SCHOOL_YEAR05 { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? SCHOOL_YEAR06 { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? SCHOOL_YEAR07 { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? SCHOOL_YEAR08 { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? SCHOOL_YEAR09 { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? SCHOOL_YEAR10 { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? SCHOOL_YEAR11 { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? SCHOOL_YEAR12 { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? PRIMARYUG { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public short? SENIORUG { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CREATED { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string CREATEUSER { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LUPDATEUSER { get; internal set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? LUPDATED { get; internal set; }
#endregion

#region Navigation Properties
#endregion
    }
}