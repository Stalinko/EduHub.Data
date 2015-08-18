﻿using System;
using System.Collections.Generic;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Accounts Payable
    /// </summary>
    public class CR : EntityBase
    {
#region Navigation Property Cache
        private KAB _BSB_KAB;
        private PPD _PPDKEY_PPD;
#endregion

#region Field Properties
        /// <summary>
        /// Prime Key
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string CRKEY { get; internal set; }
        /// <summary>
        /// Creditor title
        /// [Alphanumeric (40)]
        /// </summary>
        public string TITLE { get; internal set; }
        /// <summary>
        /// Outstanding allocation amount
        /// </summary>
        public decimal? ALLOCAMT { get; internal set; }
        /// <summary>
        /// MTD purchases
        /// </summary>
        public decimal? MTDPURCH { get; internal set; }
        /// <summary>
        /// YTD purchases
        /// </summary>
        public decimal? YTDPURCH { get; internal set; }
        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED01 { get; internal set; }
        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED02 { get; internal set; }
        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED03 { get; internal set; }
        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED04 { get; internal set; }
        /// <summary>
        /// Aged balances
        /// </summary>
        public decimal? AGED05 { get; internal set; }
        /// <summary>
        /// Opening balance
        /// </summary>
        public decimal? OPBAL { get; internal set; }
        /// <summary>
        /// Credit limit
        /// </summary>
        public decimal? CRLIMIT { get; internal set; }
        /// <summary>
        /// Last payment date
        /// </summary>
        public DateTime? LASTPAYDATE { get; internal set; }
        /// <summary>
        /// Last payment amount
        /// </summary>
        public decimal? LASTPAY { get; internal set; }
        /// <summary>
        /// Account type
        /// 0 - Balance forward
        /// 1 - Open item
        /// </summary>
        public short? ACCTYPE { get; internal set; }
        /// <summary>
        /// Trading terms in days
        /// </summary>
        public short? TERMS { get; internal set; }
        /// <summary>
        /// Discount percentage
        /// </summary>
        public double? DISCOUNT { get; internal set; }
        /// <summary>
        /// Contact name
        /// [Alphanumeric (30)]
        /// </summary>
        public string CONTACT { get; internal set; }
        /// <summary>
        /// Three address lines
        /// [Alphanumeric (40)]
        /// </summary>
        public string ADDRESS01 { get; internal set; }
        /// <summary>
        /// Three address lines
        /// [Alphanumeric (40)]
        /// </summary>
        public string ADDRESS02 { get; internal set; }
        /// <summary>
        /// Three address lines
        /// [Alphanumeric (40)]
        /// </summary>
        public string ADDRESS03 { get; internal set; }
        /// <summary>
        /// State
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string STATE { get; internal set; }
        /// <summary>
        /// Post code
        /// [Alphanumeric (4)]
        /// </summary>
        public string POSTCODE { get; internal set; }
        /// <summary>
        /// Phone number
        /// [Alphanumeric (15)]
        /// </summary>
        public string TELEPHONE { get; internal set; }
        /// <summary>
        /// Facsimile number
        /// [Alphanumeric (15)]
        /// </summary>
        public string FAX { get; internal set; }
        /// <summary>
        /// Email Address for orders
        /// [Alphanumeric (60)]
        /// </summary>
        public string CR_EMAIL { get; internal set; }
        /// <summary>
        /// Email address for payments
        /// [Alphanumeric (60)]
        /// </summary>
        public string EMAIL_FOR_PAYMENTS { get; internal set; }
        /// <summary>
        /// Mobile number
        /// [Alphanumeric (15)]
        /// </summary>
        public string MOBILE { get; internal set; }
        /// <summary>
        /// Committed future purchases
        /// </summary>
        public decimal? COMMITMENT { get; internal set; }
        /// <summary>
        /// 
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string STOP_FLAG { get; internal set; }
        /// <summary>
        /// Australian Business number
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string ABN { get; internal set; }
        /// <summary>
        /// Pay As You Go rate
        /// </summary>
        public double? PAYG_RATE { get; internal set; }
        /// <summary>
        /// Bank/State/Branch number
        /// [Alphanumeric (6)]
        /// </summary>
        public string BSB { get; internal set; }
        /// <summary>
        /// Bank Account Number
        /// [Alphanumeric (15)]
        /// </summary>
        public string ACCOUNT_NO { get; internal set; }
        /// <summary>
        /// Bank Account Name
        /// [Alphanumeric (60)]
        /// </summary>
        public string ACCOUNT_NAME { get; internal set; }
        /// <summary>
        /// Lodgement Reference
        /// [Alphanumeric (18)]
        /// </summary>
        public string LODGE_REF { get; internal set; }
        /// <summary>
        /// BPAY biller code
        /// [Alphanumeric (10)]
        /// </summary>
        public string BILLER_CODE { get; internal set; }
        /// <summary>
        /// BPAY reference
        /// [Alphanumeric (20)]
        /// </summary>
        public string BPAY_REFERENCE { get; internal set; }
        /// <summary>
        /// Surname
        /// [Uppercase Alphanumeric (30)]
        /// </summary>
        public string SURNAME { get; internal set; }
        /// <summary>
        /// First name
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string FIRST_NAME { get; internal set; }
        /// <summary>
        /// Second name
        /// [Uppercase Alphanumeric (15)]
        /// </summary>
        public string SECOND_NAME { get; internal set; }
        /// <summary>
        /// Birthdate
        /// </summary>
        public DateTime? PAYG_BIRTHDATE { get; internal set; }
        /// <summary>
        /// Startdate
        /// </summary>
        public DateTime? PAYG_STARTDATE { get; internal set; }
        /// <summary>
        /// Contract enddate
        /// </summary>
        public DateTime? PAYG_TERMDATE { get; internal set; }
        /// <summary>
        /// Two address lines
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string PAYG_ADDRESS01 { get; internal set; }
        /// <summary>
        /// Two address lines
        /// [Uppercase Alphanumeric (38)]
        /// </summary>
        public string PAYG_ADDRESS02 { get; internal set; }
        /// <summary>
        /// Suburb
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string PAYG_SUBURB { get; internal set; }
        /// <summary>
        /// State
        /// [Uppercase Alphanumeric (3)]
        /// </summary>
        public string PAYG_STATE { get; internal set; }
        /// <summary>
        /// Postcode
        /// [Uppercase Alphanumeric (4)]
        /// </summary>
        public string PAYG_POST { get; internal set; }
        /// <summary>
        /// Country
        /// [Uppercase Alphanumeric (20)]
        /// </summary>
        public string PAYG_COUNTRY { get; internal set; }
        /// <summary>
        /// Payer code in PPD
        /// [Uppercase Alphanumeric (10)]
        /// </summary>
        public string PPDKEY { get; internal set; }
        /// <summary>
        /// Is this a PRMS creditor
        /// [Uppercase Alphanumeric (1)]
        /// </summary>
        public string PRMS_FLAG { get; internal set; }
        /// <summary>
        /// Last write date for PRMS fields
        /// </summary>
        public DateTime? LW_PRMSINFO_DATE { get; internal set; }
        /// <summary>
        /// Last write date
        /// </summary>
        public DateTime? LW_DATE { get; internal set; }
        /// <summary>
        /// Last write time
        /// </summary>
        public short? LW_TIME { get; internal set; }
        /// <summary>
        /// Last operator
        /// [Uppercase Alphanumeric (128)]
        /// </summary>
        public string LW_USER { get; internal set; }
#endregion

#region Navigation Properties
        /// <summary>
        /// Navigation property for [BSB] => [KAB].[BSB]
        /// Bank/State/Branch number
        /// </summary>
        public KAB BSB_KAB {
            get
            {
                if (BSB != null)
                {
                    if (_BSB_KAB == null)
                    {
                        _BSB_KAB = Context.KAB.FindByBSB(BSB);
                    }
                    return _BSB_KAB;
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// Navigation property for [PPDKEY] => [PPD].[PPDKEY]
        /// Payer code in PPD
        /// </summary>
        public PPD PPDKEY_PPD {
            get
            {
                if (PPDKEY != null)
                {
                    if (_PPDKEY_PPD == null)
                    {
                        _PPDKEY_PPD = Context.PPD.FindByPPDKEY(PPDKEY);
                    }
                    return _PPDKEY_PPD;
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