// This is a generated file.  Don't edit it directly!

using QuickFix.Fields;
namespace QuickFix
{
    namespace FIX42 
    {
        public class MarketDataIncrementalRefresh : Message
        {
            public const string MsgType = "X";

            public MarketDataIncrementalRefresh() : base()
            {
                this.Header.SetField(new QuickFix.Fields.MsgType("X"));
            }


            public QuickFix.Fields.MDReqID mDReqID
            { 
                get 
                {
                    QuickFix.Fields.MDReqID val = new QuickFix.Fields.MDReqID();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.MDReqID val) 
            { 
                this.mDReqID = val;
            }
            
            public QuickFix.Fields.MDReqID Get(QuickFix.Fields.MDReqID val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.MDReqID val) 
            { 
                return IsSetMDReqID();
            }
            
            public bool IsSetMDReqID() 
            { 
                return IsSetField(Tags.MDReqID);
            }
            public QuickFix.Fields.NoMDEntries noMDEntries
            { 
                get 
                {
                    QuickFix.Fields.NoMDEntries val = new QuickFix.Fields.NoMDEntries();
                    GetField(val);
                    return val;
                }
                set { SetField(value); }
            }
            
            public void Set(QuickFix.Fields.NoMDEntries val) 
            { 
                this.noMDEntries = val;
            }
            
            public QuickFix.Fields.NoMDEntries Get(QuickFix.Fields.NoMDEntries val) 
            { 
                GetField(val);
                return val;
            }
            
            public bool IsSet(QuickFix.Fields.NoMDEntries val) 
            { 
                return IsSetNoMDEntries();
            }
            
            public bool IsSetNoMDEntries() 
            { 
                return IsSetField(Tags.NoMDEntries);
            }
            public class NoMDEntries : Group
            {
                public NoMDEntries() 
                  :base( Tags.NoMDEntries, Tags.MDUpdateAction, fieldOrder)
                {
                }
                public static int[] fieldOrder = {Tags.MDUpdateAction, Tags.DeleteReason, Tags.MDEntryType, Tags.MDEntryID, Tags.MDEntryRefID, Tags.Symbol, Tags.SymbolSfx, Tags.SecurityID, Tags.IDSource, Tags.SecurityType, Tags.MaturityMonthYear, Tags.MaturityDay, Tags.PutOrCall, Tags.StrikePrice, Tags.OptAttribute, Tags.ContractMultiplier, Tags.CouponRate, Tags.SecurityExchange, Tags.Issuer, Tags.EncodedIssuerLen, Tags.EncodedIssuer, Tags.SecurityDesc, Tags.EncodedSecurityDescLen, Tags.EncodedSecurityDesc, Tags.FinancialStatus, Tags.CorporateAction, Tags.MDEntryPx, Tags.Currency, Tags.MDEntrySize, Tags.MDEntryDate, Tags.MDEntryTime, Tags.TickDirection, Tags.MDMkt, Tags.TradingSessionID, Tags.QuoteCondition, Tags.TradeCondition, Tags.MDEntryOriginator, Tags.LocationID, Tags.DeskID, Tags.OpenCloseSettleFlag, Tags.TimeInForce, Tags.ExpireDate, Tags.ExpireTime, Tags.MinQty, Tags.ExecInst, Tags.SellerDays, Tags.OrderID, Tags.QuoteEntryID, Tags.MDEntryBuyer, Tags.MDEntrySeller, Tags.NumberOfOrders, Tags.MDEntryPositionNo, Tags.TotalVolumeTraded, Tags.Text, Tags.EncodedTextLen, Tags.EncodedText, 0};
                            public QuickFix.Fields.MDUpdateAction mDUpdateAction
                { 
                    get 
                    {
                        QuickFix.Fields.MDUpdateAction val = new QuickFix.Fields.MDUpdateAction();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDUpdateAction val) 
                { 
                    this.mDUpdateAction = val;
                }
                
                public QuickFix.Fields.MDUpdateAction Get(QuickFix.Fields.MDUpdateAction val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDUpdateAction val) 
                { 
                    return IsSetMDUpdateAction();
                }
                
                public bool IsSetMDUpdateAction() 
                { 
                    return IsSetField(Tags.MDUpdateAction);
                }
                public QuickFix.Fields.DeleteReason deleteReason
                { 
                    get 
                    {
                        QuickFix.Fields.DeleteReason val = new QuickFix.Fields.DeleteReason();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DeleteReason val) 
                { 
                    this.deleteReason = val;
                }
                
                public QuickFix.Fields.DeleteReason Get(QuickFix.Fields.DeleteReason val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DeleteReason val) 
                { 
                    return IsSetDeleteReason();
                }
                
                public bool IsSetDeleteReason() 
                { 
                    return IsSetField(Tags.DeleteReason);
                }
                public QuickFix.Fields.MDEntryType mDEntryType
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryType val = new QuickFix.Fields.MDEntryType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryType val) 
                { 
                    this.mDEntryType = val;
                }
                
                public QuickFix.Fields.MDEntryType Get(QuickFix.Fields.MDEntryType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryType val) 
                { 
                    return IsSetMDEntryType();
                }
                
                public bool IsSetMDEntryType() 
                { 
                    return IsSetField(Tags.MDEntryType);
                }
                public QuickFix.Fields.MDEntryID mDEntryID
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryID val = new QuickFix.Fields.MDEntryID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryID val) 
                { 
                    this.mDEntryID = val;
                }
                
                public QuickFix.Fields.MDEntryID Get(QuickFix.Fields.MDEntryID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryID val) 
                { 
                    return IsSetMDEntryID();
                }
                
                public bool IsSetMDEntryID() 
                { 
                    return IsSetField(Tags.MDEntryID);
                }
                public QuickFix.Fields.MDEntryRefID mDEntryRefID
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryRefID val = new QuickFix.Fields.MDEntryRefID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryRefID val) 
                { 
                    this.mDEntryRefID = val;
                }
                
                public QuickFix.Fields.MDEntryRefID Get(QuickFix.Fields.MDEntryRefID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryRefID val) 
                { 
                    return IsSetMDEntryRefID();
                }
                
                public bool IsSetMDEntryRefID() 
                { 
                    return IsSetField(Tags.MDEntryRefID);
                }
                public QuickFix.Fields.Symbol symbol
                { 
                    get 
                    {
                        QuickFix.Fields.Symbol val = new QuickFix.Fields.Symbol();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Symbol val) 
                { 
                    this.symbol = val;
                }
                
                public QuickFix.Fields.Symbol Get(QuickFix.Fields.Symbol val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Symbol val) 
                { 
                    return IsSetSymbol();
                }
                
                public bool IsSetSymbol() 
                { 
                    return IsSetField(Tags.Symbol);
                }
                public QuickFix.Fields.SymbolSfx symbolSfx
                { 
                    get 
                    {
                        QuickFix.Fields.SymbolSfx val = new QuickFix.Fields.SymbolSfx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SymbolSfx val) 
                { 
                    this.symbolSfx = val;
                }
                
                public QuickFix.Fields.SymbolSfx Get(QuickFix.Fields.SymbolSfx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SymbolSfx val) 
                { 
                    return IsSetSymbolSfx();
                }
                
                public bool IsSetSymbolSfx() 
                { 
                    return IsSetField(Tags.SymbolSfx);
                }
                public QuickFix.Fields.SecurityID securityID
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityID val = new QuickFix.Fields.SecurityID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityID val) 
                { 
                    this.securityID = val;
                }
                
                public QuickFix.Fields.SecurityID Get(QuickFix.Fields.SecurityID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityID val) 
                { 
                    return IsSetSecurityID();
                }
                
                public bool IsSetSecurityID() 
                { 
                    return IsSetField(Tags.SecurityID);
                }
                public QuickFix.Fields.IDSource iDSource
                { 
                    get 
                    {
                        QuickFix.Fields.IDSource val = new QuickFix.Fields.IDSource();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.IDSource val) 
                { 
                    this.iDSource = val;
                }
                
                public QuickFix.Fields.IDSource Get(QuickFix.Fields.IDSource val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.IDSource val) 
                { 
                    return IsSetIDSource();
                }
                
                public bool IsSetIDSource() 
                { 
                    return IsSetField(Tags.IDSource);
                }
                public QuickFix.Fields.SecurityType securityType
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityType val = new QuickFix.Fields.SecurityType();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityType val) 
                { 
                    this.securityType = val;
                }
                
                public QuickFix.Fields.SecurityType Get(QuickFix.Fields.SecurityType val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityType val) 
                { 
                    return IsSetSecurityType();
                }
                
                public bool IsSetSecurityType() 
                { 
                    return IsSetField(Tags.SecurityType);
                }
                public QuickFix.Fields.MaturityMonthYear maturityMonthYear
                { 
                    get 
                    {
                        QuickFix.Fields.MaturityMonthYear val = new QuickFix.Fields.MaturityMonthYear();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    this.maturityMonthYear = val;
                }
                
                public QuickFix.Fields.MaturityMonthYear Get(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaturityMonthYear val) 
                { 
                    return IsSetMaturityMonthYear();
                }
                
                public bool IsSetMaturityMonthYear() 
                { 
                    return IsSetField(Tags.MaturityMonthYear);
                }
                public QuickFix.Fields.MaturityDay maturityDay
                { 
                    get 
                    {
                        QuickFix.Fields.MaturityDay val = new QuickFix.Fields.MaturityDay();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MaturityDay val) 
                { 
                    this.maturityDay = val;
                }
                
                public QuickFix.Fields.MaturityDay Get(QuickFix.Fields.MaturityDay val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MaturityDay val) 
                { 
                    return IsSetMaturityDay();
                }
                
                public bool IsSetMaturityDay() 
                { 
                    return IsSetField(Tags.MaturityDay);
                }
                public QuickFix.Fields.PutOrCall putOrCall
                { 
                    get 
                    {
                        QuickFix.Fields.PutOrCall val = new QuickFix.Fields.PutOrCall();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.PutOrCall val) 
                { 
                    this.putOrCall = val;
                }
                
                public QuickFix.Fields.PutOrCall Get(QuickFix.Fields.PutOrCall val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.PutOrCall val) 
                { 
                    return IsSetPutOrCall();
                }
                
                public bool IsSetPutOrCall() 
                { 
                    return IsSetField(Tags.PutOrCall);
                }
                public QuickFix.Fields.StrikePrice strikePrice
                { 
                    get 
                    {
                        QuickFix.Fields.StrikePrice val = new QuickFix.Fields.StrikePrice();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.StrikePrice val) 
                { 
                    this.strikePrice = val;
                }
                
                public QuickFix.Fields.StrikePrice Get(QuickFix.Fields.StrikePrice val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.StrikePrice val) 
                { 
                    return IsSetStrikePrice();
                }
                
                public bool IsSetStrikePrice() 
                { 
                    return IsSetField(Tags.StrikePrice);
                }
                public QuickFix.Fields.OptAttribute optAttribute
                { 
                    get 
                    {
                        QuickFix.Fields.OptAttribute val = new QuickFix.Fields.OptAttribute();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OptAttribute val) 
                { 
                    this.optAttribute = val;
                }
                
                public QuickFix.Fields.OptAttribute Get(QuickFix.Fields.OptAttribute val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OptAttribute val) 
                { 
                    return IsSetOptAttribute();
                }
                
                public bool IsSetOptAttribute() 
                { 
                    return IsSetField(Tags.OptAttribute);
                }
                public QuickFix.Fields.ContractMultiplier contractMultiplier
                { 
                    get 
                    {
                        QuickFix.Fields.ContractMultiplier val = new QuickFix.Fields.ContractMultiplier();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ContractMultiplier val) 
                { 
                    this.contractMultiplier = val;
                }
                
                public QuickFix.Fields.ContractMultiplier Get(QuickFix.Fields.ContractMultiplier val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ContractMultiplier val) 
                { 
                    return IsSetContractMultiplier();
                }
                
                public bool IsSetContractMultiplier() 
                { 
                    return IsSetField(Tags.ContractMultiplier);
                }
                public QuickFix.Fields.CouponRate couponRate
                { 
                    get 
                    {
                        QuickFix.Fields.CouponRate val = new QuickFix.Fields.CouponRate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CouponRate val) 
                { 
                    this.couponRate = val;
                }
                
                public QuickFix.Fields.CouponRate Get(QuickFix.Fields.CouponRate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CouponRate val) 
                { 
                    return IsSetCouponRate();
                }
                
                public bool IsSetCouponRate() 
                { 
                    return IsSetField(Tags.CouponRate);
                }
                public QuickFix.Fields.SecurityExchange securityExchange
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityExchange val = new QuickFix.Fields.SecurityExchange();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityExchange val) 
                { 
                    this.securityExchange = val;
                }
                
                public QuickFix.Fields.SecurityExchange Get(QuickFix.Fields.SecurityExchange val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityExchange val) 
                { 
                    return IsSetSecurityExchange();
                }
                
                public bool IsSetSecurityExchange() 
                { 
                    return IsSetField(Tags.SecurityExchange);
                }
                public QuickFix.Fields.Issuer issuer
                { 
                    get 
                    {
                        QuickFix.Fields.Issuer val = new QuickFix.Fields.Issuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Issuer val) 
                { 
                    this.issuer = val;
                }
                
                public QuickFix.Fields.Issuer Get(QuickFix.Fields.Issuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Issuer val) 
                { 
                    return IsSetIssuer();
                }
                
                public bool IsSetIssuer() 
                { 
                    return IsSetField(Tags.Issuer);
                }
                public QuickFix.Fields.EncodedIssuerLen encodedIssuerLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedIssuerLen val = new QuickFix.Fields.EncodedIssuerLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedIssuerLen val) 
                { 
                    this.encodedIssuerLen = val;
                }
                
                public QuickFix.Fields.EncodedIssuerLen Get(QuickFix.Fields.EncodedIssuerLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedIssuerLen val) 
                { 
                    return IsSetEncodedIssuerLen();
                }
                
                public bool IsSetEncodedIssuerLen() 
                { 
                    return IsSetField(Tags.EncodedIssuerLen);
                }
                public QuickFix.Fields.EncodedIssuer encodedIssuer
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedIssuer val = new QuickFix.Fields.EncodedIssuer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedIssuer val) 
                { 
                    this.encodedIssuer = val;
                }
                
                public QuickFix.Fields.EncodedIssuer Get(QuickFix.Fields.EncodedIssuer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedIssuer val) 
                { 
                    return IsSetEncodedIssuer();
                }
                
                public bool IsSetEncodedIssuer() 
                { 
                    return IsSetField(Tags.EncodedIssuer);
                }
                public QuickFix.Fields.SecurityDesc securityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.SecurityDesc val = new QuickFix.Fields.SecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SecurityDesc val) 
                { 
                    this.securityDesc = val;
                }
                
                public QuickFix.Fields.SecurityDesc Get(QuickFix.Fields.SecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SecurityDesc val) 
                { 
                    return IsSetSecurityDesc();
                }
                
                public bool IsSetSecurityDesc() 
                { 
                    return IsSetField(Tags.SecurityDesc);
                }
                public QuickFix.Fields.EncodedSecurityDescLen encodedSecurityDescLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedSecurityDescLen val = new QuickFix.Fields.EncodedSecurityDescLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedSecurityDescLen val) 
                { 
                    this.encodedSecurityDescLen = val;
                }
                
                public QuickFix.Fields.EncodedSecurityDescLen Get(QuickFix.Fields.EncodedSecurityDescLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedSecurityDescLen val) 
                { 
                    return IsSetEncodedSecurityDescLen();
                }
                
                public bool IsSetEncodedSecurityDescLen() 
                { 
                    return IsSetField(Tags.EncodedSecurityDescLen);
                }
                public QuickFix.Fields.EncodedSecurityDesc encodedSecurityDesc
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedSecurityDesc val = new QuickFix.Fields.EncodedSecurityDesc();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedSecurityDesc val) 
                { 
                    this.encodedSecurityDesc = val;
                }
                
                public QuickFix.Fields.EncodedSecurityDesc Get(QuickFix.Fields.EncodedSecurityDesc val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedSecurityDesc val) 
                { 
                    return IsSetEncodedSecurityDesc();
                }
                
                public bool IsSetEncodedSecurityDesc() 
                { 
                    return IsSetField(Tags.EncodedSecurityDesc);
                }
                public QuickFix.Fields.FinancialStatus financialStatus
                { 
                    get 
                    {
                        QuickFix.Fields.FinancialStatus val = new QuickFix.Fields.FinancialStatus();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.FinancialStatus val) 
                { 
                    this.financialStatus = val;
                }
                
                public QuickFix.Fields.FinancialStatus Get(QuickFix.Fields.FinancialStatus val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.FinancialStatus val) 
                { 
                    return IsSetFinancialStatus();
                }
                
                public bool IsSetFinancialStatus() 
                { 
                    return IsSetField(Tags.FinancialStatus);
                }
                public QuickFix.Fields.CorporateAction corporateAction
                { 
                    get 
                    {
                        QuickFix.Fields.CorporateAction val = new QuickFix.Fields.CorporateAction();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.CorporateAction val) 
                { 
                    this.corporateAction = val;
                }
                
                public QuickFix.Fields.CorporateAction Get(QuickFix.Fields.CorporateAction val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.CorporateAction val) 
                { 
                    return IsSetCorporateAction();
                }
                
                public bool IsSetCorporateAction() 
                { 
                    return IsSetField(Tags.CorporateAction);
                }
                public QuickFix.Fields.MDEntryPx mDEntryPx
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryPx val = new QuickFix.Fields.MDEntryPx();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryPx val) 
                { 
                    this.mDEntryPx = val;
                }
                
                public QuickFix.Fields.MDEntryPx Get(QuickFix.Fields.MDEntryPx val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryPx val) 
                { 
                    return IsSetMDEntryPx();
                }
                
                public bool IsSetMDEntryPx() 
                { 
                    return IsSetField(Tags.MDEntryPx);
                }
                public QuickFix.Fields.Currency currency
                { 
                    get 
                    {
                        QuickFix.Fields.Currency val = new QuickFix.Fields.Currency();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Currency val) 
                { 
                    this.currency = val;
                }
                
                public QuickFix.Fields.Currency Get(QuickFix.Fields.Currency val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Currency val) 
                { 
                    return IsSetCurrency();
                }
                
                public bool IsSetCurrency() 
                { 
                    return IsSetField(Tags.Currency);
                }
                public QuickFix.Fields.MDEntrySize mDEntrySize
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntrySize val = new QuickFix.Fields.MDEntrySize();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntrySize val) 
                { 
                    this.mDEntrySize = val;
                }
                
                public QuickFix.Fields.MDEntrySize Get(QuickFix.Fields.MDEntrySize val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntrySize val) 
                { 
                    return IsSetMDEntrySize();
                }
                
                public bool IsSetMDEntrySize() 
                { 
                    return IsSetField(Tags.MDEntrySize);
                }
                public QuickFix.Fields.MDEntryDate mDEntryDate
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryDate val = new QuickFix.Fields.MDEntryDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryDate val) 
                { 
                    this.mDEntryDate = val;
                }
                
                public QuickFix.Fields.MDEntryDate Get(QuickFix.Fields.MDEntryDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryDate val) 
                { 
                    return IsSetMDEntryDate();
                }
                
                public bool IsSetMDEntryDate() 
                { 
                    return IsSetField(Tags.MDEntryDate);
                }
                public QuickFix.Fields.MDEntryTime mDEntryTime
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryTime val = new QuickFix.Fields.MDEntryTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryTime val) 
                { 
                    this.mDEntryTime = val;
                }
                
                public QuickFix.Fields.MDEntryTime Get(QuickFix.Fields.MDEntryTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryTime val) 
                { 
                    return IsSetMDEntryTime();
                }
                
                public bool IsSetMDEntryTime() 
                { 
                    return IsSetField(Tags.MDEntryTime);
                }
                public QuickFix.Fields.TickDirection tickDirection
                { 
                    get 
                    {
                        QuickFix.Fields.TickDirection val = new QuickFix.Fields.TickDirection();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TickDirection val) 
                { 
                    this.tickDirection = val;
                }
                
                public QuickFix.Fields.TickDirection Get(QuickFix.Fields.TickDirection val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TickDirection val) 
                { 
                    return IsSetTickDirection();
                }
                
                public bool IsSetTickDirection() 
                { 
                    return IsSetField(Tags.TickDirection);
                }
                public QuickFix.Fields.MDMkt mDMkt
                { 
                    get 
                    {
                        QuickFix.Fields.MDMkt val = new QuickFix.Fields.MDMkt();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDMkt val) 
                { 
                    this.mDMkt = val;
                }
                
                public QuickFix.Fields.MDMkt Get(QuickFix.Fields.MDMkt val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDMkt val) 
                { 
                    return IsSetMDMkt();
                }
                
                public bool IsSetMDMkt() 
                { 
                    return IsSetField(Tags.MDMkt);
                }
                public QuickFix.Fields.TradingSessionID tradingSessionID
                { 
                    get 
                    {
                        QuickFix.Fields.TradingSessionID val = new QuickFix.Fields.TradingSessionID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradingSessionID val) 
                { 
                    this.tradingSessionID = val;
                }
                
                public QuickFix.Fields.TradingSessionID Get(QuickFix.Fields.TradingSessionID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradingSessionID val) 
                { 
                    return IsSetTradingSessionID();
                }
                
                public bool IsSetTradingSessionID() 
                { 
                    return IsSetField(Tags.TradingSessionID);
                }
                public QuickFix.Fields.QuoteCondition quoteCondition
                { 
                    get 
                    {
                        QuickFix.Fields.QuoteCondition val = new QuickFix.Fields.QuoteCondition();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuoteCondition val) 
                { 
                    this.quoteCondition = val;
                }
                
                public QuickFix.Fields.QuoteCondition Get(QuickFix.Fields.QuoteCondition val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuoteCondition val) 
                { 
                    return IsSetQuoteCondition();
                }
                
                public bool IsSetQuoteCondition() 
                { 
                    return IsSetField(Tags.QuoteCondition);
                }
                public QuickFix.Fields.TradeCondition tradeCondition
                { 
                    get 
                    {
                        QuickFix.Fields.TradeCondition val = new QuickFix.Fields.TradeCondition();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TradeCondition val) 
                { 
                    this.tradeCondition = val;
                }
                
                public QuickFix.Fields.TradeCondition Get(QuickFix.Fields.TradeCondition val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TradeCondition val) 
                { 
                    return IsSetTradeCondition();
                }
                
                public bool IsSetTradeCondition() 
                { 
                    return IsSetField(Tags.TradeCondition);
                }
                public QuickFix.Fields.MDEntryOriginator mDEntryOriginator
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryOriginator val = new QuickFix.Fields.MDEntryOriginator();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryOriginator val) 
                { 
                    this.mDEntryOriginator = val;
                }
                
                public QuickFix.Fields.MDEntryOriginator Get(QuickFix.Fields.MDEntryOriginator val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryOriginator val) 
                { 
                    return IsSetMDEntryOriginator();
                }
                
                public bool IsSetMDEntryOriginator() 
                { 
                    return IsSetField(Tags.MDEntryOriginator);
                }
                public QuickFix.Fields.LocationID locationID
                { 
                    get 
                    {
                        QuickFix.Fields.LocationID val = new QuickFix.Fields.LocationID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.LocationID val) 
                { 
                    this.locationID = val;
                }
                
                public QuickFix.Fields.LocationID Get(QuickFix.Fields.LocationID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.LocationID val) 
                { 
                    return IsSetLocationID();
                }
                
                public bool IsSetLocationID() 
                { 
                    return IsSetField(Tags.LocationID);
                }
                public QuickFix.Fields.DeskID deskID
                { 
                    get 
                    {
                        QuickFix.Fields.DeskID val = new QuickFix.Fields.DeskID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.DeskID val) 
                { 
                    this.deskID = val;
                }
                
                public QuickFix.Fields.DeskID Get(QuickFix.Fields.DeskID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.DeskID val) 
                { 
                    return IsSetDeskID();
                }
                
                public bool IsSetDeskID() 
                { 
                    return IsSetField(Tags.DeskID);
                }
                public QuickFix.Fields.OpenCloseSettleFlag openCloseSettleFlag
                { 
                    get 
                    {
                        QuickFix.Fields.OpenCloseSettleFlag val = new QuickFix.Fields.OpenCloseSettleFlag();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OpenCloseSettleFlag val) 
                { 
                    this.openCloseSettleFlag = val;
                }
                
                public QuickFix.Fields.OpenCloseSettleFlag Get(QuickFix.Fields.OpenCloseSettleFlag val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OpenCloseSettleFlag val) 
                { 
                    return IsSetOpenCloseSettleFlag();
                }
                
                public bool IsSetOpenCloseSettleFlag() 
                { 
                    return IsSetField(Tags.OpenCloseSettleFlag);
                }
                public QuickFix.Fields.TimeInForce timeInForce
                { 
                    get 
                    {
                        QuickFix.Fields.TimeInForce val = new QuickFix.Fields.TimeInForce();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TimeInForce val) 
                { 
                    this.timeInForce = val;
                }
                
                public QuickFix.Fields.TimeInForce Get(QuickFix.Fields.TimeInForce val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TimeInForce val) 
                { 
                    return IsSetTimeInForce();
                }
                
                public bool IsSetTimeInForce() 
                { 
                    return IsSetField(Tags.TimeInForce);
                }
                public QuickFix.Fields.ExpireDate expireDate
                { 
                    get 
                    {
                        QuickFix.Fields.ExpireDate val = new QuickFix.Fields.ExpireDate();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExpireDate val) 
                { 
                    this.expireDate = val;
                }
                
                public QuickFix.Fields.ExpireDate Get(QuickFix.Fields.ExpireDate val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExpireDate val) 
                { 
                    return IsSetExpireDate();
                }
                
                public bool IsSetExpireDate() 
                { 
                    return IsSetField(Tags.ExpireDate);
                }
                public QuickFix.Fields.ExpireTime expireTime
                { 
                    get 
                    {
                        QuickFix.Fields.ExpireTime val = new QuickFix.Fields.ExpireTime();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExpireTime val) 
                { 
                    this.expireTime = val;
                }
                
                public QuickFix.Fields.ExpireTime Get(QuickFix.Fields.ExpireTime val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExpireTime val) 
                { 
                    return IsSetExpireTime();
                }
                
                public bool IsSetExpireTime() 
                { 
                    return IsSetField(Tags.ExpireTime);
                }
                public QuickFix.Fields.MinQty minQty
                { 
                    get 
                    {
                        QuickFix.Fields.MinQty val = new QuickFix.Fields.MinQty();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MinQty val) 
                { 
                    this.minQty = val;
                }
                
                public QuickFix.Fields.MinQty Get(QuickFix.Fields.MinQty val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MinQty val) 
                { 
                    return IsSetMinQty();
                }
                
                public bool IsSetMinQty() 
                { 
                    return IsSetField(Tags.MinQty);
                }
                public QuickFix.Fields.ExecInst execInst
                { 
                    get 
                    {
                        QuickFix.Fields.ExecInst val = new QuickFix.Fields.ExecInst();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.ExecInst val) 
                { 
                    this.execInst = val;
                }
                
                public QuickFix.Fields.ExecInst Get(QuickFix.Fields.ExecInst val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.ExecInst val) 
                { 
                    return IsSetExecInst();
                }
                
                public bool IsSetExecInst() 
                { 
                    return IsSetField(Tags.ExecInst);
                }
                public QuickFix.Fields.SellerDays sellerDays
                { 
                    get 
                    {
                        QuickFix.Fields.SellerDays val = new QuickFix.Fields.SellerDays();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.SellerDays val) 
                { 
                    this.sellerDays = val;
                }
                
                public QuickFix.Fields.SellerDays Get(QuickFix.Fields.SellerDays val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.SellerDays val) 
                { 
                    return IsSetSellerDays();
                }
                
                public bool IsSetSellerDays() 
                { 
                    return IsSetField(Tags.SellerDays);
                }
                public QuickFix.Fields.OrderID orderID
                { 
                    get 
                    {
                        QuickFix.Fields.OrderID val = new QuickFix.Fields.OrderID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.OrderID val) 
                { 
                    this.orderID = val;
                }
                
                public QuickFix.Fields.OrderID Get(QuickFix.Fields.OrderID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.OrderID val) 
                { 
                    return IsSetOrderID();
                }
                
                public bool IsSetOrderID() 
                { 
                    return IsSetField(Tags.OrderID);
                }
                public QuickFix.Fields.QuoteEntryID quoteEntryID
                { 
                    get 
                    {
                        QuickFix.Fields.QuoteEntryID val = new QuickFix.Fields.QuoteEntryID();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.QuoteEntryID val) 
                { 
                    this.quoteEntryID = val;
                }
                
                public QuickFix.Fields.QuoteEntryID Get(QuickFix.Fields.QuoteEntryID val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.QuoteEntryID val) 
                { 
                    return IsSetQuoteEntryID();
                }
                
                public bool IsSetQuoteEntryID() 
                { 
                    return IsSetField(Tags.QuoteEntryID);
                }
                public QuickFix.Fields.MDEntryBuyer mDEntryBuyer
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryBuyer val = new QuickFix.Fields.MDEntryBuyer();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryBuyer val) 
                { 
                    this.mDEntryBuyer = val;
                }
                
                public QuickFix.Fields.MDEntryBuyer Get(QuickFix.Fields.MDEntryBuyer val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryBuyer val) 
                { 
                    return IsSetMDEntryBuyer();
                }
                
                public bool IsSetMDEntryBuyer() 
                { 
                    return IsSetField(Tags.MDEntryBuyer);
                }
                public QuickFix.Fields.MDEntrySeller mDEntrySeller
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntrySeller val = new QuickFix.Fields.MDEntrySeller();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntrySeller val) 
                { 
                    this.mDEntrySeller = val;
                }
                
                public QuickFix.Fields.MDEntrySeller Get(QuickFix.Fields.MDEntrySeller val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntrySeller val) 
                { 
                    return IsSetMDEntrySeller();
                }
                
                public bool IsSetMDEntrySeller() 
                { 
                    return IsSetField(Tags.MDEntrySeller);
                }
                public QuickFix.Fields.NumberOfOrders numberOfOrders
                { 
                    get 
                    {
                        QuickFix.Fields.NumberOfOrders val = new QuickFix.Fields.NumberOfOrders();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.NumberOfOrders val) 
                { 
                    this.numberOfOrders = val;
                }
                
                public QuickFix.Fields.NumberOfOrders Get(QuickFix.Fields.NumberOfOrders val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.NumberOfOrders val) 
                { 
                    return IsSetNumberOfOrders();
                }
                
                public bool IsSetNumberOfOrders() 
                { 
                    return IsSetField(Tags.NumberOfOrders);
                }
                public QuickFix.Fields.MDEntryPositionNo mDEntryPositionNo
                { 
                    get 
                    {
                        QuickFix.Fields.MDEntryPositionNo val = new QuickFix.Fields.MDEntryPositionNo();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.MDEntryPositionNo val) 
                { 
                    this.mDEntryPositionNo = val;
                }
                
                public QuickFix.Fields.MDEntryPositionNo Get(QuickFix.Fields.MDEntryPositionNo val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.MDEntryPositionNo val) 
                { 
                    return IsSetMDEntryPositionNo();
                }
                
                public bool IsSetMDEntryPositionNo() 
                { 
                    return IsSetField(Tags.MDEntryPositionNo);
                }
                public QuickFix.Fields.TotalVolumeTraded totalVolumeTraded
                { 
                    get 
                    {
                        QuickFix.Fields.TotalVolumeTraded val = new QuickFix.Fields.TotalVolumeTraded();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.TotalVolumeTraded val) 
                { 
                    this.totalVolumeTraded = val;
                }
                
                public QuickFix.Fields.TotalVolumeTraded Get(QuickFix.Fields.TotalVolumeTraded val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.TotalVolumeTraded val) 
                { 
                    return IsSetTotalVolumeTraded();
                }
                
                public bool IsSetTotalVolumeTraded() 
                { 
                    return IsSetField(Tags.TotalVolumeTraded);
                }
                public QuickFix.Fields.Text text
                { 
                    get 
                    {
                        QuickFix.Fields.Text val = new QuickFix.Fields.Text();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.Text val) 
                { 
                    this.text = val;
                }
                
                public QuickFix.Fields.Text Get(QuickFix.Fields.Text val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.Text val) 
                { 
                    return IsSetText();
                }
                
                public bool IsSetText() 
                { 
                    return IsSetField(Tags.Text);
                }
                public QuickFix.Fields.EncodedTextLen encodedTextLen
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedTextLen val = new QuickFix.Fields.EncodedTextLen();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedTextLen val) 
                { 
                    this.encodedTextLen = val;
                }
                
                public QuickFix.Fields.EncodedTextLen Get(QuickFix.Fields.EncodedTextLen val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedTextLen val) 
                { 
                    return IsSetEncodedTextLen();
                }
                
                public bool IsSetEncodedTextLen() 
                { 
                    return IsSetField(Tags.EncodedTextLen);
                }
                public QuickFix.Fields.EncodedText encodedText
                { 
                    get 
                    {
                        QuickFix.Fields.EncodedText val = new QuickFix.Fields.EncodedText();
                        GetField(val);
                        return val;
                    }
                    set { SetField(value); }
                }
                
                public void Set(QuickFix.Fields.EncodedText val) 
                { 
                    this.encodedText = val;
                }
                
                public QuickFix.Fields.EncodedText Get(QuickFix.Fields.EncodedText val) 
                { 
                    GetField(val);
                    return val;
                }
                
                public bool IsSet(QuickFix.Fields.EncodedText val) 
                { 
                    return IsSetEncodedText();
                }
                
                public bool IsSetEncodedText() 
                { 
                    return IsSetField(Tags.EncodedText);
                }
            
            }
        }
    }
}
