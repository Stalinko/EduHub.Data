﻿using System;
using System.Data;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Transport Routes/Stops Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCRDataSet : EduHubDataSet<KCR>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "KCR"; } }

        internal KCRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KCRKEY = new Lazy<Dictionary<string, KCR>>(() => this.ToDictionary(i => i.KCRKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCR" /> fields for each CSV column header</returns>
        protected override Action<KCR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KCRKEY":
                        mapper[i] = (e, v) => e.KCRKEY = v;
                        break;
                    case "TRANSPORT_TYPE":
                        mapper[i] = (e, v) => e.TRANSPORT_TYPE = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "ROUTE_CODE":
                        mapper[i] = (e, v) => e.ROUTE_CODE = v;
                        break;
                    case "STOP_DESCRIP":
                        mapper[i] = (e, v) => e.STOP_DESCRIP = v;
                        break;
                    case "DAYOFWK01":
                        mapper[i] = (e, v) => e.DAYOFWK01 = v;
                        break;
                    case "DAYOFWK02":
                        mapper[i] = (e, v) => e.DAYOFWK02 = v;
                        break;
                    case "DAYOFWK03":
                        mapper[i] = (e, v) => e.DAYOFWK03 = v;
                        break;
                    case "DAYOFWK04":
                        mapper[i] = (e, v) => e.DAYOFWK04 = v;
                        break;
                    case "DAYOFWK05":
                        mapper[i] = (e, v) => e.DAYOFWK05 = v;
                        break;
                    case "DEPART_AM":
                        mapper[i] = (e, v) => e.DEPART_AM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DEPART_PM":
                        mapper[i] = (e, v) => e.DEPART_PM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ARRIVE_AM":
                        mapper[i] = (e, v) => e.ARRIVE_AM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ARRIVE_PM":
                        mapper[i] = (e, v) => e.ARRIVE_PM = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "MAP_TYPE":
                        mapper[i] = (e, v) => e.MAP_TYPE = v;
                        break;
                    case "MAP_NUM":
                        mapper[i] = (e, v) => e.MAP_NUM = v;
                        break;
                    case "X_AXIS":
                        mapper[i] = (e, v) => e.X_AXIS = v;
                        break;
                    case "Y_AXIS":
                        mapper[i] = (e, v) => e.Y_AXIS = v;
                        break;
                    case "NO_OF_STUD":
                        mapper[i] = (e, v) => e.NO_OF_STUD = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PROG_NO":
                        mapper[i] = (e, v) => e.PROG_NO = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DIST_LAST":
                        mapper[i] = (e, v) => e.DIST_LAST = v == null ? (double?)null : double.Parse(v);
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
        /// Merges <see cref="KCR" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="KCR" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="KCR" /> items to added or update the base <see cref="KCR" /> items</param>
        /// <returns>A merged list of <see cref="KCR" /> items</returns>
        protected override List<KCR> ApplyDeltaItems(List<KCR> Items, List<KCR> DeltaItems)
        {
            Dictionary<string, int> Index_KCRKEY = Items.ToIndexDictionary(i => i.KCRKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (KCR deltaItem in DeltaItems)
            {
                int index;

                if (Index_KCRKEY.TryGetValue(deltaItem.KCRKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.KCRKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<Dictionary<string, KCR>> Index_KCRKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCR by KCRKEY field
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find KCR</param>
        /// <returns>Related KCR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCR FindByKCRKEY(string KCRKEY)
        {
            return Index_KCRKEY.Value[KCRKEY];
        }

        /// <summary>
        /// Attempt to find KCR by KCRKEY field
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find KCR</param>
        /// <param name="Value">Related KCR entity</param>
        /// <returns>True if the related KCR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKCRKEY(string KCRKEY, out KCR Value)
        {
            return Index_KCRKEY.Value.TryGetValue(KCRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KCR by KCRKEY field
        /// </summary>
        /// <param name="KCRKEY">KCRKEY value used to find KCR</param>
        /// <returns>Related KCR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCR TryFindByKCRKEY(string KCRKEY)
        {
            KCR value;
            if (Index_KCRKEY.Value.TryGetValue(KCRKEY, out value))
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
        /// Returns SQL which checks for the existence of a KCR table, and if not found, creates the table and associated indexes.
        /// </summary>
        protected override string GetCreateTableSql()
        {
            return @"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCR](
        [KCRKEY] varchar(6) NOT NULL,
        [TRANSPORT_TYPE] varchar(1) NULL,
        [DESCRIPTION] varchar(40) NULL,
        [ROUTE_CODE] varchar(5) NULL,
        [STOP_DESCRIP] text NULL,
        [DAYOFWK01] varchar(1) NULL,
        [DAYOFWK02] varchar(1) NULL,
        [DAYOFWK03] varchar(1) NULL,
        [DAYOFWK04] varchar(1) NULL,
        [DAYOFWK05] varchar(1) NULL,
        [DEPART_AM] smallint NULL,
        [DEPART_PM] smallint NULL,
        [ARRIVE_AM] smallint NULL,
        [ARRIVE_PM] smallint NULL,
        [MAP_TYPE] varchar(1) NULL,
        [MAP_NUM] varchar(4) NULL,
        [X_AXIS] varchar(2) NULL,
        [Y_AXIS] varchar(2) NULL,
        [NO_OF_STUD] smallint NULL,
        [PROG_NO] smallint NULL,
        [DIST_LAST] float NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCR_Index_KCRKEY] PRIMARY KEY CLUSTERED (
            [KCRKEY] ASC
        )
    );
END";
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCR data set</returns>
        public override IDataReader GetDataReader()
        {
            return new KCRDataReader(Items.Value);
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCRDataReader : IDataReader, IDataRecord
        {
            private List<KCR> Items;
            private int CurrentIndex;
            private KCR CurrentItem;

            public KCRDataReader(List<KCR> Items)
            {
                this.Items = Items;

                CurrentIndex = -1;
                CurrentItem = null;
            }

            public int FieldCount { get { return 24; } }
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
                    case 0: // KCRKEY
                        return CurrentItem.KCRKEY;
                    case 1: // TRANSPORT_TYPE
                        return CurrentItem.TRANSPORT_TYPE;
                    case 2: // DESCRIPTION
                        return CurrentItem.DESCRIPTION;
                    case 3: // ROUTE_CODE
                        return CurrentItem.ROUTE_CODE;
                    case 4: // STOP_DESCRIP
                        return CurrentItem.STOP_DESCRIP;
                    case 5: // DAYOFWK01
                        return CurrentItem.DAYOFWK01;
                    case 6: // DAYOFWK02
                        return CurrentItem.DAYOFWK02;
                    case 7: // DAYOFWK03
                        return CurrentItem.DAYOFWK03;
                    case 8: // DAYOFWK04
                        return CurrentItem.DAYOFWK04;
                    case 9: // DAYOFWK05
                        return CurrentItem.DAYOFWK05;
                    case 10: // DEPART_AM
                        return CurrentItem.DEPART_AM;
                    case 11: // DEPART_PM
                        return CurrentItem.DEPART_PM;
                    case 12: // ARRIVE_AM
                        return CurrentItem.ARRIVE_AM;
                    case 13: // ARRIVE_PM
                        return CurrentItem.ARRIVE_PM;
                    case 14: // MAP_TYPE
                        return CurrentItem.MAP_TYPE;
                    case 15: // MAP_NUM
                        return CurrentItem.MAP_NUM;
                    case 16: // X_AXIS
                        return CurrentItem.X_AXIS;
                    case 17: // Y_AXIS
                        return CurrentItem.Y_AXIS;
                    case 18: // NO_OF_STUD
                        return CurrentItem.NO_OF_STUD;
                    case 19: // PROG_NO
                        return CurrentItem.PROG_NO;
                    case 20: // DIST_LAST
                        return CurrentItem.DIST_LAST;
                    case 21: // LW_DATE
                        return CurrentItem.LW_DATE;
                    case 22: // LW_TIME
                        return CurrentItem.LW_TIME;
                    case 23: // LW_USER
                        return CurrentItem.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TRANSPORT_TYPE
                        return CurrentItem.TRANSPORT_TYPE == null;
                    case 2: // DESCRIPTION
                        return CurrentItem.DESCRIPTION == null;
                    case 3: // ROUTE_CODE
                        return CurrentItem.ROUTE_CODE == null;
                    case 4: // STOP_DESCRIP
                        return CurrentItem.STOP_DESCRIP == null;
                    case 5: // DAYOFWK01
                        return CurrentItem.DAYOFWK01 == null;
                    case 6: // DAYOFWK02
                        return CurrentItem.DAYOFWK02 == null;
                    case 7: // DAYOFWK03
                        return CurrentItem.DAYOFWK03 == null;
                    case 8: // DAYOFWK04
                        return CurrentItem.DAYOFWK04 == null;
                    case 9: // DAYOFWK05
                        return CurrentItem.DAYOFWK05 == null;
                    case 10: // DEPART_AM
                        return CurrentItem.DEPART_AM == null;
                    case 11: // DEPART_PM
                        return CurrentItem.DEPART_PM == null;
                    case 12: // ARRIVE_AM
                        return CurrentItem.ARRIVE_AM == null;
                    case 13: // ARRIVE_PM
                        return CurrentItem.ARRIVE_PM == null;
                    case 14: // MAP_TYPE
                        return CurrentItem.MAP_TYPE == null;
                    case 15: // MAP_NUM
                        return CurrentItem.MAP_NUM == null;
                    case 16: // X_AXIS
                        return CurrentItem.X_AXIS == null;
                    case 17: // Y_AXIS
                        return CurrentItem.Y_AXIS == null;
                    case 18: // NO_OF_STUD
                        return CurrentItem.NO_OF_STUD == null;
                    case 19: // PROG_NO
                        return CurrentItem.PROG_NO == null;
                    case 20: // DIST_LAST
                        return CurrentItem.DIST_LAST == null;
                    case 21: // LW_DATE
                        return CurrentItem.LW_DATE == null;
                    case 22: // LW_TIME
                        return CurrentItem.LW_TIME == null;
                    case 23: // LW_USER
                        return CurrentItem.LW_USER == null;
                    default:
                        return false;
                }
            }

            public string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KCRKEY
                        return "KCRKEY";
                    case 1: // TRANSPORT_TYPE
                        return "TRANSPORT_TYPE";
                    case 2: // DESCRIPTION
                        return "DESCRIPTION";
                    case 3: // ROUTE_CODE
                        return "ROUTE_CODE";
                    case 4: // STOP_DESCRIP
                        return "STOP_DESCRIP";
                    case 5: // DAYOFWK01
                        return "DAYOFWK01";
                    case 6: // DAYOFWK02
                        return "DAYOFWK02";
                    case 7: // DAYOFWK03
                        return "DAYOFWK03";
                    case 8: // DAYOFWK04
                        return "DAYOFWK04";
                    case 9: // DAYOFWK05
                        return "DAYOFWK05";
                    case 10: // DEPART_AM
                        return "DEPART_AM";
                    case 11: // DEPART_PM
                        return "DEPART_PM";
                    case 12: // ARRIVE_AM
                        return "ARRIVE_AM";
                    case 13: // ARRIVE_PM
                        return "ARRIVE_PM";
                    case 14: // MAP_TYPE
                        return "MAP_TYPE";
                    case 15: // MAP_NUM
                        return "MAP_NUM";
                    case 16: // X_AXIS
                        return "X_AXIS";
                    case 17: // Y_AXIS
                        return "Y_AXIS";
                    case 18: // NO_OF_STUD
                        return "NO_OF_STUD";
                    case 19: // PROG_NO
                        return "PROG_NO";
                    case 20: // DIST_LAST
                        return "DIST_LAST";
                    case 21: // LW_DATE
                        return "LW_DATE";
                    case 22: // LW_TIME
                        return "LW_TIME";
                    case 23: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KCRKEY":
                        return 0;
                    case "TRANSPORT_TYPE":
                        return 1;
                    case "DESCRIPTION":
                        return 2;
                    case "ROUTE_CODE":
                        return 3;
                    case "STOP_DESCRIP":
                        return 4;
                    case "DAYOFWK01":
                        return 5;
                    case "DAYOFWK02":
                        return 6;
                    case "DAYOFWK03":
                        return 7;
                    case "DAYOFWK04":
                        return 8;
                    case "DAYOFWK05":
                        return 9;
                    case "DEPART_AM":
                        return 10;
                    case "DEPART_PM":
                        return 11;
                    case "ARRIVE_AM":
                        return 12;
                    case "ARRIVE_PM":
                        return 13;
                    case "MAP_TYPE":
                        return 14;
                    case "MAP_NUM":
                        return 15;
                    case "X_AXIS":
                        return 16;
                    case "Y_AXIS":
                        return 17;
                    case "NO_OF_STUD":
                        return 18;
                    case "PROG_NO":
                        return 19;
                    case "DIST_LAST":
                        return 20;
                    case "LW_DATE":
                        return 21;
                    case "LW_TIME":
                        return 22;
                    case "LW_USER":
                        return 23;
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
