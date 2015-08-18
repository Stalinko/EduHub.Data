﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Adult Group Members
    /// </summary>
    public class SDGM : EntityBase
    {
#region Navigation Property Cache
        private SDG _SDGMKEY_SDG;
        private DR _PERSON_LINK_DR;
#endregion

#region Field Properties
        /// <summary>
        /// Transaction ID
        /// </summary>
        public int? TID { get; internal set; }
        /// <summary>
        /// Group Code
        /// [Uppercase Alphanumeric (12)]
        /// </summary>
        public string SDGMKEY { get; internal set; }
        /// <summary>
        /// Code of this person in table SF or DF
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PERSON_LINK { get; internal set; }
        /// <summary>
        /// Date on which this person joined this group
        /// </summary>
        public DateTime? START_DATE { get; internal set; }
        /// <summary>
        /// Date on which this person left or will leave this group
        /// </summary>
        public DateTime? END_DATE { get; internal set; }
        /// <summary>
        /// Any general comments
        /// [Memo]
        /// </summary>
        public string OTHER_COMMENTS { get; internal set; }
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
        /// Navigation property for [SDGMKEY] => [SDG].[SDGKEY]
        /// Group Code
        /// </summary>
        public SDG SDGMKEY_SDG {
            get
            {
                if (SDGMKEY != null)
                {
                    if (_SDGMKEY_SDG == null)
                    {
                        _SDGMKEY_SDG = Context.SDG.FindBySDGKEY(SDGMKEY);
                    }
                    return _SDGMKEY_SDG;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PERSON_LINK] => [DR].[DRKEY]
        /// Code of this person in table SF or DF
        /// </summary>
        public DR PERSON_LINK_DR {
            get
            {
                if (PERSON_LINK != null)
                {
                    if (_PERSON_LINK_DR == null)
                    {
                        _PERSON_LINK_DR = Context.DR.FindByDRKEY(PERSON_LINK);
                    }
                    return _PERSON_LINK_DR;
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