﻿using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Student Transport Routes Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class TRPROUTDataSet : DataSetBase<TRPROUT>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "TRPROUT"; } }

        internal TRPROUTDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ROUTE_ID = new Lazy<Dictionary<int, TRPROUT>>(() => this.ToDictionary(i => i.ROUTE_ID));
            Index_TRANSPORT_COMPANY_ID = new Lazy<NullDictionary<int?, IReadOnlyList<TRPROUT>>>(() => this.ToGroupedNullDictionary(i => i.TRANSPORT_COMPANY_ID));
            Index_TRANSPORT_MODE_ID = new Lazy<NullDictionary<int?, IReadOnlyList<TRPROUT>>>(() => this.ToGroupedNullDictionary(i => i.TRANSPORT_MODE_ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="TRPROUT" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="TRPROUT" /> fields for each CSV column header</returns>
        protected override Action<TRPROUT, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<TRPROUT, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ROUTE_ID":
                        mapper[i] = (e, v) => e.ROUTE_ID = int.Parse(v);
                        break;
                    case "ROUTE_NAME":
                        mapper[i] = (e, v) => e.ROUTE_NAME = v;
                        break;
                    case "TRANSPORT_MODE_ID":
                        mapper[i] = (e, v) => e.TRANSPORT_MODE_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "TRANSPORT_COMPANY_ID":
                        mapper[i] = (e, v) => e.TRANSPORT_COMPANY_ID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "ROUTE_CONTRACT_NO":
                        mapper[i] = (e, v) => e.ROUTE_CONTRACT_NO = v;
                        break;
                    case "CONTACT1_FIRST_NAME":
                        mapper[i] = (e, v) => e.CONTACT1_FIRST_NAME = v;
                        break;
                    case "CONTACT1_LAST_NAME":
                        mapper[i] = (e, v) => e.CONTACT1_LAST_NAME = v;
                        break;
                    case "CONTACT1_PHONE":
                        mapper[i] = (e, v) => e.CONTACT1_PHONE = v;
                        break;
                    case "CONTACT2_FIRST_NAME":
                        mapper[i] = (e, v) => e.CONTACT2_FIRST_NAME = v;
                        break;
                    case "CONTACT2_LAST_NAME":
                        mapper[i] = (e, v) => e.CONTACT2_LAST_NAME = v;
                        break;
                    case "CONTACT2_PHONE":
                        mapper[i] = (e, v) => e.CONTACT2_PHONE = v;
                        break;
                    case "AM_SETDOWN_TIME":
                        mapper[i] = (e, v) => e.AM_SETDOWN_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PM_PICKUP_TIME":
                        mapper[i] = (e, v) => e.PM_PICKUP_TIME = v == null ? (short?)null : short.Parse(v);
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
        /// Merges <see cref="TRPROUT" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="TRPROUT" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="TRPROUT" /> items to added or update the base <see cref="TRPROUT" /> items</param>
        /// <returns>A merged list of <see cref="TRPROUT" /> items</returns>
        protected override List<TRPROUT> ApplyDeltaItems(List<TRPROUT> Items, List<TRPROUT> DeltaItems)
        {
            Dictionary<int, int> Index_ROUTE_ID = Items.ToIndexDictionary(i => i.ROUTE_ID);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (TRPROUT deltaItem in DeltaItems)
            {
                int index;

                if (Index_ROUTE_ID.TryGetValue(deltaItem.ROUTE_ID, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.ROUTE_ID)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<int, TRPROUT>> Index_ROUTE_ID;
        private Lazy<NullDictionary<int?, IReadOnlyList<TRPROUT>>> Index_TRANSPORT_COMPANY_ID;
        private Lazy<NullDictionary<int?, IReadOnlyList<TRPROUT>>> Index_TRANSPORT_MODE_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find TRPROUT by ROUTE_ID field
        /// </summary>
        /// <param name="ROUTE_ID">ROUTE_ID value used to find TRPROUT</param>
        /// <returns>Related TRPROUT entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TRPROUT FindByROUTE_ID(int ROUTE_ID)
        {
            return Index_ROUTE_ID.Value[ROUTE_ID];
        }

        /// <summary>
        /// Attempt to find TRPROUT by ROUTE_ID field
        /// </summary>
        /// <param name="ROUTE_ID">ROUTE_ID value used to find TRPROUT</param>
        /// <param name="Value">Related TRPROUT entity</param>
        /// <returns>True if the related TRPROUT entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByROUTE_ID(int ROUTE_ID, out TRPROUT Value)
        {
            return Index_ROUTE_ID.Value.TryGetValue(ROUTE_ID, out Value);
        }

        /// <summary>
        /// Attempt to find TRPROUT by ROUTE_ID field
        /// </summary>
        /// <param name="ROUTE_ID">ROUTE_ID value used to find TRPROUT</param>
        /// <returns>Related TRPROUT entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public TRPROUT TryFindByROUTE_ID(int ROUTE_ID)
        {
            TRPROUT value;
            if (Index_ROUTE_ID.Value.TryGetValue(ROUTE_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TRPROUT by TRANSPORT_COMPANY_ID field
        /// </summary>
        /// <param name="TRANSPORT_COMPANY_ID">TRANSPORT_COMPANY_ID value used to find TRPROUT</param>
        /// <returns>List of related TRPROUT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TRPROUT> FindByTRANSPORT_COMPANY_ID(int? TRANSPORT_COMPANY_ID)
        {
            return Index_TRANSPORT_COMPANY_ID.Value[TRANSPORT_COMPANY_ID];
        }

        /// <summary>
        /// Attempt to find TRPROUT by TRANSPORT_COMPANY_ID field
        /// </summary>
        /// <param name="TRANSPORT_COMPANY_ID">TRANSPORT_COMPANY_ID value used to find TRPROUT</param>
        /// <param name="Value">List of related TRPROUT entities</param>
        /// <returns>True if the list of related TRPROUT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRANSPORT_COMPANY_ID(int? TRANSPORT_COMPANY_ID, out IReadOnlyList<TRPROUT> Value)
        {
            return Index_TRANSPORT_COMPANY_ID.Value.TryGetValue(TRANSPORT_COMPANY_ID, out Value);
        }

        /// <summary>
        /// Attempt to find TRPROUT by TRANSPORT_COMPANY_ID field
        /// </summary>
        /// <param name="TRANSPORT_COMPANY_ID">TRANSPORT_COMPANY_ID value used to find TRPROUT</param>
        /// <returns>List of related TRPROUT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TRPROUT> TryFindByTRANSPORT_COMPANY_ID(int? TRANSPORT_COMPANY_ID)
        {
            IReadOnlyList<TRPROUT> value;
            if (Index_TRANSPORT_COMPANY_ID.Value.TryGetValue(TRANSPORT_COMPANY_ID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find TRPROUT by TRANSPORT_MODE_ID field
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find TRPROUT</param>
        /// <returns>List of related TRPROUT entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TRPROUT> FindByTRANSPORT_MODE_ID(int? TRANSPORT_MODE_ID)
        {
            return Index_TRANSPORT_MODE_ID.Value[TRANSPORT_MODE_ID];
        }

        /// <summary>
        /// Attempt to find TRPROUT by TRANSPORT_MODE_ID field
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find TRPROUT</param>
        /// <param name="Value">List of related TRPROUT entities</param>
        /// <returns>True if the list of related TRPROUT entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByTRANSPORT_MODE_ID(int? TRANSPORT_MODE_ID, out IReadOnlyList<TRPROUT> Value)
        {
            return Index_TRANSPORT_MODE_ID.Value.TryGetValue(TRANSPORT_MODE_ID, out Value);
        }

        /// <summary>
        /// Attempt to find TRPROUT by TRANSPORT_MODE_ID field
        /// </summary>
        /// <param name="TRANSPORT_MODE_ID">TRANSPORT_MODE_ID value used to find TRPROUT</param>
        /// <returns>List of related TRPROUT entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<TRPROUT> TryFindByTRANSPORT_MODE_ID(int? TRANSPORT_MODE_ID)
        {
            IReadOnlyList<TRPROUT> value;
            if (Index_TRANSPORT_MODE_ID.Value.TryGetValue(TRANSPORT_MODE_ID, out value))
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
        /// Returns SQL which checks for the existence of a TRPROUT table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[TRPROUT]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[TRPROUT](
        [ROUTE_ID] int IDENTITY NOT NULL,
        [ROUTE_NAME] varchar(40) NULL,
        [TRANSPORT_MODE_ID] int NULL,
        [TRANSPORT_COMPANY_ID] int NULL,
        [ROUTE_CONTRACT_NO] varchar(20) NULL,
        [CONTACT1_FIRST_NAME] varchar(20) NULL,
        [CONTACT1_LAST_NAME] varchar(20) NULL,
        [CONTACT1_PHONE] varchar(20) NULL,
        [CONTACT2_FIRST_NAME] varchar(20) NULL,
        [CONTACT2_LAST_NAME] varchar(20) NULL,
        [CONTACT2_PHONE] varchar(20) NULL,
        [AM_SETDOWN_TIME] smallint NULL,
        [PM_PICKUP_TIME] smallint NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [TRPROUT_Index_ROUTE_ID] PRIMARY KEY CLUSTERED (
            [ROUTE_ID] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [TRPROUT_Index_TRANSPORT_COMPANY_ID] ON [dbo].[TRPROUT]
    (
            [TRANSPORT_COMPANY_ID] ASC
    );
    CREATE NONCLUSTERED INDEX [TRPROUT_Index_TRANSPORT_MODE_ID] ON [dbo].[TRPROUT]
    (
            [TRANSPORT_MODE_ID] ASC
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the TRPROUT data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the TRPROUT data set</returns>
        public override IDataReader GetDataReader()
        {
            return new TRPROUTDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class TRPROUTDataReader : IDataReader, IDataRecord
        {
            private List<TRPROUT> Items;
            private int CurrentIndex;
            private TRPROUT CurrentItem;

            public TRPROUTDataReader(List<TRPROUT> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 16; } }
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
                    case 0: // ROUTE_ID
                        return CurrentItem.ROUTE_ID;
                    case 1: // ROUTE_NAME
                        return CurrentItem.ROUTE_NAME;
                    case 2: // TRANSPORT_MODE_ID
                        return CurrentItem.TRANSPORT_MODE_ID;
                    case 3: // TRANSPORT_COMPANY_ID
                        return CurrentItem.TRANSPORT_COMPANY_ID;
                    case 4: // ROUTE_CONTRACT_NO
                        return CurrentItem.ROUTE_CONTRACT_NO;
                    case 5: // CONTACT1_FIRST_NAME
                        return CurrentItem.CONTACT1_FIRST_NAME;
                    case 6: // CONTACT1_LAST_NAME
                        return CurrentItem.CONTACT1_LAST_NAME;
                    case 7: // CONTACT1_PHONE
                        return CurrentItem.CONTACT1_PHONE;
                    case 8: // CONTACT2_FIRST_NAME
                        return CurrentItem.CONTACT2_FIRST_NAME;
                    case 9: // CONTACT2_LAST_NAME
                        return CurrentItem.CONTACT2_LAST_NAME;
                    case 10: // CONTACT2_PHONE
                        return CurrentItem.CONTACT2_PHONE;
                    case 11: // AM_SETDOWN_TIME
                        return CurrentItem.AM_SETDOWN_TIME;
                    case 12: // PM_PICKUP_TIME
                        return CurrentItem.PM_PICKUP_TIME;
                    case 13: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 14: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 15: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ROUTE_NAME
                        return CurrentItem.ROUTE_NAME == null;
                    case 2: // TRANSPORT_MODE_ID
                        return CurrentItem.TRANSPORT_MODE_ID == null;
                    case 3: // TRANSPORT_COMPANY_ID
                        return CurrentItem.TRANSPORT_COMPANY_ID == null;
                    case 4: // ROUTE_CONTRACT_NO
                        return CurrentItem.ROUTE_CONTRACT_NO == null;
                    case 5: // CONTACT1_FIRST_NAME
                        return CurrentItem.CONTACT1_FIRST_NAME == null;
                    case 6: // CONTACT1_LAST_NAME
                        return CurrentItem.CONTACT1_LAST_NAME == null;
                    case 7: // CONTACT1_PHONE
                        return CurrentItem.CONTACT1_PHONE == null;
                    case 8: // CONTACT2_FIRST_NAME
                        return CurrentItem.CONTACT2_FIRST_NAME == null;
                    case 9: // CONTACT2_LAST_NAME
                        return CurrentItem.CONTACT2_LAST_NAME == null;
                    case 10: // CONTACT2_PHONE
                        return CurrentItem.CONTACT2_PHONE == null;
                    case 11: // AM_SETDOWN_TIME
                        return CurrentItem.AM_SETDOWN_TIME == null;
                    case 12: // PM_PICKUP_TIME
                        return CurrentItem.PM_PICKUP_TIME == null;
                    case 13: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 14: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 15: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ROUTE_ID
                        return "ROUTE_ID";
                    case 1: // ROUTE_NAME
                        return "ROUTE_NAME";
                    case 2: // TRANSPORT_MODE_ID
                        return "TRANSPORT_MODE_ID";
                    case 3: // TRANSPORT_COMPANY_ID
                        return "TRANSPORT_COMPANY_ID";
                    case 4: // ROUTE_CONTRACT_NO
                        return "ROUTE_CONTRACT_NO";
                    case 5: // CONTACT1_FIRST_NAME
                        return "CONTACT1_FIRST_NAME";
                    case 6: // CONTACT1_LAST_NAME
                        return "CONTACT1_LAST_NAME";
                    case 7: // CONTACT1_PHONE
                        return "CONTACT1_PHONE";
                    case 8: // CONTACT2_FIRST_NAME
                        return "CONTACT2_FIRST_NAME";
                    case 9: // CONTACT2_LAST_NAME
                        return "CONTACT2_LAST_NAME";
                    case 10: // CONTACT2_PHONE
                        return "CONTACT2_PHONE";
                    case 11: // AM_SETDOWN_TIME
                        return "AM_SETDOWN_TIME";
                    case 12: // PM_PICKUP_TIME
                        return "PM_PICKUP_TIME";
                    case 13: // LW_DATE
                        return "LW_DATE";
                    case 14: // LW_TIME
                        return "LW_TIME";
                    case 15: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ROUTE_ID":
                        return 0;
                    case "ROUTE_NAME":
                        return 1;
                    case "TRANSPORT_MODE_ID":
                        return 2;
                    case "TRANSPORT_COMPANY_ID":
                        return 3;
                    case "ROUTE_CONTRACT_NO":
                        return 4;
                    case "CONTACT1_FIRST_NAME":
                        return 5;
                    case "CONTACT1_LAST_NAME":
                        return 6;
                    case "CONTACT1_PHONE":
                        return 7;
                    case "CONTACT2_FIRST_NAME":
                        return 8;
                    case "CONTACT2_LAST_NAME":
                        return 9;
                    case "CONTACT2_PHONE":
                        return 10;
                    case "AM_SETDOWN_TIME":
                        return 11;
                    case "PM_PICKUP_TIME":
                        return 12;
                    case "LW_DATE":
                        return 13;
                    case "LW_TIME":
                        return 14;
                    case "LW_USER":
                        return 15;
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
