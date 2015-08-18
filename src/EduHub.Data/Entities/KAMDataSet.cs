﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Standard Disciplinary Actions Data Set
    /// </summary>
    public sealed class KAMDataSet : SetBase<KAM>
    {
        private Lazy<Dictionary<string, KAM>> KAMKEYIndex;

        internal KAMDataSet(EduHubContext Context)
            : base(Context)
        {
            KAMKEYIndex = new Lazy<Dictionary<string, KAM>>(() => this.ToDictionary(e => e.KAMKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KAM"; } }

        /// <summary>
        /// Find KAM by KAMKEY key field
        /// </summary>
        /// <param name="Key">KAMKEY value used to find KAM</param>
        /// <returns>Related KAM entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KAMKEY value didn't match any KAM entities</exception>
        public KAM FindByKAMKEY(string Key)
        {
            KAM result;
            if (KAMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KAM by KAMKEY key field
        /// </summary>
        /// <param name="Key">KAMKEY value used to find KAM</param>
        /// <param name="Value">Related KAM entity</param>
        /// <returns>True if the KAM Entity is found</returns>
        public bool TryFindByKAMKEY(string Key, out KAM Value)
        {
            return KAMKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KAM by KAMKEY key field
        /// </summary>
        /// <param name="Key">KAMKEY value used to find KAM</param>
        /// <returns>Related KAM entity, or null if not found</returns>
        public KAM TryFindByKAMKEY(string Key)
        {
            KAM result;
            if (KAMKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KAM, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KAM, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KAMKEY":
                        mapper[i] = (e, v) => e.KAMKEY = v;
                        break;
                    case "BRIEF":
                        mapper[i] = (e, v) => e.BRIEF = v;
                        break;
                    case "DETAIL":
                        mapper[i] = (e, v) => e.DETAIL = v;
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