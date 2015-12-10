﻿using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Groupings Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SGDataSet : DataSetBase<SG>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SG"; } }

        internal SGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ABS_TYPE = new Lazy<NullDictionary<short?, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.ABS_TYPE));
            Index_CAND_FIRST_YR = new Lazy<NullDictionary<string, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.CAND_FIRST_YR));
            Index_CAND_LAST_YR = new Lazy<NullDictionary<string, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.CAND_LAST_YR));
            Index_FROM_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.FROM_CAMPUS));
            Index_FUT_FIRST_YR = new Lazy<NullDictionary<string, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.FUT_FIRST_YR));
            Index_FUT_LAST_YR = new Lazy<NullDictionary<string, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.FUT_LAST_YR));
            Index_HOUSE = new Lazy<NullDictionary<string, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.HOUSE));
            Index_SGKEY = new Lazy<Dictionary<string, SG>>(() => this.ToDictionary(i => i.SGKEY));
            Index_TO_CAMPUS = new Lazy<NullDictionary<int?, IReadOnlyList<SG>>>(() => this.ToGroupedNullDictionary(i => i.TO_CAMPUS));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SG" /> fields for each CSV column header</returns>
        protected override Action<SG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SGKEY":
                        mapper[i] = (e, v) => e.SGKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "GROUP_TYPE":
                        mapper[i] = (e, v) => e.GROUP_TYPE = v;
                        break;
                    case "GROUP_CATEGORY":
                        mapper[i] = (e, v) => e.GROUP_CATEGORY = v;
                        break;
                    case "SOURCE_SG":
                        mapper[i] = (e, v) => e.SOURCE_SG = v;
                        break;
                    case "STRICT_CRITERIA":
                        mapper[i] = (e, v) => e.STRICT_CRITERIA = v;
                        break;
                    case "MAX_NUMBER_STUD":
                        mapper[i] = (e, v) => e.MAX_NUMBER_STUD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STRUCTURE":
                        mapper[i] = (e, v) => e.STRUCTURE = v;
                        break;
                    case "START_DATE":
                        mapper[i] = (e, v) => e.START_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "END_DATE":
                        mapper[i] = (e, v) => e.END_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "CESSATION_DATE":
                        mapper[i] = (e, v) => e.CESSATION_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "HOUSE_HOMEGROUP":
                        mapper[i] = (e, v) => e.HOUSE_HOMEGROUP = v;
                        break;
                    case "SCOPE":
                        mapper[i] = (e, v) => e.SCOPE = v;
                        break;
                    case "FROM_CAMPUS":
                        mapper[i] = (e, v) => e.FROM_CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TO_CAMPUS":
                        mapper[i] = (e, v) => e.TO_CAMPUS = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "CAND_FIRST_YR":
                        mapper[i] = (e, v) => e.CAND_FIRST_YR = v;
                        break;
                    case "CAND_LAST_YR":
                        mapper[i] = (e, v) => e.CAND_LAST_YR = v;
                        break;
                    case "FUT_FIRST_YR":
                        mapper[i] = (e, v) => e.FUT_FIRST_YR = v;
                        break;
                    case "FUT_LAST_YR":
                        mapper[i] = (e, v) => e.FUT_LAST_YR = v;
                        break;
                    case "CAND_FIRST_AGE":
                        mapper[i] = (e, v) => e.CAND_FIRST_AGE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "CAND_LAST_AGE":
                        mapper[i] = (e, v) => e.CAND_LAST_AGE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "AGE_DATE":
                        mapper[i] = (e, v) => e.AGE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "FIRST_DOB":
                        mapper[i] = (e, v) => e.FIRST_DOB = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LAST_DOB":
                        mapper[i] = (e, v) => e.LAST_DOB = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "GENDERA":
                        mapper[i] = (e, v) => e.GENDERA = v;
                        break;
                    case "GENDERB":
                        mapper[i] = (e, v) => e.GENDERB = v;
                        break;
                    case "HOUSE":
                        mapper[i] = (e, v) => e.HOUSE = v;
                        break;
                    case "DAYONE":
                        mapper[i] = (e, v) => e.DAYONE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "DO_FIRST_PERD":
                        mapper[i] = (e, v) => e.DO_FIRST_PERD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LASTDAY":
                        mapper[i] = (e, v) => e.LASTDAY = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LD_LAST_PERD":
                        mapper[i] = (e, v) => e.LD_LAST_PERD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DAYONE_AM_PM":
                        mapper[i] = (e, v) => e.DAYONE_AM_PM = v;
                        break;
                    case "LASTDAY_AM_PM":
                        mapper[i] = (e, v) => e.LASTDAY_AM_PM = v;
                        break;
                    case "ABS_TYPE":
                        mapper[i] = (e, v) => e.ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PREV_ABS_TYPE":
                        mapper[i] = (e, v) => e.PREV_ABS_TYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FREQUENCY":
                        mapper[i] = (e, v) => e.FREQUENCY = v;
                        break;
                    case "DESTINATION":
                        mapper[i] = (e, v) => e.DESTINATION = v;
                        break;
                    case "VENUE_ADDRESS":
                        mapper[i] = (e, v) => e.VENUE_ADDRESS = v;
                        break;
                    case "EXC_GLCODE":
                        mapper[i] = (e, v) => e.EXC_GLCODE = v;
                        break;
                    case "FEEDBACK":
                        mapper[i] = (e, v) => e.FEEDBACK = v;
                        break;
                    case "SPECIAL_NEEDS":
                        mapper[i] = (e, v) => e.SPECIAL_NEEDS = v;
                        break;
                    case "EXC_PURPOSE":
                        mapper[i] = (e, v) => e.EXC_PURPOSE = v;
                        break;
                    case "EXC_SERVICE_PROVIDER":
                        mapper[i] = (e, v) => e.EXC_SERVICE_PROVIDER = v;
                        break;
                    case "TRANSPORT_METHOD":
                        mapper[i] = (e, v) => e.TRANSPORT_METHOD = v;
                        break;
                    case "EXC_TRANSPORT_PROVIDER":
                        mapper[i] = (e, v) => e.EXC_TRANSPORT_PROVIDER = v;
                        break;
                    case "FIXED_TRANS_COST":
                        mapper[i] = (e, v) => e.FIXED_TRANS_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PER_ST_TRANS_COST":
                        mapper[i] = (e, v) => e.PER_ST_TRANS_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "FIXED_VENUE_COST":
                        mapper[i] = (e, v) => e.FIXED_VENUE_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "PER_ST_VENUE_COST":
                        mapper[i] = (e, v) => e.PER_ST_VENUE_COST = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OTHER_COSTS":
                        mapper[i] = (e, v) => e.OTHER_COSTS = v;
                        break;
                    case "EXC_AMOUNT":
                        mapper[i] = (e, v) => e.EXC_AMOUNT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STAFF_MEMBERS":
                        mapper[i] = (e, v) => e.STAFF_MEMBERS = v;
                        break;
                    case "PARENT_MEMBERS":
                        mapper[i] = (e, v) => e.PARENT_MEMBERS = v;
                        break;
                    case "RESP_PERSON_TYPE":
                        mapper[i] = (e, v) => e.RESP_PERSON_TYPE = v;
                        break;
                    case "ADULT_RESPONSIBLE":
                        mapper[i] = (e, v) => e.ADULT_RESPONSIBLE = v;
                        break;
                    case "RESP_PARENT_GENDER":
                        mapper[i] = (e, v) => e.RESP_PARENT_GENDER = v;
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

        /// <summary>
        /// Merges <see cref="SG" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SG" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SG" /> items to added or update the base <see cref="SG" /> items</param>
        /// <returns>A merged list of <see cref="SG" /> items</returns>
        protected override List<SG> ApplyDeltaItems(List<SG> Items, List<SG> DeltaItems)
        {
            Dictionary<string, int> Index_SGKEY = Items.ToIndexDictionary(i => i.SGKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SG deltaItem in DeltaItems)
            {
                int index;

                if (Index_SGKEY.TryGetValue(deltaItem.SGKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SGKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<short?, IReadOnlyList<SG>>> Index_ABS_TYPE;
        private Lazy<NullDictionary<string, IReadOnlyList<SG>>> Index_CAND_FIRST_YR;
        private Lazy<NullDictionary<string, IReadOnlyList<SG>>> Index_CAND_LAST_YR;
        private Lazy<NullDictionary<int?, IReadOnlyList<SG>>> Index_FROM_CAMPUS;
        private Lazy<NullDictionary<string, IReadOnlyList<SG>>> Index_FUT_FIRST_YR;
        private Lazy<NullDictionary<string, IReadOnlyList<SG>>> Index_FUT_LAST_YR;
        private Lazy<NullDictionary<string, IReadOnlyList<SG>>> Index_HOUSE;
        private Lazy<Dictionary<string, SG>> Index_SGKEY;
        private Lazy<NullDictionary<int?, IReadOnlyList<SG>>> Index_TO_CAMPUS;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SG by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByABS_TYPE(short? ABS_TYPE)
        {
            return Index_ABS_TYPE.Value[ABS_TYPE];
        }

        /// <summary>
        /// Attempt to find SG by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByABS_TYPE(short? ABS_TYPE, out IReadOnlyList<SG> Value)
        {
            return Index_ABS_TYPE.Value.TryGetValue(ABS_TYPE, out Value);
        }

        /// <summary>
        /// Attempt to find SG by ABS_TYPE field
        /// </summary>
        /// <param name="ABS_TYPE">ABS_TYPE value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByABS_TYPE(short? ABS_TYPE)
        {
            IReadOnlyList<SG> value;
            if (Index_ABS_TYPE.Value.TryGetValue(ABS_TYPE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by CAND_FIRST_YR field
        /// </summary>
        /// <param name="CAND_FIRST_YR">CAND_FIRST_YR value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByCAND_FIRST_YR(string CAND_FIRST_YR)
        {
            return Index_CAND_FIRST_YR.Value[CAND_FIRST_YR];
        }

        /// <summary>
        /// Attempt to find SG by CAND_FIRST_YR field
        /// </summary>
        /// <param name="CAND_FIRST_YR">CAND_FIRST_YR value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAND_FIRST_YR(string CAND_FIRST_YR, out IReadOnlyList<SG> Value)
        {
            return Index_CAND_FIRST_YR.Value.TryGetValue(CAND_FIRST_YR, out Value);
        }

        /// <summary>
        /// Attempt to find SG by CAND_FIRST_YR field
        /// </summary>
        /// <param name="CAND_FIRST_YR">CAND_FIRST_YR value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByCAND_FIRST_YR(string CAND_FIRST_YR)
        {
            IReadOnlyList<SG> value;
            if (Index_CAND_FIRST_YR.Value.TryGetValue(CAND_FIRST_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by CAND_LAST_YR field
        /// </summary>
        /// <param name="CAND_LAST_YR">CAND_LAST_YR value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByCAND_LAST_YR(string CAND_LAST_YR)
        {
            return Index_CAND_LAST_YR.Value[CAND_LAST_YR];
        }

        /// <summary>
        /// Attempt to find SG by CAND_LAST_YR field
        /// </summary>
        /// <param name="CAND_LAST_YR">CAND_LAST_YR value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCAND_LAST_YR(string CAND_LAST_YR, out IReadOnlyList<SG> Value)
        {
            return Index_CAND_LAST_YR.Value.TryGetValue(CAND_LAST_YR, out Value);
        }

        /// <summary>
        /// Attempt to find SG by CAND_LAST_YR field
        /// </summary>
        /// <param name="CAND_LAST_YR">CAND_LAST_YR value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByCAND_LAST_YR(string CAND_LAST_YR)
        {
            IReadOnlyList<SG> value;
            if (Index_CAND_LAST_YR.Value.TryGetValue(CAND_LAST_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by FROM_CAMPUS field
        /// </summary>
        /// <param name="FROM_CAMPUS">FROM_CAMPUS value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByFROM_CAMPUS(int? FROM_CAMPUS)
        {
            return Index_FROM_CAMPUS.Value[FROM_CAMPUS];
        }

        /// <summary>
        /// Attempt to find SG by FROM_CAMPUS field
        /// </summary>
        /// <param name="FROM_CAMPUS">FROM_CAMPUS value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFROM_CAMPUS(int? FROM_CAMPUS, out IReadOnlyList<SG> Value)
        {
            return Index_FROM_CAMPUS.Value.TryGetValue(FROM_CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SG by FROM_CAMPUS field
        /// </summary>
        /// <param name="FROM_CAMPUS">FROM_CAMPUS value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByFROM_CAMPUS(int? FROM_CAMPUS)
        {
            IReadOnlyList<SG> value;
            if (Index_FROM_CAMPUS.Value.TryGetValue(FROM_CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by FUT_FIRST_YR field
        /// </summary>
        /// <param name="FUT_FIRST_YR">FUT_FIRST_YR value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByFUT_FIRST_YR(string FUT_FIRST_YR)
        {
            return Index_FUT_FIRST_YR.Value[FUT_FIRST_YR];
        }

        /// <summary>
        /// Attempt to find SG by FUT_FIRST_YR field
        /// </summary>
        /// <param name="FUT_FIRST_YR">FUT_FIRST_YR value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFUT_FIRST_YR(string FUT_FIRST_YR, out IReadOnlyList<SG> Value)
        {
            return Index_FUT_FIRST_YR.Value.TryGetValue(FUT_FIRST_YR, out Value);
        }

        /// <summary>
        /// Attempt to find SG by FUT_FIRST_YR field
        /// </summary>
        /// <param name="FUT_FIRST_YR">FUT_FIRST_YR value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByFUT_FIRST_YR(string FUT_FIRST_YR)
        {
            IReadOnlyList<SG> value;
            if (Index_FUT_FIRST_YR.Value.TryGetValue(FUT_FIRST_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by FUT_LAST_YR field
        /// </summary>
        /// <param name="FUT_LAST_YR">FUT_LAST_YR value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByFUT_LAST_YR(string FUT_LAST_YR)
        {
            return Index_FUT_LAST_YR.Value[FUT_LAST_YR];
        }

        /// <summary>
        /// Attempt to find SG by FUT_LAST_YR field
        /// </summary>
        /// <param name="FUT_LAST_YR">FUT_LAST_YR value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByFUT_LAST_YR(string FUT_LAST_YR, out IReadOnlyList<SG> Value)
        {
            return Index_FUT_LAST_YR.Value.TryGetValue(FUT_LAST_YR, out Value);
        }

        /// <summary>
        /// Attempt to find SG by FUT_LAST_YR field
        /// </summary>
        /// <param name="FUT_LAST_YR">FUT_LAST_YR value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByFUT_LAST_YR(string FUT_LAST_YR)
        {
            IReadOnlyList<SG> value;
            if (Index_FUT_LAST_YR.Value.TryGetValue(FUT_LAST_YR, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by HOUSE field
        /// </summary>
        /// <param name="HOUSE">HOUSE value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByHOUSE(string HOUSE)
        {
            return Index_HOUSE.Value[HOUSE];
        }

        /// <summary>
        /// Attempt to find SG by HOUSE field
        /// </summary>
        /// <param name="HOUSE">HOUSE value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByHOUSE(string HOUSE, out IReadOnlyList<SG> Value)
        {
            return Index_HOUSE.Value.TryGetValue(HOUSE, out Value);
        }

        /// <summary>
        /// Attempt to find SG by HOUSE field
        /// </summary>
        /// <param name="HOUSE">HOUSE value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByHOUSE(string HOUSE)
        {
            IReadOnlyList<SG> value;
            if (Index_HOUSE.Value.TryGetValue(HOUSE, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by SGKEY field
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SG</param>
        /// <returns>Related SG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SG FindBySGKEY(string SGKEY)
        {
            return Index_SGKEY.Value[SGKEY];
        }

        /// <summary>
        /// Attempt to find SG by SGKEY field
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SG</param>
        /// <param name="Value">Related SG entity</param>
        /// <returns>True if the related SG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySGKEY(string SGKEY, out SG Value)
        {
            return Index_SGKEY.Value.TryGetValue(SGKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SG by SGKEY field
        /// </summary>
        /// <param name="SGKEY">SGKEY value used to find SG</param>
        /// <returns>Related SG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SG TryFindBySGKEY(string SGKEY)
        {
            SG value;
            if (Index_SGKEY.Value.TryGetValue(SGKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SG by TO_CAMPUS field
        /// </summary>
        /// <param name="TO_CAMPUS">TO_CAMPUS value used to find SG</param>
        /// <returns>List of related SG entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> FindByTO_CAMPUS(int? TO_CAMPUS)
        {
            return Index_TO_CAMPUS.Value[TO_CAMPUS];
        }

        /// <summary>
        /// Attempt to find SG by TO_CAMPUS field
        /// </summary>
        /// <param name="TO_CAMPUS">TO_CAMPUS value used to find SG</param>
        /// <param name="Value">List of related SG entities</param>
        /// <returns>True if the list of related SG entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTO_CAMPUS(int? TO_CAMPUS, out IReadOnlyList<SG> Value)
        {
            return Index_TO_CAMPUS.Value.TryGetValue(TO_CAMPUS, out Value);
        }

        /// <summary>
        /// Attempt to find SG by TO_CAMPUS field
        /// </summary>
        /// <param name="TO_CAMPUS">TO_CAMPUS value used to find SG</param>
        /// <returns>List of related SG entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SG> TryFindByTO_CAMPUS(int? TO_CAMPUS)
        {
            IReadOnlyList<SG> value;
            if (Index_TO_CAMPUS.Value.TryGetValue(TO_CAMPUS, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns SQL which checks for the existence of a SG table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SG](
        [SGKEY] varchar(12) NOT NULL,
        [TITLE] varchar(30) NULL,
        [GROUP_TYPE] varchar(1) NULL,
        [GROUP_CATEGORY] varchar(20) NULL,
        [SOURCE_SG] varchar(12) NULL,
        [STRICT_CRITERIA] varchar(1) NULL,
        [MAX_NUMBER_STUD] smallint NULL,
        [STRUCTURE] text NULL,
        [START_DATE] datetime NULL,
        [END_DATE] datetime NULL,
        [CESSATION_DATE] datetime NULL,
        [HOUSE_HOMEGROUP] varchar(1) NULL,
        [SCOPE] varchar(1) NULL,
        [FROM_CAMPUS] int NULL,
        [TO_CAMPUS] int NULL,
        [CAND_FIRST_YR] varchar(4) NULL,
        [CAND_LAST_YR] varchar(4) NULL,
        [FUT_FIRST_YR] varchar(4) NULL,
        [FUT_LAST_YR] varchar(4) NULL,
        [CAND_FIRST_AGE] smallint NULL,
        [CAND_LAST_AGE] smallint NULL,
        [AGE_DATE] datetime NULL,
        [FIRST_DOB] datetime NULL,
        [LAST_DOB] datetime NULL,
        [GENDERA] varchar(1) NULL,
        [GENDERB] varchar(1) NULL,
        [HOUSE] varchar(10) NULL,
        [DAYONE] datetime NULL,
        [DO_FIRST_PERD] smallint NULL,
        [LASTDAY] datetime NULL,
        [LD_LAST_PERD] smallint NULL,
        [DAYONE_AM_PM] varchar(1) NULL,
        [LASTDAY_AM_PM] varchar(1) NULL,
        [ABS_TYPE] smallint NULL,
        [PREV_ABS_TYPE] smallint NULL,
        [FREQUENCY] varchar(1) NULL,
        [DESTINATION] varchar(40) NULL,
        [VENUE_ADDRESS] varchar(40) NULL,
        [EXC_GLCODE] varchar(10) NULL,
        [FEEDBACK] text NULL,
        [SPECIAL_NEEDS] text NULL,
        [EXC_PURPOSE] varchar(80) NULL,
        [EXC_SERVICE_PROVIDER] varchar(80) NULL,
        [TRANSPORT_METHOD] varchar(1) NULL,
        [EXC_TRANSPORT_PROVIDER] varchar(80) NULL,
        [FIXED_TRANS_COST] money NULL,
        [PER_ST_TRANS_COST] money NULL,
        [FIXED_VENUE_COST] money NULL,
        [PER_ST_VENUE_COST] money NULL,
        [OTHER_COSTS] text NULL,
        [EXC_AMOUNT] money NULL,
        [STAFF_MEMBERS] varchar(1) NULL,
        [PARENT_MEMBERS] varchar(1) NULL,
        [RESP_PERSON_TYPE] varchar(2) NULL,
        [ADULT_RESPONSIBLE] varchar(10) NULL,
        [RESP_PARENT_GENDER] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [SG_Index_SGKEY] PRIMARY KEY CLUSTERED (
            [SGKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [SG_Index_ABS_TYPE] ON [dbo].[SG]
    (
            [ABS_TYPE] ASC
    );
    CREATE NONCLUSTERED INDEX [SG_Index_CAND_FIRST_YR] ON [dbo].[SG]
    (
            [CAND_FIRST_YR] ASC
    );
    CREATE NONCLUSTERED INDEX [SG_Index_CAND_LAST_YR] ON [dbo].[SG]
    (
            [CAND_LAST_YR] ASC
    );
    CREATE NONCLUSTERED INDEX [SG_Index_FROM_CAMPUS] ON [dbo].[SG]
    (
            [FROM_CAMPUS] ASC
    );
    CREATE NONCLUSTERED INDEX [SG_Index_FUT_FIRST_YR] ON [dbo].[SG]
    (
            [FUT_FIRST_YR] ASC
    );
    CREATE NONCLUSTERED INDEX [SG_Index_FUT_LAST_YR] ON [dbo].[SG]
    (
            [FUT_LAST_YR] ASC
    );
    CREATE NONCLUSTERED INDEX [SG_Index_HOUSE] ON [dbo].[SG]
    (
            [HOUSE] ASC
    );
    CREATE NONCLUSTERED INDEX [SG_Index_TO_CAMPUS] ON [dbo].[SG]
    (
            [TO_CAMPUS] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SG data set</returns>
        public override IDataReader GetDataReader()
        {
            return new SGDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SGDataReader : IDataReader, IDataRecord
        {
            private List<SG> Items;
            private int CurrentIndex;
            private SG CurrentItem;

            public SGDataReader(List<SG> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 59; } }
            public bool IsClosed { get { return false; } }

            public object this[string name]
            {
                get
                {
                    return GetValue(GetOrdinal(name));
                }
            }

            public object this[int i]
            {
                get
                {
                    return GetValue(i);
                }
            }

            public bool Read()
            {
                CurrentIndex++;
                if (CurrentIndex < Items.Count)
                {
                    CurrentItem = Items[CurrentIndex];
                    return true;
                }
                else
                {
                    CurrentItem = null;
                    return false;
                }
            }

            public object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // SGKEY
                        return CurrentItem.SGKEY;
                    case 1: // TITLE
                        return CurrentItem.TITLE;
                    case 2: // GROUP_TYPE
                        return CurrentItem.GROUP_TYPE;
                    case 3: // GROUP_CATEGORY
                        return CurrentItem.GROUP_CATEGORY;
                    case 4: // SOURCE_SG
                        return CurrentItem.SOURCE_SG;
                    case 5: // STRICT_CRITERIA
                        return CurrentItem.STRICT_CRITERIA;
                    case 6: // MAX_NUMBER_STUD
                        return CurrentItem.MAX_NUMBER_STUD;
                    case 7: // STRUCTURE
                        return CurrentItem.STRUCTURE;
                    case 8: // START_DATE
                        return CurrentItem.START_DATE;
                    case 9: // END_DATE
                        return CurrentItem.END_DATE;
                    case 10: // CESSATION_DATE
                        return CurrentItem.CESSATION_DATE;
                    case 11: // HOUSE_HOMEGROUP
                        return CurrentItem.HOUSE_HOMEGROUP;
                    case 12: // SCOPE
                        return CurrentItem.SCOPE;
                    case 13: // FROM_CAMPUS
                        return CurrentItem.FROM_CAMPUS;
                    case 14: // TO_CAMPUS
                        return CurrentItem.TO_CAMPUS;
                    case 15: // CAND_FIRST_YR
                        return CurrentItem.CAND_FIRST_YR;
                    case 16: // CAND_LAST_YR
                        return CurrentItem.CAND_LAST_YR;
                    case 17: // FUT_FIRST_YR
                        return CurrentItem.FUT_FIRST_YR;
                    case 18: // FUT_LAST_YR
                        return CurrentItem.FUT_LAST_YR;
                    case 19: // CAND_FIRST_AGE
                        return CurrentItem.CAND_FIRST_AGE;
                    case 20: // CAND_LAST_AGE
                        return CurrentItem.CAND_LAST_AGE;
                    case 21: // AGE_DATE
                        return CurrentItem.AGE_DATE;
                    case 22: // FIRST_DOB
                        return CurrentItem.FIRST_DOB;
                    case 23: // LAST_DOB
                        return CurrentItem.LAST_DOB;
                    case 24: // GENDERA
                        return CurrentItem.GENDERA;
                    case 25: // GENDERB
                        return CurrentItem.GENDERB;
                    case 26: // HOUSE
                        return CurrentItem.HOUSE;
                    case 27: // DAYONE
                        return CurrentItem.DAYONE;
                    case 28: // DO_FIRST_PERD
                        return CurrentItem.DO_FIRST_PERD;
                    case 29: // LASTDAY
                        return CurrentItem.LASTDAY;
                    case 30: // LD_LAST_PERD
                        return CurrentItem.LD_LAST_PERD;
                    case 31: // DAYONE_AM_PM
                        return CurrentItem.DAYONE_AM_PM;
                    case 32: // LASTDAY_AM_PM
                        return CurrentItem.LASTDAY_AM_PM;
                    case 33: // ABS_TYPE
                        return CurrentItem.ABS_TYPE;
                    case 34: // PREV_ABS_TYPE
                        return CurrentItem.PREV_ABS_TYPE;
                    case 35: // FREQUENCY
                        return CurrentItem.FREQUENCY;
                    case 36: // DESTINATION
                        return CurrentItem.DESTINATION;
                    case 37: // VENUE_ADDRESS
                        return CurrentItem.VENUE_ADDRESS;
                    case 38: // EXC_GLCODE
                        return CurrentItem.EXC_GLCODE;
                    case 39: // FEEDBACK
                        return CurrentItem.FEEDBACK;
                    case 40: // SPECIAL_NEEDS
                        return CurrentItem.SPECIAL_NEEDS;
                    case 41: // EXC_PURPOSE
                        return CurrentItem.EXC_PURPOSE;
                    case 42: // EXC_SERVICE_PROVIDER
                        return CurrentItem.EXC_SERVICE_PROVIDER;
                    case 43: // TRANSPORT_METHOD
                        return CurrentItem.TRANSPORT_METHOD;
                    case 44: // EXC_TRANSPORT_PROVIDER
                        return CurrentItem.EXC_TRANSPORT_PROVIDER;
                    case 45: // FIXED_TRANS_COST
                        return CurrentItem.FIXED_TRANS_COST;
                    case 46: // PER_ST_TRANS_COST
                        return CurrentItem.PER_ST_TRANS_COST;
                    case 47: // FIXED_VENUE_COST
                        return CurrentItem.FIXED_VENUE_COST;
                    case 48: // PER_ST_VENUE_COST
                        return CurrentItem.PER_ST_VENUE_COST;
                    case 49: // OTHER_COSTS
                        return CurrentItem.OTHER_COSTS;
                    case 50: // EXC_AMOUNT
                        return CurrentItem.EXC_AMOUNT;
                    case 51: // STAFF_MEMBERS
                        return CurrentItem.STAFF_MEMBERS;
                    case 52: // PARENT_MEMBERS
                        return CurrentItem.PARENT_MEMBERS;
                    case 53: // RESP_PERSON_TYPE
                        return CurrentItem.RESP_PERSON_TYPE;
                    case 54: // ADULT_RESPONSIBLE
                        return CurrentItem.ADULT_RESPONSIBLE;
                    case 55: // RESP_PARENT_GENDER
                        return CurrentItem.RESP_PARENT_GENDER;
                    case 56: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 57: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 58: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return CurrentItem.TITLE == null;
                    case 2: // GROUP_TYPE
                        return CurrentItem.GROUP_TYPE == null;
                    case 3: // GROUP_CATEGORY
                        return CurrentItem.GROUP_CATEGORY == null;
                    case 4: // SOURCE_SG
                        return CurrentItem.SOURCE_SG == null;
                    case 5: // STRICT_CRITERIA
                        return CurrentItem.STRICT_CRITERIA == null;
                    case 6: // MAX_NUMBER_STUD
                        return CurrentItem.MAX_NUMBER_STUD == null;
                    case 7: // STRUCTURE
                        return CurrentItem.STRUCTURE == null;
                    case 8: // START_DATE
                        return CurrentItem.START_DATE == null;
                    case 9: // END_DATE
                        return CurrentItem.END_DATE == null;
                    case 10: // CESSATION_DATE
                        return CurrentItem.CESSATION_DATE == null;
                    case 11: // HOUSE_HOMEGROUP
                        return CurrentItem.HOUSE_HOMEGROUP == null;
                    case 12: // SCOPE
                        return CurrentItem.SCOPE == null;
                    case 13: // FROM_CAMPUS
                        return CurrentItem.FROM_CAMPUS == null;
                    case 14: // TO_CAMPUS
                        return CurrentItem.TO_CAMPUS == null;
                    case 15: // CAND_FIRST_YR
                        return CurrentItem.CAND_FIRST_YR == null;
                    case 16: // CAND_LAST_YR
                        return CurrentItem.CAND_LAST_YR == null;
                    case 17: // FUT_FIRST_YR
                        return CurrentItem.FUT_FIRST_YR == null;
                    case 18: // FUT_LAST_YR
                        return CurrentItem.FUT_LAST_YR == null;
                    case 19: // CAND_FIRST_AGE
                        return CurrentItem.CAND_FIRST_AGE == null;
                    case 20: // CAND_LAST_AGE
                        return CurrentItem.CAND_LAST_AGE == null;
                    case 21: // AGE_DATE
                        return CurrentItem.AGE_DATE == null;
                    case 22: // FIRST_DOB
                        return CurrentItem.FIRST_DOB == null;
                    case 23: // LAST_DOB
                        return CurrentItem.LAST_DOB == null;
                    case 24: // GENDERA
                        return CurrentItem.GENDERA == null;
                    case 25: // GENDERB
                        return CurrentItem.GENDERB == null;
                    case 26: // HOUSE
                        return CurrentItem.HOUSE == null;
                    case 27: // DAYONE
                        return CurrentItem.DAYONE == null;
                    case 28: // DO_FIRST_PERD
                        return CurrentItem.DO_FIRST_PERD == null;
                    case 29: // LASTDAY
                        return CurrentItem.LASTDAY == null;
                    case 30: // LD_LAST_PERD
                        return CurrentItem.LD_LAST_PERD == null;
                    case 31: // DAYONE_AM_PM
                        return CurrentItem.DAYONE_AM_PM == null;
                    case 32: // LASTDAY_AM_PM
                        return CurrentItem.LASTDAY_AM_PM == null;
                    case 33: // ABS_TYPE
                        return CurrentItem.ABS_TYPE == null;
                    case 34: // PREV_ABS_TYPE
                        return CurrentItem.PREV_ABS_TYPE == null;
                    case 35: // FREQUENCY
                        return CurrentItem.FREQUENCY == null;
                    case 36: // DESTINATION
                        return CurrentItem.DESTINATION == null;
                    case 37: // VENUE_ADDRESS
                        return CurrentItem.VENUE_ADDRESS == null;
                    case 38: // EXC_GLCODE
                        return CurrentItem.EXC_GLCODE == null;
                    case 39: // FEEDBACK
                        return CurrentItem.FEEDBACK == null;
                    case 40: // SPECIAL_NEEDS
                        return CurrentItem.SPECIAL_NEEDS == null;
                    case 41: // EXC_PURPOSE
                        return CurrentItem.EXC_PURPOSE == null;
                    case 42: // EXC_SERVICE_PROVIDER
                        return CurrentItem.EXC_SERVICE_PROVIDER == null;
                    case 43: // TRANSPORT_METHOD
                        return CurrentItem.TRANSPORT_METHOD == null;
                    case 44: // EXC_TRANSPORT_PROVIDER
                        return CurrentItem.EXC_TRANSPORT_PROVIDER == null;
                    case 45: // FIXED_TRANS_COST
                        return CurrentItem.FIXED_TRANS_COST == null;
                    case 46: // PER_ST_TRANS_COST
                        return CurrentItem.PER_ST_TRANS_COST == null;
                    case 47: // FIXED_VENUE_COST
                        return CurrentItem.FIXED_VENUE_COST == null;
                    case 48: // PER_ST_VENUE_COST
                        return CurrentItem.PER_ST_VENUE_COST == null;
                    case 49: // OTHER_COSTS
                        return CurrentItem.OTHER_COSTS == null;
                    case 50: // EXC_AMOUNT
                        return CurrentItem.EXC_AMOUNT == null;
                    case 51: // STAFF_MEMBERS
                        return CurrentItem.STAFF_MEMBERS == null;
                    case 52: // PARENT_MEMBERS
                        return CurrentItem.PARENT_MEMBERS == null;
                    case 53: // RESP_PERSON_TYPE
                        return CurrentItem.RESP_PERSON_TYPE == null;
                    case 54: // ADULT_RESPONSIBLE
                        return CurrentItem.ADULT_RESPONSIBLE == null;
                    case 55: // RESP_PARENT_GENDER
                        return CurrentItem.RESP_PARENT_GENDER == null;
                    case 56: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 57: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 58: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // SGKEY
                        return "SGKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // GROUP_TYPE
                        return "GROUP_TYPE";
                    case 3: // GROUP_CATEGORY
                        return "GROUP_CATEGORY";
                    case 4: // SOURCE_SG
                        return "SOURCE_SG";
                    case 5: // STRICT_CRITERIA
                        return "STRICT_CRITERIA";
                    case 6: // MAX_NUMBER_STUD
                        return "MAX_NUMBER_STUD";
                    case 7: // STRUCTURE
                        return "STRUCTURE";
                    case 8: // START_DATE
                        return "START_DATE";
                    case 9: // END_DATE
                        return "END_DATE";
                    case 10: // CESSATION_DATE
                        return "CESSATION_DATE";
                    case 11: // HOUSE_HOMEGROUP
                        return "HOUSE_HOMEGROUP";
                    case 12: // SCOPE
                        return "SCOPE";
                    case 13: // FROM_CAMPUS
                        return "FROM_CAMPUS";
                    case 14: // TO_CAMPUS
                        return "TO_CAMPUS";
                    case 15: // CAND_FIRST_YR
                        return "CAND_FIRST_YR";
                    case 16: // CAND_LAST_YR
                        return "CAND_LAST_YR";
                    case 17: // FUT_FIRST_YR
                        return "FUT_FIRST_YR";
                    case 18: // FUT_LAST_YR
                        return "FUT_LAST_YR";
                    case 19: // CAND_FIRST_AGE
                        return "CAND_FIRST_AGE";
                    case 20: // CAND_LAST_AGE
                        return "CAND_LAST_AGE";
                    case 21: // AGE_DATE
                        return "AGE_DATE";
                    case 22: // FIRST_DOB
                        return "FIRST_DOB";
                    case 23: // LAST_DOB
                        return "LAST_DOB";
                    case 24: // GENDERA
                        return "GENDERA";
                    case 25: // GENDERB
                        return "GENDERB";
                    case 26: // HOUSE
                        return "HOUSE";
                    case 27: // DAYONE
                        return "DAYONE";
                    case 28: // DO_FIRST_PERD
                        return "DO_FIRST_PERD";
                    case 29: // LASTDAY
                        return "LASTDAY";
                    case 30: // LD_LAST_PERD
                        return "LD_LAST_PERD";
                    case 31: // DAYONE_AM_PM
                        return "DAYONE_AM_PM";
                    case 32: // LASTDAY_AM_PM
                        return "LASTDAY_AM_PM";
                    case 33: // ABS_TYPE
                        return "ABS_TYPE";
                    case 34: // PREV_ABS_TYPE
                        return "PREV_ABS_TYPE";
                    case 35: // FREQUENCY
                        return "FREQUENCY";
                    case 36: // DESTINATION
                        return "DESTINATION";
                    case 37: // VENUE_ADDRESS
                        return "VENUE_ADDRESS";
                    case 38: // EXC_GLCODE
                        return "EXC_GLCODE";
                    case 39: // FEEDBACK
                        return "FEEDBACK";
                    case 40: // SPECIAL_NEEDS
                        return "SPECIAL_NEEDS";
                    case 41: // EXC_PURPOSE
                        return "EXC_PURPOSE";
                    case 42: // EXC_SERVICE_PROVIDER
                        return "EXC_SERVICE_PROVIDER";
                    case 43: // TRANSPORT_METHOD
                        return "TRANSPORT_METHOD";
                    case 44: // EXC_TRANSPORT_PROVIDER
                        return "EXC_TRANSPORT_PROVIDER";
                    case 45: // FIXED_TRANS_COST
                        return "FIXED_TRANS_COST";
                    case 46: // PER_ST_TRANS_COST
                        return "PER_ST_TRANS_COST";
                    case 47: // FIXED_VENUE_COST
                        return "FIXED_VENUE_COST";
                    case 48: // PER_ST_VENUE_COST
                        return "PER_ST_VENUE_COST";
                    case 49: // OTHER_COSTS
                        return "OTHER_COSTS";
                    case 50: // EXC_AMOUNT
                        return "EXC_AMOUNT";
                    case 51: // STAFF_MEMBERS
                        return "STAFF_MEMBERS";
                    case 52: // PARENT_MEMBERS
                        return "PARENT_MEMBERS";
                    case 53: // RESP_PERSON_TYPE
                        return "RESP_PERSON_TYPE";
                    case 54: // ADULT_RESPONSIBLE
                        return "ADULT_RESPONSIBLE";
                    case 55: // RESP_PARENT_GENDER
                        return "RESP_PARENT_GENDER";
                    case 56: // LW_DATE
                        return "LW_DATE";
                    case 57: // LW_TIME
                        return "LW_TIME";
                    case 58: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "SGKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "GROUP_TYPE":
                        return 2;
                    case "GROUP_CATEGORY":
                        return 3;
                    case "SOURCE_SG":
                        return 4;
                    case "STRICT_CRITERIA":
                        return 5;
                    case "MAX_NUMBER_STUD":
                        return 6;
                    case "STRUCTURE":
                        return 7;
                    case "START_DATE":
                        return 8;
                    case "END_DATE":
                        return 9;
                    case "CESSATION_DATE":
                        return 10;
                    case "HOUSE_HOMEGROUP":
                        return 11;
                    case "SCOPE":
                        return 12;
                    case "FROM_CAMPUS":
                        return 13;
                    case "TO_CAMPUS":
                        return 14;
                    case "CAND_FIRST_YR":
                        return 15;
                    case "CAND_LAST_YR":
                        return 16;
                    case "FUT_FIRST_YR":
                        return 17;
                    case "FUT_LAST_YR":
                        return 18;
                    case "CAND_FIRST_AGE":
                        return 19;
                    case "CAND_LAST_AGE":
                        return 20;
                    case "AGE_DATE":
                        return 21;
                    case "FIRST_DOB":
                        return 22;
                    case "LAST_DOB":
                        return 23;
                    case "GENDERA":
                        return 24;
                    case "GENDERB":
                        return 25;
                    case "HOUSE":
                        return 26;
                    case "DAYONE":
                        return 27;
                    case "DO_FIRST_PERD":
                        return 28;
                    case "LASTDAY":
                        return 29;
                    case "LD_LAST_PERD":
                        return 30;
                    case "DAYONE_AM_PM":
                        return 31;
                    case "LASTDAY_AM_PM":
                        return 32;
                    case "ABS_TYPE":
                        return 33;
                    case "PREV_ABS_TYPE":
                        return 34;
                    case "FREQUENCY":
                        return 35;
                    case "DESTINATION":
                        return 36;
                    case "VENUE_ADDRESS":
                        return 37;
                    case "EXC_GLCODE":
                        return 38;
                    case "FEEDBACK":
                        return 39;
                    case "SPECIAL_NEEDS":
                        return 40;
                    case "EXC_PURPOSE":
                        return 41;
                    case "EXC_SERVICE_PROVIDER":
                        return 42;
                    case "TRANSPORT_METHOD":
                        return 43;
                    case "EXC_TRANSPORT_PROVIDER":
                        return 44;
                    case "FIXED_TRANS_COST":
                        return 45;
                    case "PER_ST_TRANS_COST":
                        return 46;
                    case "FIXED_VENUE_COST":
                        return 47;
                    case "PER_ST_VENUE_COST":
                        return 48;
                    case "OTHER_COSTS":
                        return 49;
                    case "EXC_AMOUNT":
                        return 50;
                    case "STAFF_MEMBERS":
                        return 51;
                    case "PARENT_MEMBERS":
                        return 52;
                    case "RESP_PERSON_TYPE":
                        return 53;
                    case "ADULT_RESPONSIBLE":
                        return 54;
                    case "RESP_PARENT_GENDER":
                        return 55;
                    case "LW_DATE":
                        return 56;
                    case "LW_TIME":
                        return 57;
                    case "LW_USER":
                        return 58;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }

            public int Depth { get { throw new NotImplementedException(); } }
            public int RecordsAffected { get { throw new NotImplementedException(); } }
            public void Close() { throw new NotImplementedException(); }
            public bool GetBoolean(int ordinal) { throw new NotImplementedException(); }
            public byte GetByte(int ordinal) { throw new NotImplementedException(); }
            public long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public char GetChar(int ordinal) { throw new NotImplementedException(); }
            public long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length) { throw new NotImplementedException(); }
            public IDataReader GetData(int i) { throw new NotImplementedException(); }
            public string GetDataTypeName(int ordinal) { throw new NotImplementedException(); }
            public DateTime GetDateTime(int ordinal) { throw new NotImplementedException(); }
            public decimal GetDecimal(int ordinal) { throw new NotImplementedException(); }
            public double GetDouble(int ordinal) { throw new NotImplementedException(); }
            public Type GetFieldType(int ordinal) { throw new NotImplementedException(); }
            public float GetFloat(int ordinal) { throw new NotImplementedException(); }
            public Guid GetGuid(int ordinal) { throw new NotImplementedException(); }
            public short GetInt16(int ordinal) { throw new NotImplementedException(); }
            public int GetInt32(int ordinal) { throw new NotImplementedException(); }
            public long GetInt64(int ordinal) { throw new NotImplementedException(); }
            public string GetString(int ordinal) { throw new NotImplementedException(); }
            public int GetValues(object[] values) { throw new NotImplementedException(); }
            public bool NextResult() { throw new NotImplementedException(); }
            public DataTable GetSchemaTable() { throw new NotImplementedException(); }

            public void Dispose()
            {
                return;
            }
        }

        #endregion

    }
}
