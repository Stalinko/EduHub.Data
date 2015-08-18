﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Areas of Teaching Data Set
    /// </summary>
    public sealed class KSADataSet : SetBase<KSA>
    {
        private Lazy<Dictionary<string, KSA>> KSAKEYIndex;

        internal KSADataSet(EduHubContext Context)
            : base(Context)
        {
            KSAKEYIndex = new Lazy<Dictionary<string, KSA>>(() => this.ToDictionary(e => e.KSAKEY));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KSA"; } }

        /// <summary>
        /// Find KSA by KSAKEY key field
        /// </summary>
        /// <param name="Key">KSAKEY value used to find KSA</param>
        /// <returns>Related KSA entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">KSAKEY value didn't match any KSA entities</exception>
        public KSA FindByKSAKEY(string Key)
        {
            KSA result;
            if (KSAKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find KSA by KSAKEY key field
        /// </summary>
        /// <param name="Key">KSAKEY value used to find KSA</param>
        /// <param name="Value">Related KSA entity</param>
        /// <returns>True if the KSA Entity is found</returns>
        public bool TryFindByKSAKEY(string Key, out KSA Value)
        {
            return KSAKEYIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find KSA by KSAKEY key field
        /// </summary>
        /// <param name="Key">KSAKEY value used to find KSA</param>
        /// <returns>Related KSA entity, or null if not found</returns>
        public KSA TryFindByKSAKEY(string Key)
        {
            KSA result;
            if (KSAKEYIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<KSA, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<KSA, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KSAKEY":
                        mapper[i] = (e, v) => e.KSAKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
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