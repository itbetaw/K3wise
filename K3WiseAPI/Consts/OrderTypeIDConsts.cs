using System;
using System.Collections.Generic;
using System.Text;

namespace Middleware.Target.Core.Models.K3Wise.K3WiseAPI.Consts
{
    /// <summary>
    /// 单据类型ID
    /// </summary>
    public class OrderTypeIDConsts
    {
        #region 供应链模块

        public const string 外购入库 = "Purchase_Receipt";
        public const string 库存查询 = "InventoryReport";
        public const string 受托加工材料入库单 = "OEM_Material_Receipt";
        public const string 销售出库单 = "Sales_Delivery";
        public const string 委外加工出库单 = "Subcontract_Delivery";
        public const string 采购订单 = "PO";
        public const string 销售订单 = "SO";
        public const string 委外加工入库单 = "Subcontract_Receipt";
        public const string 产品入库 = "ProductReceipt";
        public const string 生产领料单 = "PickList";
        public const string 发货通知单 = "Delivery_Notice";
        public const string 其他入库单 = "Miscellaneous_Receipt";
        public const string 其他出库单 = "Miscellaneous_Delivery";
        public const string 调拨单 = "Transfer";
        public const string 退货通知单 = "Goods_Return_Notice";
        public const string 收料通知请检单 = "Material_Receipt_Notice";
        public const string 盘盈入库单 = "Inventory_Gain";
        public const string 盘亏毁损单 = "Inventory_Loss";
        public const string 采购申请单 = "Purchase_Requisition";

        #endregion

        #region 基础资料

        public const string 科目 = "Account";
        public const string 科目组 = "AccountGroup";
        public const string 币别 = "Currency";
        public const string 凭证字 = "VoucherGroup";
        public const string 计量单位 = "MeasureUnit";
        public const string 计量单位组 = "MeasureUnitGroup";
        public const string 客户 = "Customer";
        public const string 客户组 = "CustomerGroup";
        public const string 部门 = "Department";
        public const string 部门组 = "DepartmentGroup";
        public const string 职员 = "Employee";
        public const string 职员组 = "EmployeeGroup";
        public const string 物料 = "Material";
        public const string 物料组 = "MaterialGroup";
        public const string 仓库 = "Stock";
        public const string 仓库组 = "StockGroup";
        public const string 供应商 = "Supplier";
        public const string 供应商组 = "SupplierGroup";
        public const string 仓位 = "StockPlace";
        public const string 仓位组 = "StockPlaceGroup";
        public const string 辅助资料 = "SubMessage";
        public const string 辅助资料类别 = "SubMessageType";
        #endregion

        #region 财务

        public const string 凭证 = "VoucherData";

        #endregion
    }
}
