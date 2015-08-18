﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Archived Census Class Sizes Validation Data Data Set
    /// </summary>
    public sealed class SCEN_ACVDataSet : SetBase<SCEN_ACV>
    {
        private Lazy<Dictionary<int, SCEN_ACV>> IDIndex;

        internal SCEN_ACVDataSet(EduHubContext Context)
            : base(Context)
        {
            IDIndex = new Lazy<Dictionary<int, SCEN_ACV>>(() => this.ToDictionary(e => e.ID));
        }

        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SCEN_ACV"; } }

        /// <summary>
        /// Find SCEN_ACV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_ACV</param>
        /// <returns>Related SCEN_ACV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">ID value didn't match any SCEN_ACV entities</exception>
        public SCEN_ACV FindByID(int Key)
        {
            SCEN_ACV result;
            if (IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Key");
            }
        }

        /// <summary>
        /// Attempt to find SCEN_ACV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_ACV</param>
        /// <param name="Value">Related SCEN_ACV entity</param>
        /// <returns>True if the SCEN_ACV Entity is found</returns>
        public bool TryFindByID(int Key, out SCEN_ACV Value)
        {
            return IDIndex.Value.TryGetValue(Key, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_ACV by ID key field
        /// </summary>
        /// <param name="Key">ID value used to find SCEN_ACV</param>
        /// <returns>Related SCEN_ACV entity, or null if not found</returns>
        public SCEN_ACV TryFindByID(int Key)
        {
            SCEN_ACV result;
            if (IDIndex.Value.TryGetValue(Key, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        protected override Action<SCEN_ACV, string>[] BuildMapper(List<string> Headers)
        {
            var mapper = new Action<SCEN_ACV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ID_RETURN":
                        mapper[i] = (e, v) => e.ID_RETURN = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CLASSCODE":
                        mapper[i] = (e, v) => e.CLASSCODE = v;
                        break;
                    case "ID_CLASSVALIDATIONTYPE":
                        mapper[i] = (e, v) => e.ID_CLASSVALIDATIONTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "CREATEUSER":
                        mapper[i] = (e, v) => e.CREATEUSER = v;
                        break;
                    case "CREATED":
                        mapper[i] = (e, v) => e.CREATED = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LUPDATEUSER":
                        mapper[i] = (e, v) => e.LUPDATEUSER = v;
                        break;
                    case "LUPDATED":
                        mapper[i] = (e, v) => e.LUPDATED = v == null ? (DateTime?)null : DateTime.Parse(v);
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