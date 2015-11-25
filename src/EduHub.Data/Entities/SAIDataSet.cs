﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accident Involvements/Sickbay Visits Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SAIDataSet : SetBase<SAI>
    {
        /// <summary>
        /// Data Set Name
        /// </summary>
        public override string Name { get { return "SAI"; } }

        internal SAIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ACCIDENTID = new Lazy<NullDictionary<int?, IReadOnlyList<SAI>>>(() => this.ToGroupedNullDictionary(i => i.ACCIDENTID));
            Index_SAIKEY = new Lazy<Dictionary<int, SAI>>(() => this.ToDictionary(i => i.SAIKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SAI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SAI" /> fields for each CSV column header</returns>
        protected override Action<SAI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SAI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "SAIKEY":
                        mapper[i] = (e, v) => e.SAIKEY = int.Parse(v);
                        break;
                    case "ENTRY_TYPE":
                        mapper[i] = (e, v) => e.ENTRY_TYPE = v;
                        break;
                    case "ACCIDENTID":
                        mapper[i] = (e, v) => e.ACCIDENTID = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "INV_PERSON_TYPE":
                        mapper[i] = (e, v) => e.INV_PERSON_TYPE = v;
                        break;
                    case "INV_PERSONKEY":
                        mapper[i] = (e, v) => e.INV_PERSONKEY = v;
                        break;
                    case "INV_PERSON_DFAB":
                        mapper[i] = (e, v) => e.INV_PERSON_DFAB = v;
                        break;
                    case "INV_FULL_NAME":
                        mapper[i] = (e, v) => e.INV_FULL_NAME = v;
                        break;
                    case "INV_ADDRESS":
                        mapper[i] = (e, v) => e.INV_ADDRESS = v;
                        break;
                    case "INV_TELEPHONE":
                        mapper[i] = (e, v) => e.INV_TELEPHONE = v;
                        break;
                    case "INV_BIRTHDATE":
                        mapper[i] = (e, v) => e.INV_BIRTHDATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "INV_GENDER":
                        mapper[i] = (e, v) => e.INV_GENDER = v;
                        break;
                    case "INV_PAYROLL_REC_NO":
                        mapper[i] = (e, v) => e.INV_PAYROLL_REC_NO = v;
                        break;
                    case "INV_STAFF_TYPE":
                        mapper[i] = (e, v) => e.INV_STAFF_TYPE = v;
                        break;
                    case "HELP_PERSON_TYPE":
                        mapper[i] = (e, v) => e.HELP_PERSON_TYPE = v;
                        break;
                    case "HELP_PERSONKEY":
                        mapper[i] = (e, v) => e.HELP_PERSONKEY = v;
                        break;
                    case "HELP_PERSON_DFAB":
                        mapper[i] = (e, v) => e.HELP_PERSON_DFAB = v;
                        break;
                    case "HELP_FULL_NAME":
                        mapper[i] = (e, v) => e.HELP_FULL_NAME = v;
                        break;
                    case "INCIDENT_NO":
                        mapper[i] = (e, v) => e.INCIDENT_NO = v;
                        break;
                    case "SENT_TO_DEPT":
                        mapper[i] = (e, v) => e.SENT_TO_DEPT = v;
                        break;
                    case "CLAIM_LODGED":
                        mapper[i] = (e, v) => e.CLAIM_LODGED = v;
                        break;
                    case "CLAIM_DATE":
                        mapper[i] = (e, v) => e.CLAIM_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "WORK_CEASED_DATE":
                        mapper[i] = (e, v) => e.WORK_CEASED_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "SUCCESSFUL_CONTACT":
                        mapper[i] = (e, v) => e.SUCCESSFUL_CONTACT = v;
                        break;
                    case "OTHER_SUCCESSFUL_CONTACT":
                        mapper[i] = (e, v) => e.OTHER_SUCCESSFUL_CONTACT = v;
                        break;
                    case "DOCTOR":
                        mapper[i] = (e, v) => e.DOCTOR = v;
                        break;
                    case "OTHER_DOCTOR":
                        mapper[i] = (e, v) => e.OTHER_DOCTOR = v;
                        break;
                    case "HOSPITAL":
                        mapper[i] = (e, v) => e.HOSPITAL = v;
                        break;
                    case "AMBULANCE":
                        mapper[i] = (e, v) => e.AMBULANCE = v;
                        break;
                    case "ATTENDANCE_DATE":
                        mapper[i] = (e, v) => e.ATTENDANCE_DATE = v == null ? (DateTime?)null : DateTime.Parse(v);
                        break;
                    case "ATTENDANCE_IN_TIME":
                        mapper[i] = (e, v) => e.ATTENDANCE_IN_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ATTENDANCE_OUT_TIME":
                        mapper[i] = (e, v) => e.ATTENDANCE_OUT_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "SYMPTOMS":
                        mapper[i] = (e, v) => e.SYMPTOMS = v;
                        break;
                    case "SICKBAY_ACTION":
                        mapper[i] = (e, v) => e.SICKBAY_ACTION = v;
                        break;
                    case "ACTION_OUTCOME":
                        mapper[i] = (e, v) => e.ACTION_OUTCOME = v;
                        break;
                    case "SMS_KEY":
                        mapper[i] = (e, v) => e.SMS_KEY = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "EMAIL_KEY":
                        mapper[i] = (e, v) => e.EMAIL_KEY = v == null ? (int?)null : int.Parse(v);
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
        /// Merges <see cref="SAI" /> delta entities
        /// </summary>
        /// <param name="Items">Base <see cref="SAI" /> items</param>
        /// <param name="DeltaItems">Delta <see cref="SAI" /> items to added or update the base <see cref="SAI" /> items</param>
        /// <returns>A merged list of <see cref="SAI" /> items</returns>
        protected override List<SAI> ApplyDeltaItems(List<SAI> Items, List<SAI> DeltaItems)
        {
            Dictionary<int, int> Index_SAIKEY = Items.ToIndexDictionary(i => i.SAIKEY);
            HashSet<int> removeIndexes = new HashSet<int>();

            foreach (SAI deltaItem in DeltaItems)
            {
                int index;

                if (Index_SAIKEY.TryGetValue(deltaItem.SAIKEY, out index))
                {
                    removeIndexes.Add(index);
                }
            }

            return Items
                .Remove(removeIndexes)
                .Concat(DeltaItems)
                .OrderBy(i => i.SAIKEY)
                .ToList();
        }

        #region Index Fields

        private Lazy<NullDictionary<int?, IReadOnlyList<SAI>>> Index_ACCIDENTID;
        private Lazy<Dictionary<int, SAI>> Index_SAIKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SAI by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SAI</param>
        /// <returns>List of related SAI entities</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAI> FindByACCIDENTID(int? ACCIDENTID)
        {
            return Index_ACCIDENTID.Value[ACCIDENTID];
        }

        /// <summary>
        /// Attempt to find SAI by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SAI</param>
        /// <param name="Value">List of related SAI entities</param>
        /// <returns>True if the list of related SAI entities is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByACCIDENTID(int? ACCIDENTID, out IReadOnlyList<SAI> Value)
        {
            return Index_ACCIDENTID.Value.TryGetValue(ACCIDENTID, out Value);
        }

        /// <summary>
        /// Attempt to find SAI by ACCIDENTID field
        /// </summary>
        /// <param name="ACCIDENTID">ACCIDENTID value used to find SAI</param>
        /// <returns>List of related SAI entities, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public IReadOnlyList<SAI> TryFindByACCIDENTID(int? ACCIDENTID)
        {
            IReadOnlyList<SAI> value;
            if (Index_ACCIDENTID.Value.TryGetValue(ACCIDENTID, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Find SAI by SAIKEY field
        /// </summary>
        /// <param name="SAIKEY">SAIKEY value used to find SAI</param>
        /// <returns>Related SAI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAI FindBySAIKEY(int SAIKEY)
        {
            return Index_SAIKEY.Value[SAIKEY];
        }

        /// <summary>
        /// Attempt to find SAI by SAIKEY field
        /// </summary>
        /// <param name="SAIKEY">SAIKEY value used to find SAI</param>
        /// <param name="Value">Related SAI entity</param>
        /// <returns>True if the related SAI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindBySAIKEY(int SAIKEY, out SAI Value)
        {
            return Index_SAIKEY.Value.TryGetValue(SAIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find SAI by SAIKEY field
        /// </summary>
        /// <param name="SAIKEY">SAIKEY value used to find SAI</param>
        /// <returns>Related SAI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SAI TryFindBySAIKEY(int SAIKEY)
        {
            SAI value;
            if (Index_SAIKEY.Value.TryGetValue(SAIKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

    }
}
