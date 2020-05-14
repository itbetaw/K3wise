using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.FormOperationResult
{
    public class GetTemplateResult
    {
        public Data Data { get; set; }
    }

    public class Data
    {
        public Page1[] Page1 { get; set; }
        public Page2[] Page2 { get; set; }
    }

    public class Page1
    {
        public string FCancellation { get; set; }
        public string FClassTypeID { get; set; }
        public string FEnterpriseID { get; set; }
        public Fheadselfs0158 FHeadSelfS0158 { get; set; }
        public string FHeadSelfS0159 { get; set; }
        public string FHeadSelfS0160 { get; set; }
        public string FHeadSelfS0161 { get; set; }
        public string FSendStatus { get; set; }
        public string FStatus { get; set; }
        public string Fdate { get; set; }
        public Fcustid FCustID { get; set; }
        public string FSettleDate { get; set; }
        public string FImport { get; set; }
        public Fareaps FAreaPS { get; set; }
        public Fsettleid FSettleID { get; set; }
        public Frelatebrid FRelateBrID { get; set; }
        public string FPOOrdBillNo { get; set; }
        public Fsalestyle FSaleStyle { get; set; }
        public string FTransitAheadTime { get; set; }
        public Fbrid FBrID { get; set; }
        public string FTranType { get; set; }
        public Ffetchstyle FFetchStyle { get; set; }
        public string FFetchAdd { get; set; }
        public string FExplanation { get; set; }
        public Fcurrencyid FCurrencyID { get; set; }
        public string FSelTranType { get; set; }
        public string FSelBillNo { get; set; }
        public string FExchangeRate { get; set; }
        public string FBillNo { get; set; }
        public string FMultiCheckStatus { get; set; }
        public Fexchangeratetype FExchangeRateType { get; set; }
        public Fcustaddress FCustAddress { get; set; }
        public Fplancategory FPlanCategory { get; set; }
        public Fcheckerid FCheckerID { get; set; }
        public string FCheckDate { get; set; }
        public Fdeptid FDeptID { get; set; }
        public Fempid FEmpID { get; set; }
        public Fmangerid FMangerID { get; set; }
        public Fbillerid FBillerID { get; set; }
        public string FManageType { get; set; }
        public string FValidaterName { get; set; }
        public string FSysStatus { get; set; }
        public Fconsignee FConsignee { get; set; }
        public string FVersionNo { get; set; }
        public string FChangeDate { get; set; }
        public Fchangeuser FChangeUser { get; set; }
        public string FChangeCauses { get; set; }
        public string FChangeMark { get; set; }
    }

    public class Fheadselfs0158
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fcustid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fareaps
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fsettleid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Frelatebrid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fsalestyle
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fbrid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Ffetchstyle
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fcurrencyid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fexchangeratetype
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fcustaddress
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fplancategory
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fcheckerid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fdeptid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fempid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fmangerid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fbillerid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fconsignee
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fchangeuser
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Page2
    {
        public string FEntryID2 { get; set; }
        public Fatpdeduct FATPDeduct { get; set; }
        public string FEntrySelfS0168 { get; set; }
        public string FEntrySelfS0169 { get; set; }
        public string FOutSourceEntryID { get; set; }
        public string FOutSourceInterID { get; set; }
        public string FOutSourceTranType { get; set; }
        public Fmapnumber FMapNumber { get; set; }
        public string FMapName { get; set; }
        public Fitemid FItemID { get; set; }
        public string FItemName { get; set; }
        public string FItemModel { get; set; }
        public Fauxpropid FAuxPropID { get; set; }
        public string FBaseUnit { get; set; }
        public string FQty { get; set; }
        public Funitid FUnitID { get; set; }
        public string Fauxqty { get; set; }
        public string FSecUnitID { get; set; }
        public string FSecCoefficient { get; set; }
        public string FSecQty { get; set; }
        public string Fauxprice { get; set; }
        public string FAuxTaxPrice { get; set; }
        public string Famount { get; set; }
        public string FCess { get; set; }
        public string FTaxRate { get; set; }
        public string FUniDiscount { get; set; }
        public string FTaxAmount { get; set; }
        public string FAuxPriceDiscount { get; set; }
        public string FTaxAmt { get; set; }
        public string FAllAmount { get; set; }
        public string FTranLeadTime { get; set; }
        public Finforecast FInForecast { get; set; }
        public string FDate1 { get; set; }
        public string Fnote { get; set; }
        public string FCommitQty { get; set; }
        public string FAuxCommitQty { get; set; }
        public string FSecCommitQty { get; set; }
        public string FSecStockQty { get; set; }
        public string FStockQty { get; set; }
        public string FAuxStockQty { get; set; }
        public Fplanmode FPlanMode { get; set; }
        public string FMTONo { get; set; }
        public Fbominterid FBomInterID { get; set; }
        public Fcostobjectid FCostObjectID { get; set; }
        public string FAdviceConsignDate { get; set; }
        public string FLockFlag { get; set; }
        public string FSourceBillNo { get; set; }
        public Fbomcategory FBOMCategory { get; set; }
        public string FSourceTranType { get; set; }
        public string FOrderBOMInterID { get; set; }
        public string FSourceInterId { get; set; }
        public string FSourceEntryID { get; set; }
        public Forderbomstatus FOrderBOMStatus { get; set; }
        public string FContractBillNo { get; set; }
        public string FContractInterID { get; set; }
        public string FContractEntryID { get; set; }
        public string FAuxQtyInvoice { get; set; }
        public string FSecInvoiceQty { get; set; }
        public string FQtyInvoice { get; set; }
        public string FSecCommitInstall { get; set; }
        public string FCommitInstall { get; set; }
        public string FAuxCommitInstall { get; set; }
        public string FAuxPropCls { get; set; }
        public string FAllStdAmount { get; set; }
        public string FMrpLockFlag { get; set; }
        public string FHaveMrp { get; set; }
        public string FReceiveAmountFor_Commit { get; set; }
        public string FOrderBillNo { get; set; }
        public string FOrderEntryID { get; set; }
    }

    public class Fatpdeduct
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fmapnumber
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fitemid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fauxpropid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Funitid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Finforecast
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fplanmode
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fbominterid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fcostobjectid
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Fbomcategory
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

    public class Forderbomstatus
    {
        public string FNumber { get; set; }
        public string FName { get; set; }
    }

}
