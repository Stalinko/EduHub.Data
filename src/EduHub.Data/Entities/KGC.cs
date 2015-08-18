﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Home Groups
    /// </summary>
    public class KGC : EntityBase
    {
#region Navigation Property Cache
        private SCI _CAMPUS_SCI;
        private SF _TEACHER_SF;
        private SF _TEACHER_B_SF;
        private SM _ROOM_SM;
        private KCY _MIN_AC_YR_KCY;
        private KCY _MAX_AC_YR_KCY;
        private KGC _NEXT_HG_KGC;
#endregion

#region Field Properties
        /// <summary>
        /// (Was FORM) Home Group code
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string KGCKEY { get; internal set; }
        /// <summary>
        /// Description
        /// [Alphanumeric (30)]
        /// </summary>
        public string DESCRIPTION { get; internal set; }
        /// <summary>
        /// Campus
        /// </summary>
        public int? CAMPUS { get; internal set; }
        /// <summary>
        /// Staff code of first or only home group teacher
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER { get; internal set; }
        /// <summary>
        /// Staff code of second home group teacher (if any)
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string TEACHER_B { get; internal set; }
        /// <summary>
        /// Active Home Group? (Y/N)
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string ACTIVE { get; internal set; }
        /// <summary>
        /// Home group room
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string ROOM { get; internal set; }
        /// <summary>
        /// (Was FORM_SIZE) Home group population
        /// </summary>
        public short? HG_SIZE { get; internal set; }
        /// <summary>
        /// Number of male students in home group
        /// </summary>
        public short? MALES { get; internal set; }
        /// <summary>
        /// Number of female students in home group
        /// </summary>
        public short? FEMALES { get; internal set; }
        /// <summary>
        /// (Was AC_YR) Minimum year level covered by home group
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MIN_AC_YR { get; internal set; }
        /// <summary>
        /// Maximum year level covered by home group
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string MAX_AC_YR { get; internal set; }
        /// <summary>
        /// Assumed next home group (eg 8.1 is the group to which 7.1 is promoted)
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string NEXT_HG { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last write operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [CAMPUS] => [SCI].[SCIKEY]
        /// Campus
        /// </summary>
        public SCI CAMPUS_SCI {
            get
            {
                if (CAMPUS.HasValue)
                {
                    if (_CAMPUS_SCI == null)
                    {
                        _CAMPUS_SCI = Context.SCI.FindBySCIKEY(CAMPUS.Value);
                    }
                    return _CAMPUS_SCI;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TEACHER] => [SF].[SFKEY]
        /// Staff code of first or only home group teacher
        /// </summary>
        public SF TEACHER_SF {
            get
            {
                if (TEACHER != null)
                {
                    if (_TEACHER_SF == null)
                    {
                        _TEACHER_SF = Context.SF.FindBySFKEY(TEACHER);
                    }
                    return _TEACHER_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [TEACHER_B] => [SF].[SFKEY]
        /// Staff code of second home group teacher (if any)
        /// </summary>
        public SF TEACHER_B_SF {
            get
            {
                if (TEACHER_B != null)
                {
                    if (_TEACHER_B_SF == null)
                    {
                        _TEACHER_B_SF = Context.SF.FindBySFKEY(TEACHER_B);
                    }
                    return _TEACHER_B_SF;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [ROOM] => [SM].[ROOM]
        /// Home group room
        /// </summary>
        public SM ROOM_SM {
            get
            {
                if (ROOM != null)
                {
                    if (_ROOM_SM == null)
                    {
                        _ROOM_SM = Context.SM.FindByROOM(ROOM);
                    }
                    return _ROOM_SM;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [MIN_AC_YR] => [KCY].[KCYKEY]
        /// (Was AC_YR) Minimum year level covered by home group
        /// </summary>
        public KCY MIN_AC_YR_KCY {
            get
            {
                if (MIN_AC_YR != null)
                {
                    if (_MIN_AC_YR_KCY == null)
                    {
                        _MIN_AC_YR_KCY = Context.KCY.FindByKCYKEY(MIN_AC_YR);
                    }
                    return _MIN_AC_YR_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [MAX_AC_YR] => [KCY].[KCYKEY]
        /// Maximum year level covered by home group
        /// </summary>
        public KCY MAX_AC_YR_KCY {
            get
            {
                if (MAX_AC_YR != null)
                {
                    if (_MAX_AC_YR_KCY == null)
                    {
                        _MAX_AC_YR_KCY = Context.KCY.FindByKCYKEY(MAX_AC_YR);
                    }
                    return _MAX_AC_YR_KCY;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [NEXT_HG] => [KGC].[KGCKEY]
        /// Assumed next home group (eg 8.1 is the group to which 7.1 is promoted)
        /// </summary>
        public KGC NEXT_HG_KGC {
            get
            {
                if (NEXT_HG != null)
                {
                    if (_NEXT_HG_KGC == null)
                    {
                        _NEXT_HG_KGC = Context.KGC.FindByKGCKEY(NEXT_HG);
                    }
                    return _NEXT_HG_KGC;
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