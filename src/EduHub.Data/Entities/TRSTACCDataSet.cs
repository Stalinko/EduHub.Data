﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// STACC Holding Table Data Set
    /// </summary>
    public sealed class TRSTACCDataSet : SetBase<TRSTACC>
    {
        private Lazy<Dictionary<int, TRSTACC>> STACCKEYIndex;

        internal TRSTACCDataSet(EduHubContext Context)
            : base(Context)
        {
            STACCKEYIndex = new Lazy<Dictionary<int, TRSTACC>>(() => this.ToDictionary(e => e.STACCKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TRSTACC"; } }

        /// <summary>
        /// Find TRSTACC by STACCKEY key field
        /// </summary>
        /// <param name="Key">STACCKEY value used to find TRSTACC</param>
        /// <returns>Related TRSTACC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">STACCKEY value didn't match any TRSTACC entities</exception>
        public TRSTACC FindBySTACCKEY(int Key)
        {
            TRSTACC result;
            if (STACCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find TRSTACC by STACCKEY key field
        /// </summary>
        /// <param name="Key">STACCKEY value used to find TRSTACC</param>
        /// <param name="Value">Related TRSTACC entity</param>
        /// <returns>True if the TRSTACC Entity is found</returns>
        public bool TryFindBySTACCKEY(int Key, out TRSTACC Value)
        {
            return STACCKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find TRSTACC by STACCKEY key field
        /// </summary>
        /// <param name="Key">STACCKEY value used to find TRSTACC</param>
        /// <returns>Related TRSTACC entity, or null if not found</returns>
        public TRSTACC TryFindBySTACCKEY(int Key)
        {
            TRSTACC result;
            if (STACCKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<TRSTACC, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<TRSTACC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "STACCKEY":
                        mapper[i] = (e, v) => e.STACCKEY = int.Parse(v);
                        break;
                    case "FIELD01":
                        mapper[i] = (e, v) => e.FIELD01 = v;
                        break;
                    case "FIELD02":
                        mapper[i] = (e, v) => e.FIELD02 = v;
                        break;
                    case "FIELD03":
                        mapper[i] = (e, v) => e.FIELD03 = v;
                        break;
                    case "FIELD04":
                        mapper[i] = (e, v) => e.FIELD04 = v;
                        break;
                    case "FIELD05":
                        mapper[i] = (e, v) => e.FIELD05 = v;
                        break;
                    case "FIELD06":
                        mapper[i] = (e, v) => e.FIELD06 = v;
                        break;
                    case "FIELD07":
                        mapper[i] = (e, v) => e.FIELD07 = v;
                        break;
                    case "FIELD08":
                        mapper[i] = (e, v) => e.FIELD08 = v;
                        break;
                    case "FIELD09":
                        mapper[i] = (e, v) => e.FIELD09 = v;
                        break;
                    case "FIELD10":
                        mapper[i] = (e, v) => e.FIELD10 = v;
                        break;
                    case "FIELD11":
                        mapper[i] = (e, v) => e.FIELD11 = v;
                        break;
                    case "FIELD12":
                        mapper[i] = (e, v) => e.FIELD12 = v;
                        break;
                    case "FIELD13":
                        mapper[i] = (e, v) => e.FIELD13 = v;
                        break;
                    case "FIELD14":
                        mapper[i] = (e, v) => e.FIELD14 = v;
                        break;
                    case "FIELD15":
                        mapper[i] = (e, v) => e.FIELD15 = v;
                        break;
                    case "FIELD16":
                        mapper[i] = (e, v) => e.FIELD16 = v;
                        break;
                    case "FIELD17":
                        mapper[i] = (e, v) => e.FIELD17 = v;
                        break;
                    case "FIELD18":
                        mapper[i] = (e, v) => e.FIELD18 = v;
                        break;
                    case "FIELD19":
                        mapper[i] = (e, v) => e.FIELD19 = v;
                        break;
                    case "FIELD20":
                        mapper[i] = (e, v) => e.FIELD20 = v;
                        break;
                    case "FIELD21":
                        mapper[i] = (e, v) => e.FIELD21 = v;
                        break;
                    case "FIELD22":
                        mapper[i] = (e, v) => e.FIELD22 = v;
                        break;
                    case "FIELD23":
                        mapper[i] = (e, v) => e.FIELD23 = v;
                        break;
                    case "FIELD24":
                        mapper[i] = (e, v) => e.FIELD24 = v;
                        break;
                    case "FIELD25":
                        mapper[i] = (e, v) => e.FIELD25 = v;
                        break;
                    case "FIELD26":
                        mapper[i] = (e, v) => e.FIELD26 = v;
                        break;
                    case "FIELD27":
                        mapper[i] = (e, v) => e.FIELD27 = v;
                        break;
                    case "FIELD28":
                        mapper[i] = (e, v) => e.FIELD28 = v;
                        break;
                    case "FIELD29":
                        mapper[i] = (e, v) => e.FIELD29 = v;
                        break;
                    case "FIELD30":
                        mapper[i] = (e, v) => e.FIELD30 = v;
                        break;
                    case "FIELD31":
                        mapper[i] = (e, v) => e.FIELD31 = v;
                        break;
                    case "FIELD32":
                        mapper[i] = (e, v) => e.FIELD32 = v;
                        break;
                    case "FIELD33":
                        mapper[i] = (e, v) => e.FIELD33 = v;
                        break;
                    case "ERR_FIELD":
                        mapper[i] = (e, v) => e.ERR_FIELD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AM_UMKEY":
                        mapper[i] = (e, v) => e.AM_UMKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "PM_UMKEY":
                        mapper[i] = (e, v) => e.PM_UMKEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_USER":
                        mapper[i] = (e, v) => e.LW_USER = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }
    }
}