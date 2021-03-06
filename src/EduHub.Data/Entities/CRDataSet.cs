﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accounts Payable Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class CRDataSet : EduHubDataSet<CR>
    {
        /// <inheritdoc />
        public override string Name { get { return "CR"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal CRDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_BSB = new Lazy<NullDictionary<string, IReadOnlyList<CR>>>(() => this.ToGroupedNullDictionary(i => i.BSB));
            Index_CRKEY = new Lazy<Dictionary<string, CR>>(() => this.ToDictionary(i => i.CRKEY));
            Index_PPDKEY = new Lazy<NullDictionary<string, IReadOnlyList<CR>>>(() => this.ToGroupedNullDictionary(i => i.PPDKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="CR" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="CR" /> fields for each CSV column header</returns>
        internal override Action<CR, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<CR, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "CRKEY":
                        mapper[i] = (e, v) => e.CRKEY = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ALLOCAMT":
                        mapper[i] = (e, v) => e.ALLOCAMT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "MTDPURCH":
                        mapper[i] = (e, v) => e.MTDPURCH = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "YTDPURCH":
                        mapper[i] = (e, v) => e.YTDPURCH = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED01":
                        mapper[i] = (e, v) => e.AGED01 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED02":
                        mapper[i] = (e, v) => e.AGED02 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED03":
                        mapper[i] = (e, v) => e.AGED03 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED04":
                        mapper[i] = (e, v) => e.AGED04 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "AGED05":
                        mapper[i] = (e, v) => e.AGED05 = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "OPBAL":
                        mapper[i] = (e, v) => e.OPBAL = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "CRLIMIT":
                        mapper[i] = (e, v) => e.CRLIMIT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "LASTPAYDATE":
                        mapper[i] = (e, v) => e.LASTPAYDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "LASTPAY":
                        mapper[i] = (e, v) => e.LASTPAY = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "ACCTYPE":
                        mapper[i] = (e, v) => e.ACCTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "TERMS":
                        mapper[i] = (e, v) => e.TERMS = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DISCOUNT":
                        mapper[i] = (e, v) => e.DISCOUNT = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "CONTACT":
                        mapper[i] = (e, v) => e.CONTACT = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POSTCODE":
                        mapper[i] = (e, v) => e.POSTCODE = v;
                        break;
                    case "TELEPHONE":
                        mapper[i] = (e, v) => e.TELEPHONE = v;
                        break;
                    case "FAX":
                        mapper[i] = (e, v) => e.FAX = v;
                        break;
                    case "CR_EMAIL":
                        mapper[i] = (e, v) => e.CR_EMAIL = v;
                        break;
                    case "EMAIL_FOR_PAYMENTS":
                        mapper[i] = (e, v) => e.EMAIL_FOR_PAYMENTS = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "COMMITMENT":
                        mapper[i] = (e, v) => e.COMMITMENT = v == null ? (decimal?)null : decimal.Parse(v);
                        break;
                    case "STOP_FLAG":
                        mapper[i] = (e, v) => e.STOP_FLAG = v;
                        break;
                    case "ABN":
                        mapper[i] = (e, v) => e.ABN = v;
                        break;
                    case "PAYG_RATE":
                        mapper[i] = (e, v) => e.PAYG_RATE = v == null ? (double?)null : double.Parse(v);
                        break;
                    case "BSB":
                        mapper[i] = (e, v) => e.BSB = v;
                        break;
                    case "ACCOUNT_NO":
                        mapper[i] = (e, v) => e.ACCOUNT_NO = v;
                        break;
                    case "ACCOUNT_NAME":
                        mapper[i] = (e, v) => e.ACCOUNT_NAME = v;
                        break;
                    case "LODGE_REF":
                        mapper[i] = (e, v) => e.LODGE_REF = v;
                        break;
                    case "BILLER_CODE":
                        mapper[i] = (e, v) => e.BILLER_CODE = v;
                        break;
                    case "BPAY_REFERENCE":
                        mapper[i] = (e, v) => e.BPAY_REFERENCE = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "SECOND_NAME":
                        mapper[i] = (e, v) => e.SECOND_NAME = v;
                        break;
                    case "PAYG_BIRTHDATE":
                        mapper[i] = (e, v) => e.PAYG_BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYG_STARTDATE":
                        mapper[i] = (e, v) => e.PAYG_STARTDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYG_TERMDATE":
                        mapper[i] = (e, v) => e.PAYG_TERMDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "PAYG_ADDRESS01":
                        mapper[i] = (e, v) => e.PAYG_ADDRESS01 = v;
                        break;
                    case "PAYG_ADDRESS02":
                        mapper[i] = (e, v) => e.PAYG_ADDRESS02 = v;
                        break;
                    case "PAYG_SUBURB":
                        mapper[i] = (e, v) => e.PAYG_SUBURB = v;
                        break;
                    case "PAYG_STATE":
                        mapper[i] = (e, v) => e.PAYG_STATE = v;
                        break;
                    case "PAYG_POST":
                        mapper[i] = (e, v) => e.PAYG_POST = v;
                        break;
                    case "PAYG_COUNTRY":
                        mapper[i] = (e, v) => e.PAYG_COUNTRY = v;
                        break;
                    case "PPDKEY":
                        mapper[i] = (e, v) => e.PPDKEY = v;
                        break;
                    case "PRMS_FLAG":
                        mapper[i] = (e, v) => e.PRMS_FLAG = v;
                        break;
                    case "LW_PRMSINFO_DATE":
                        mapper[i] = (e, v) => e.LW_PRMSINFO_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
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
        /// Merges <see cref="CR" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="CR" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="CR" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{CR}"/> of entities</returns>
        internal override IEnumerable<CR> ApplyDeltaEntities(IEnumerable<CR> Entities, List<CR> DeltaEntities)
        {
            HashSet<string> Index_CRKEY = new HashSet<string>(DeltaEntities.Select(i => i.CRKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.CRKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_CRKEY.Remove(entity.CRKEY);
                            
                            if (entity.CRKEY.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
        }

        #region Index Fields

        private Lazy<NullDictionary<string, IReadOnlyList<CR>>> Index_BSB;
        private Lazy<Dictionary<string, CR>> Index_CRKEY;
        private Lazy<NullDictionary<string, IReadOnlyList<CR>>> Index_PPDKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find CR by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CR</param>
        /// <returns>List of related CR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> FindByBSB(string BSB)
        {
            return Index_BSB.Value[BSB];
        }

        /// <summary>
        /// Attempt to find CR by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CR</param>
        /// <param name="Value">List of related CR entities</param>
        /// <returns>True if the list of related CR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByBSB(string BSB, out IReadOnlyList<CR> Value)
        {
            return Index_BSB.Value.TryGetValue(BSB, out Value);
        }

        /// <summary>
        /// Attempt to find CR by BSB field
        /// </summary>
        /// <param name="BSB">BSB value used to find CR</param>
        /// <returns>List of related CR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> TryFindByBSB(string BSB)
        {
            IReadOnlyList<CR> value;
            if (Index_BSB.Value.TryGetValue(BSB, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CR by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CR</param>
        /// <returns>Related CR entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CR FindByCRKEY(string CRKEY)
        {
            return Index_CRKEY.Value[CRKEY];
        }

        /// <summary>
        /// Attempt to find CR by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CR</param>
        /// <param name="Value">Related CR entity</param>
        /// <returns>True if the related CR entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByCRKEY(string CRKEY, out CR Value)
        {
            return Index_CRKEY.Value.TryGetValue(CRKEY, out Value);
        }

        /// <summary>
        /// Attempt to find CR by CRKEY field
        /// </summary>
        /// <param name="CRKEY">CRKEY value used to find CR</param>
        /// <returns>Related CR entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public CR TryFindByCRKEY(string CRKEY)
        {
            CR value;
            if (Index_CRKEY.Value.TryGetValue(CRKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find CR by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find CR</param>
        /// <returns>List of related CR entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> FindByPPDKEY(string PPDKEY)
        {
            return Index_PPDKEY.Value[PPDKEY];
        }

        /// <summary>
        /// Attempt to find CR by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find CR</param>
        /// <param name="Value">List of related CR entities</param>
        /// <returns>True if the list of related CR entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByPPDKEY(string PPDKEY, out IReadOnlyList<CR> Value)
        {
            return Index_PPDKEY.Value.TryGetValue(PPDKEY, out Value);
        }

        /// <summary>
        /// Attempt to find CR by PPDKEY field
        /// </summary>
        /// <param name="PPDKEY">PPDKEY value used to find CR</param>
        /// <returns>List of related CR entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<CR> TryFindByPPDKEY(string PPDKEY)
        {
            IReadOnlyList<CR> value;
            if (Index_PPDKEY.Value.TryGetValue(PPDKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a CR table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[CR]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[CR](
        [CRKEY] varchar(10) NOT NULL,
        [TITLE] varchar(40) NULL,
        [ALLOCAMT] money NULL,
        [MTDPURCH] money NULL,
        [YTDPURCH] money NULL,
        [AGED01] money NULL,
        [AGED02] money NULL,
        [AGED03] money NULL,
        [AGED04] money NULL,
        [AGED05] money NULL,
        [OPBAL] money NULL,
        [CRLIMIT] money NULL,
        [LASTPAYDATE] datetime NULL,
        [LASTPAY] money NULL,
        [ACCTYPE] smallint NULL,
        [TERMS] smallint NULL,
        [DISCOUNT] float NULL,
        [CONTACT] varchar(30) NULL,
        [ADDRESS01] varchar(40) NULL,
        [ADDRESS02] varchar(40) NULL,
        [ADDRESS03] varchar(40) NULL,
        [STATE] varchar(4) NULL,
        [POSTCODE] varchar(4) NULL,
        [TELEPHONE] varchar(15) NULL,
        [FAX] varchar(15) NULL,
        [CR_EMAIL] varchar(60) NULL,
        [EMAIL_FOR_PAYMENTS] varchar(60) NULL,
        [MOBILE] varchar(15) NULL,
        [COMMITMENT] money NULL,
        [STOP_FLAG] varchar(1) NULL,
        [ABN] varchar(15) NULL,
        [PAYG_RATE] float NULL,
        [BSB] varchar(6) NULL,
        [ACCOUNT_NO] varchar(15) NULL,
        [ACCOUNT_NAME] varchar(60) NULL,
        [LODGE_REF] varchar(18) NULL,
        [BILLER_CODE] varchar(10) NULL,
        [BPAY_REFERENCE] varchar(20) NULL,
        [SURNAME] varchar(30) NULL,
        [FIRST_NAME] varchar(15) NULL,
        [SECOND_NAME] varchar(15) NULL,
        [PAYG_BIRTHDATE] datetime NULL,
        [PAYG_STARTDATE] datetime NULL,
        [PAYG_TERMDATE] datetime NULL,
        [PAYG_ADDRESS01] varchar(38) NULL,
        [PAYG_ADDRESS02] varchar(38) NULL,
        [PAYG_SUBURB] varchar(20) NULL,
        [PAYG_STATE] varchar(3) NULL,
        [PAYG_POST] varchar(4) NULL,
        [PAYG_COUNTRY] varchar(20) NULL,
        [PPDKEY] varchar(10) NULL,
        [PRMS_FLAG] varchar(1) NULL,
        [LW_PRMSINFO_DATE] datetime NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [CR_Index_CRKEY] PRIMARY KEY CLUSTERED (
            [CRKEY] ASC
        )
    );
    CREATE NONCLUSTERED INDEX [CR_Index_BSB] ON [dbo].[CR]
    (
            [BSB] ASC
    );
    CREATE NONCLUSTERED INDEX [CR_Index_PPDKEY] ON [dbo].[CR]
    (
            [PPDKEY] ASC
    );
END");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which disables all non-clustered table indexes.
        /// Typically called before <see cref="SqlBulkCopy"/> to improve performance.
        /// <see cref="GetSqlRebuildIndexesCommand(SqlConnection)"/> should be called to rebuild and enable indexes after performance sensitive work is completed.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will disable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CR]') AND name = N'Index_BSB')
    ALTER INDEX [Index_BSB] ON [dbo].[CR] DISABLE;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CR]') AND name = N'Index_PPDKEY')
    ALTER INDEX [Index_PPDKEY] ON [dbo].[CR] DISABLE;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which rebuilds and enables all non-clustered table indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>A <see cref="SqlCommand"/> which (when executed) will rebuild and enable all non-clustered table indexes</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CR]') AND name = N'Index_BSB')
    ALTER INDEX [Index_BSB] ON [dbo].[CR] REBUILD PARTITION = ALL;
IF EXISTS (SELECT * FROM dbo.sysindexes WHERE id = OBJECT_ID(N'[dbo].[CR]') AND name = N'Index_PPDKEY')
    ALTER INDEX [Index_PPDKEY] ON [dbo].[CR] REBUILD PARTITION = ALL;
");
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="CR"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="CR"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<CR> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_CRKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_CRKEY.Add(entity.CRKEY);
            }

            builder.AppendLine("DELETE [dbo].[CR] WHERE");


            // Index_CRKEY
            builder.Append("[CRKEY] IN (");
            for (int index = 0; index < Index_CRKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // CRKEY
                var parameterCRKEY = $"@p{parameterIndex++}";
                builder.Append(parameterCRKEY);
                command.Parameters.Add(parameterCRKEY, SqlDbType.VarChar, 10).Value = Index_CRKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the CR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the CR data set</returns>
        public override EduHubDataSetDataReader<CR> GetDataSetDataReader()
        {
            return new CRDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the CR data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the CR data set</returns>
        public override EduHubDataSetDataReader<CR> GetDataSetDataReader(List<CR> Entities)
        {
            return new CRDataReader(new EduHubDataSetLoadedReader<CR>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class CRDataReader : EduHubDataSetDataReader<CR>
        {
            public CRDataReader(IEduHubDataSetReader<CR> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 56; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // CRKEY
                        return Current.CRKEY;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // ALLOCAMT
                        return Current.ALLOCAMT;
                    case 3: // MTDPURCH
                        return Current.MTDPURCH;
                    case 4: // YTDPURCH
                        return Current.YTDPURCH;
                    case 5: // AGED01
                        return Current.AGED01;
                    case 6: // AGED02
                        return Current.AGED02;
                    case 7: // AGED03
                        return Current.AGED03;
                    case 8: // AGED04
                        return Current.AGED04;
                    case 9: // AGED05
                        return Current.AGED05;
                    case 10: // OPBAL
                        return Current.OPBAL;
                    case 11: // CRLIMIT
                        return Current.CRLIMIT;
                    case 12: // LASTPAYDATE
                        return Current.LASTPAYDATE;
                    case 13: // LASTPAY
                        return Current.LASTPAY;
                    case 14: // ACCTYPE
                        return Current.ACCTYPE;
                    case 15: // TERMS
                        return Current.TERMS;
                    case 16: // DISCOUNT
                        return Current.DISCOUNT;
                    case 17: // CONTACT
                        return Current.CONTACT;
                    case 18: // ADDRESS01
                        return Current.ADDRESS01;
                    case 19: // ADDRESS02
                        return Current.ADDRESS02;
                    case 20: // ADDRESS03
                        return Current.ADDRESS03;
                    case 21: // STATE
                        return Current.STATE;
                    case 22: // POSTCODE
                        return Current.POSTCODE;
                    case 23: // TELEPHONE
                        return Current.TELEPHONE;
                    case 24: // FAX
                        return Current.FAX;
                    case 25: // CR_EMAIL
                        return Current.CR_EMAIL;
                    case 26: // EMAIL_FOR_PAYMENTS
                        return Current.EMAIL_FOR_PAYMENTS;
                    case 27: // MOBILE
                        return Current.MOBILE;
                    case 28: // COMMITMENT
                        return Current.COMMITMENT;
                    case 29: // STOP_FLAG
                        return Current.STOP_FLAG;
                    case 30: // ABN
                        return Current.ABN;
                    case 31: // PAYG_RATE
                        return Current.PAYG_RATE;
                    case 32: // BSB
                        return Current.BSB;
                    case 33: // ACCOUNT_NO
                        return Current.ACCOUNT_NO;
                    case 34: // ACCOUNT_NAME
                        return Current.ACCOUNT_NAME;
                    case 35: // LODGE_REF
                        return Current.LODGE_REF;
                    case 36: // BILLER_CODE
                        return Current.BILLER_CODE;
                    case 37: // BPAY_REFERENCE
                        return Current.BPAY_REFERENCE;
                    case 38: // SURNAME
                        return Current.SURNAME;
                    case 39: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 40: // SECOND_NAME
                        return Current.SECOND_NAME;
                    case 41: // PAYG_BIRTHDATE
                        return Current.PAYG_BIRTHDATE;
                    case 42: // PAYG_STARTDATE
                        return Current.PAYG_STARTDATE;
                    case 43: // PAYG_TERMDATE
                        return Current.PAYG_TERMDATE;
                    case 44: // PAYG_ADDRESS01
                        return Current.PAYG_ADDRESS01;
                    case 45: // PAYG_ADDRESS02
                        return Current.PAYG_ADDRESS02;
                    case 46: // PAYG_SUBURB
                        return Current.PAYG_SUBURB;
                    case 47: // PAYG_STATE
                        return Current.PAYG_STATE;
                    case 48: // PAYG_POST
                        return Current.PAYG_POST;
                    case 49: // PAYG_COUNTRY
                        return Current.PAYG_COUNTRY;
                    case 50: // PPDKEY
                        return Current.PPDKEY;
                    case 51: // PRMS_FLAG
                        return Current.PRMS_FLAG;
                    case 52: // LW_PRMSINFO_DATE
                        return Current.LW_PRMSINFO_DATE;
                    case 53: // LW_DATE
                        return Current.LW_DATE;
                    case 54: // LW_TIME
                        return Current.LW_TIME;
                    case 55: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return Current.TITLE == null;
                    case 2: // ALLOCAMT
                        return Current.ALLOCAMT == null;
                    case 3: // MTDPURCH
                        return Current.MTDPURCH == null;
                    case 4: // YTDPURCH
                        return Current.YTDPURCH == null;
                    case 5: // AGED01
                        return Current.AGED01 == null;
                    case 6: // AGED02
                        return Current.AGED02 == null;
                    case 7: // AGED03
                        return Current.AGED03 == null;
                    case 8: // AGED04
                        return Current.AGED04 == null;
                    case 9: // AGED05
                        return Current.AGED05 == null;
                    case 10: // OPBAL
                        return Current.OPBAL == null;
                    case 11: // CRLIMIT
                        return Current.CRLIMIT == null;
                    case 12: // LASTPAYDATE
                        return Current.LASTPAYDATE == null;
                    case 13: // LASTPAY
                        return Current.LASTPAY == null;
                    case 14: // ACCTYPE
                        return Current.ACCTYPE == null;
                    case 15: // TERMS
                        return Current.TERMS == null;
                    case 16: // DISCOUNT
                        return Current.DISCOUNT == null;
                    case 17: // CONTACT
                        return Current.CONTACT == null;
                    case 18: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 19: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 20: // ADDRESS03
                        return Current.ADDRESS03 == null;
                    case 21: // STATE
                        return Current.STATE == null;
                    case 22: // POSTCODE
                        return Current.POSTCODE == null;
                    case 23: // TELEPHONE
                        return Current.TELEPHONE == null;
                    case 24: // FAX
                        return Current.FAX == null;
                    case 25: // CR_EMAIL
                        return Current.CR_EMAIL == null;
                    case 26: // EMAIL_FOR_PAYMENTS
                        return Current.EMAIL_FOR_PAYMENTS == null;
                    case 27: // MOBILE
                        return Current.MOBILE == null;
                    case 28: // COMMITMENT
                        return Current.COMMITMENT == null;
                    case 29: // STOP_FLAG
                        return Current.STOP_FLAG == null;
                    case 30: // ABN
                        return Current.ABN == null;
                    case 31: // PAYG_RATE
                        return Current.PAYG_RATE == null;
                    case 32: // BSB
                        return Current.BSB == null;
                    case 33: // ACCOUNT_NO
                        return Current.ACCOUNT_NO == null;
                    case 34: // ACCOUNT_NAME
                        return Current.ACCOUNT_NAME == null;
                    case 35: // LODGE_REF
                        return Current.LODGE_REF == null;
                    case 36: // BILLER_CODE
                        return Current.BILLER_CODE == null;
                    case 37: // BPAY_REFERENCE
                        return Current.BPAY_REFERENCE == null;
                    case 38: // SURNAME
                        return Current.SURNAME == null;
                    case 39: // FIRST_NAME
                        return Current.FIRST_NAME == null;
                    case 40: // SECOND_NAME
                        return Current.SECOND_NAME == null;
                    case 41: // PAYG_BIRTHDATE
                        return Current.PAYG_BIRTHDATE == null;
                    case 42: // PAYG_STARTDATE
                        return Current.PAYG_STARTDATE == null;
                    case 43: // PAYG_TERMDATE
                        return Current.PAYG_TERMDATE == null;
                    case 44: // PAYG_ADDRESS01
                        return Current.PAYG_ADDRESS01 == null;
                    case 45: // PAYG_ADDRESS02
                        return Current.PAYG_ADDRESS02 == null;
                    case 46: // PAYG_SUBURB
                        return Current.PAYG_SUBURB == null;
                    case 47: // PAYG_STATE
                        return Current.PAYG_STATE == null;
                    case 48: // PAYG_POST
                        return Current.PAYG_POST == null;
                    case 49: // PAYG_COUNTRY
                        return Current.PAYG_COUNTRY == null;
                    case 50: // PPDKEY
                        return Current.PPDKEY == null;
                    case 51: // PRMS_FLAG
                        return Current.PRMS_FLAG == null;
                    case 52: // LW_PRMSINFO_DATE
                        return Current.LW_PRMSINFO_DATE == null;
                    case 53: // LW_DATE
                        return Current.LW_DATE == null;
                    case 54: // LW_TIME
                        return Current.LW_TIME == null;
                    case 55: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // CRKEY
                        return "CRKEY";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // ALLOCAMT
                        return "ALLOCAMT";
                    case 3: // MTDPURCH
                        return "MTDPURCH";
                    case 4: // YTDPURCH
                        return "YTDPURCH";
                    case 5: // AGED01
                        return "AGED01";
                    case 6: // AGED02
                        return "AGED02";
                    case 7: // AGED03
                        return "AGED03";
                    case 8: // AGED04
                        return "AGED04";
                    case 9: // AGED05
                        return "AGED05";
                    case 10: // OPBAL
                        return "OPBAL";
                    case 11: // CRLIMIT
                        return "CRLIMIT";
                    case 12: // LASTPAYDATE
                        return "LASTPAYDATE";
                    case 13: // LASTPAY
                        return "LASTPAY";
                    case 14: // ACCTYPE
                        return "ACCTYPE";
                    case 15: // TERMS
                        return "TERMS";
                    case 16: // DISCOUNT
                        return "DISCOUNT";
                    case 17: // CONTACT
                        return "CONTACT";
                    case 18: // ADDRESS01
                        return "ADDRESS01";
                    case 19: // ADDRESS02
                        return "ADDRESS02";
                    case 20: // ADDRESS03
                        return "ADDRESS03";
                    case 21: // STATE
                        return "STATE";
                    case 22: // POSTCODE
                        return "POSTCODE";
                    case 23: // TELEPHONE
                        return "TELEPHONE";
                    case 24: // FAX
                        return "FAX";
                    case 25: // CR_EMAIL
                        return "CR_EMAIL";
                    case 26: // EMAIL_FOR_PAYMENTS
                        return "EMAIL_FOR_PAYMENTS";
                    case 27: // MOBILE
                        return "MOBILE";
                    case 28: // COMMITMENT
                        return "COMMITMENT";
                    case 29: // STOP_FLAG
                        return "STOP_FLAG";
                    case 30: // ABN
                        return "ABN";
                    case 31: // PAYG_RATE
                        return "PAYG_RATE";
                    case 32: // BSB
                        return "BSB";
                    case 33: // ACCOUNT_NO
                        return "ACCOUNT_NO";
                    case 34: // ACCOUNT_NAME
                        return "ACCOUNT_NAME";
                    case 35: // LODGE_REF
                        return "LODGE_REF";
                    case 36: // BILLER_CODE
                        return "BILLER_CODE";
                    case 37: // BPAY_REFERENCE
                        return "BPAY_REFERENCE";
                    case 38: // SURNAME
                        return "SURNAME";
                    case 39: // FIRST_NAME
                        return "FIRST_NAME";
                    case 40: // SECOND_NAME
                        return "SECOND_NAME";
                    case 41: // PAYG_BIRTHDATE
                        return "PAYG_BIRTHDATE";
                    case 42: // PAYG_STARTDATE
                        return "PAYG_STARTDATE";
                    case 43: // PAYG_TERMDATE
                        return "PAYG_TERMDATE";
                    case 44: // PAYG_ADDRESS01
                        return "PAYG_ADDRESS01";
                    case 45: // PAYG_ADDRESS02
                        return "PAYG_ADDRESS02";
                    case 46: // PAYG_SUBURB
                        return "PAYG_SUBURB";
                    case 47: // PAYG_STATE
                        return "PAYG_STATE";
                    case 48: // PAYG_POST
                        return "PAYG_POST";
                    case 49: // PAYG_COUNTRY
                        return "PAYG_COUNTRY";
                    case 50: // PPDKEY
                        return "PPDKEY";
                    case 51: // PRMS_FLAG
                        return "PRMS_FLAG";
                    case 52: // LW_PRMSINFO_DATE
                        return "LW_PRMSINFO_DATE";
                    case 53: // LW_DATE
                        return "LW_DATE";
                    case 54: // LW_TIME
                        return "LW_TIME";
                    case 55: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "CRKEY":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "ALLOCAMT":
                        return 2;
                    case "MTDPURCH":
                        return 3;
                    case "YTDPURCH":
                        return 4;
                    case "AGED01":
                        return 5;
                    case "AGED02":
                        return 6;
                    case "AGED03":
                        return 7;
                    case "AGED04":
                        return 8;
                    case "AGED05":
                        return 9;
                    case "OPBAL":
                        return 10;
                    case "CRLIMIT":
                        return 11;
                    case "LASTPAYDATE":
                        return 12;
                    case "LASTPAY":
                        return 13;
                    case "ACCTYPE":
                        return 14;
                    case "TERMS":
                        return 15;
                    case "DISCOUNT":
                        return 16;
                    case "CONTACT":
                        return 17;
                    case "ADDRESS01":
                        return 18;
                    case "ADDRESS02":
                        return 19;
                    case "ADDRESS03":
                        return 20;
                    case "STATE":
                        return 21;
                    case "POSTCODE":
                        return 22;
                    case "TELEPHONE":
                        return 23;
                    case "FAX":
                        return 24;
                    case "CR_EMAIL":
                        return 25;
                    case "EMAIL_FOR_PAYMENTS":
                        return 26;
                    case "MOBILE":
                        return 27;
                    case "COMMITMENT":
                        return 28;
                    case "STOP_FLAG":
                        return 29;
                    case "ABN":
                        return 30;
                    case "PAYG_RATE":
                        return 31;
                    case "BSB":
                        return 32;
                    case "ACCOUNT_NO":
                        return 33;
                    case "ACCOUNT_NAME":
                        return 34;
                    case "LODGE_REF":
                        return 35;
                    case "BILLER_CODE":
                        return 36;
                    case "BPAY_REFERENCE":
                        return 37;
                    case "SURNAME":
                        return 38;
                    case "FIRST_NAME":
                        return 39;
                    case "SECOND_NAME":
                        return 40;
                    case "PAYG_BIRTHDATE":
                        return 41;
                    case "PAYG_STARTDATE":
                        return 42;
                    case "PAYG_TERMDATE":
                        return 43;
                    case "PAYG_ADDRESS01":
                        return 44;
                    case "PAYG_ADDRESS02":
                        return 45;
                    case "PAYG_SUBURB":
                        return 46;
                    case "PAYG_STATE":
                        return 47;
                    case "PAYG_POST":
                        return 48;
                    case "PAYG_COUNTRY":
                        return 49;
                    case "PPDKEY":
                        return 50;
                    case "PRMS_FLAG":
                        return 51;
                    case "LW_PRMSINFO_DATE":
                        return 52;
                    case "LW_DATE":
                        return 53;
                    case "LW_TIME":
                        return 54;
                    case "LW_USER":
                        return 55;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
