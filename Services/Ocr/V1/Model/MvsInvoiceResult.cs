using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ocr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MvsInvoiceResult 
    {

        /// <summary>
        /// 发票代码。 
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 发票号码。 
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 机打代码。 
        /// </summary>
        [JsonProperty("machine_printed_code", NullValueHandling = NullValueHandling.Ignore)]
        public string MachinePrintedCode { get; set; }

        /// <summary>
        /// 机打号码。 
        /// </summary>
        [JsonProperty("machine_printed_number", NullValueHandling = NullValueHandling.Ignore)]
        public string MachinePrintedNumber { get; set; }

        /// <summary>
        /// 开票日期。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 机器编号。 
        /// </summary>
        [JsonProperty("machine_number", NullValueHandling = NullValueHandling.Ignore)]
        public string MachineNumber { get; set; }

        /// <summary>
        /// 购买方名称、二手车买方单位/个人 
        /// </summary>
        [JsonProperty("buyer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerName { get; set; }

        /// <summary>
        /// 购买方身份证号码/组织机构代码。 
        /// </summary>
        [JsonProperty("buyer_organization_number", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerOrganizationNumber { get; set; }

        /// <summary>
        /// 购买方纳税人识别号、二手车买方单位代码/身份证号 
        /// </summary>
        [JsonProperty("buyer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerId { get; set; }

        /// <summary>
        /// 二手车买方单位/个人住址。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("buyer_address", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerAddress { get; set; }

        /// <summary>
        /// 二手车买方单位/个人电话。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("buyer_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerPhone { get; set; }

        /// <summary>
        /// 销货单位名称、二手车卖方单位/个人 
        /// </summary>
        [JsonProperty("seller_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerName { get; set; }

        /// <summary>
        /// 销售方电话、二手车卖方电话 
        /// </summary>
        [JsonProperty("seller_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerPhone { get; set; }

        /// <summary>
        /// 销售方纳税人识别号、二手车卖方单位代码/身份证号 
        /// </summary>
        [JsonProperty("seller_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerId { get; set; }

        /// <summary>
        /// 销售方账号。 
        /// </summary>
        [JsonProperty("seller_account", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerAccount { get; set; }

        /// <summary>
        /// 销售方地址、二手车卖方单位/个人地址 
        /// </summary>
        [JsonProperty("seller_address", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerAddress { get; set; }

        /// <summary>
        /// 二手车车牌照号。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("licence_plate_number", NullValueHandling = NullValueHandling.Ignore)]
        public string LicencePlateNumber { get; set; }

        /// <summary>
        /// 二手车登记证号。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("registration_number", NullValueHandling = NullValueHandling.Ignore)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// 二手车转入地车管所名称。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("dept_motor_vehicles", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptMotorVehicles { get; set; }

        /// <summary>
        /// 销售方开户行。 
        /// </summary>
        [JsonProperty("seller_bank", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerBank { get; set; }

        /// <summary>
        /// 车辆类型。 
        /// </summary>
        [JsonProperty("vehicle_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleType { get; set; }

        /// <summary>
        /// 厂牌型号。 
        /// </summary>
        [JsonProperty("brand_model", NullValueHandling = NullValueHandling.Ignore)]
        public string BrandModel { get; set; }

        /// <summary>
        /// 产地。 
        /// </summary>
        [JsonProperty("manufacturing_location", NullValueHandling = NullValueHandling.Ignore)]
        public string ManufacturingLocation { get; set; }

        /// <summary>
        /// 合格证号。 
        /// </summary>
        [JsonProperty("quality_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string QualityCertificate { get; set; }

        /// <summary>
        /// 进口证明书号。 
        /// </summary>
        [JsonProperty("import_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string ImportCertificate { get; set; }

        /// <summary>
        /// 商检单号。 
        /// </summary>
        [JsonProperty("inspection_number", NullValueHandling = NullValueHandling.Ignore)]
        public string InspectionNumber { get; set; }

        /// <summary>
        /// 发动机号码。 
        /// </summary>
        [JsonProperty("engine_number", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineNumber { get; set; }

        /// <summary>
        /// 车辆识别代号/车架号码。 
        /// </summary>
        [JsonProperty("vehicle_identification_number", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleIdentificationNumber { get; set; }

        /// <summary>
        /// 吨位。 
        /// </summary>
        [JsonProperty("tonnage", NullValueHandling = NullValueHandling.Ignore)]
        public string Tonnage { get; set; }

        /// <summary>
        /// 限乘人数。 
        /// </summary>
        [JsonProperty("seating_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string SeatingCapacity { get; set; }

        /// <summary>
        /// 主管税务机关。 
        /// </summary>
        [JsonProperty("tax_authority", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxAuthority { get; set; }

        /// <summary>
        /// 主管税务机关代码。 
        /// </summary>
        [JsonProperty("tax_authority_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxAuthorityCode { get; set; }

        /// <summary>
        /// 完税凭证号码。 
        /// </summary>
        [JsonProperty("tax_payment_receipt", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxPaymentReceipt { get; set; }

        /// <summary>
        /// 增值税税率或征收率。 
        /// </summary>
        [JsonProperty("tax_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxRate { get; set; }

        /// <summary>
        /// 增值税税额。 
        /// </summary>
        [JsonProperty("tax", NullValueHandling = NullValueHandling.Ignore)]
        public string Tax { get; set; }

        /// <summary>
        /// 不含税价。 
        /// </summary>
        [JsonProperty("tax_exclusive_price", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxExclusivePrice { get; set; }

        /// <summary>
        /// 价税合计、二手车车价合计（小写） 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public string Total { get; set; }

        /// <summary>
        /// 价税合计大写、二手车车价合计（大写） 
        /// </summary>
        [JsonProperty("total_chinese", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalChinese { get; set; }

        /// <summary>
        /// 税控码。 
        /// </summary>
        [JsonProperty("fiscal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FiscalCode { get; set; }

        /// <summary>
        /// 二手车经营拍卖单位名称。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("auction_org_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuctionOrgName { get; set; }

        /// <summary>
        /// 二手车经营拍卖单位地址。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("auction_org_address", NullValueHandling = NullValueHandling.Ignore)]
        public string AuctionOrgAddress { get; set; }

        /// <summary>
        /// 二手车经营拍卖单位纳税人识别号。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("auction_org_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AuctionOrgId { get; set; }

        /// <summary>
        /// 二手车经营拍卖单位银行和账号。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("auction_org_bank_account", NullValueHandling = NullValueHandling.Ignore)]
        public string AuctionOrgBankAccount { get; set; }

        /// <summary>
        /// 二手车经营拍卖单位电话。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("auction_org_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string AuctionOrgPhone { get; set; }

        /// <summary>
        /// 二手车市场名称。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("used_vehicle_market_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedVehicleMarketName { get; set; }

        /// <summary>
        /// 二手车市场纳税人识别号。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("used_vehicle_market_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedVehicleMarketId { get; set; }

        /// <summary>
        /// 二手车市场地址。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("used_vehicle_market_address", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedVehicleMarketAddress { get; set; }

        /// <summary>
        /// 二手车市场银行和账号。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("used_vehicle_market_bank_account", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedVehicleMarketBankAccount { get; set; }

        /// <summary>
        /// 二手车市场电话。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("used_vehicle_market_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedVehicleMarketPhone { get; set; }

        /// <summary>
        /// 二手车反向开具标识，True表示是反向开具发票，False表示不是反向开具发票。 当请求参数\&quot;type\&quot;设置为\&quot;auto\&quot;或\&quot;used\&quot;时才返回。 
        /// </summary>
        [JsonProperty("reverse_issue", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReverseIssue { get; set; }

        /// <summary>
        /// 备注 
        /// </summary>
        [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
        public string Remark { get; set; }

        /// <summary>
        /// 开票人 
        /// </summary>
        [JsonProperty("drawer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DrawerName { get; set; }

        /// <summary>
        /// 枚举值，机动车销售统一发票或者二手车销售统一发票。 当入参中包含type时返回。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 检测框对象，内部为字段-框坐标对。如 code:[[x0, y0],[x1,y1],[x2,y2],[x3,y3]], 点的顺序是左上角、右上角、右下角、左下角。如果原图找不到字段，返回空列表。 
        /// </summary>
        [JsonProperty("text_location", NullValueHandling = NullValueHandling.Ignore)]
        public Object TextLocation { get; set; }

        /// <summary>
        /// 字段文字内容置信度，内容为字段-字符置信度对,如code:0.9999。这个数值为字段中每个字符置信度，格式为fp32，保留四位。若字段不存在则返回0.0。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MvsInvoiceResult {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  machinePrintedCode: ").Append(MachinePrintedCode).Append("\n");
            sb.Append("  machinePrintedNumber: ").Append(MachinePrintedNumber).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  machineNumber: ").Append(MachineNumber).Append("\n");
            sb.Append("  buyerName: ").Append(BuyerName).Append("\n");
            sb.Append("  buyerOrganizationNumber: ").Append(BuyerOrganizationNumber).Append("\n");
            sb.Append("  buyerId: ").Append(BuyerId).Append("\n");
            sb.Append("  buyerAddress: ").Append(BuyerAddress).Append("\n");
            sb.Append("  buyerPhone: ").Append(BuyerPhone).Append("\n");
            sb.Append("  sellerName: ").Append(SellerName).Append("\n");
            sb.Append("  sellerPhone: ").Append(SellerPhone).Append("\n");
            sb.Append("  sellerId: ").Append(SellerId).Append("\n");
            sb.Append("  sellerAccount: ").Append(SellerAccount).Append("\n");
            sb.Append("  sellerAddress: ").Append(SellerAddress).Append("\n");
            sb.Append("  licencePlateNumber: ").Append(LicencePlateNumber).Append("\n");
            sb.Append("  registrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  deptMotorVehicles: ").Append(DeptMotorVehicles).Append("\n");
            sb.Append("  sellerBank: ").Append(SellerBank).Append("\n");
            sb.Append("  vehicleType: ").Append(VehicleType).Append("\n");
            sb.Append("  brandModel: ").Append(BrandModel).Append("\n");
            sb.Append("  manufacturingLocation: ").Append(ManufacturingLocation).Append("\n");
            sb.Append("  qualityCertificate: ").Append(QualityCertificate).Append("\n");
            sb.Append("  importCertificate: ").Append(ImportCertificate).Append("\n");
            sb.Append("  inspectionNumber: ").Append(InspectionNumber).Append("\n");
            sb.Append("  engineNumber: ").Append(EngineNumber).Append("\n");
            sb.Append("  vehicleIdentificationNumber: ").Append(VehicleIdentificationNumber).Append("\n");
            sb.Append("  tonnage: ").Append(Tonnage).Append("\n");
            sb.Append("  seatingCapacity: ").Append(SeatingCapacity).Append("\n");
            sb.Append("  taxAuthority: ").Append(TaxAuthority).Append("\n");
            sb.Append("  taxAuthorityCode: ").Append(TaxAuthorityCode).Append("\n");
            sb.Append("  taxPaymentReceipt: ").Append(TaxPaymentReceipt).Append("\n");
            sb.Append("  taxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  tax: ").Append(Tax).Append("\n");
            sb.Append("  taxExclusivePrice: ").Append(TaxExclusivePrice).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  totalChinese: ").Append(TotalChinese).Append("\n");
            sb.Append("  fiscalCode: ").Append(FiscalCode).Append("\n");
            sb.Append("  auctionOrgName: ").Append(AuctionOrgName).Append("\n");
            sb.Append("  auctionOrgAddress: ").Append(AuctionOrgAddress).Append("\n");
            sb.Append("  auctionOrgId: ").Append(AuctionOrgId).Append("\n");
            sb.Append("  auctionOrgBankAccount: ").Append(AuctionOrgBankAccount).Append("\n");
            sb.Append("  auctionOrgPhone: ").Append(AuctionOrgPhone).Append("\n");
            sb.Append("  usedVehicleMarketName: ").Append(UsedVehicleMarketName).Append("\n");
            sb.Append("  usedVehicleMarketId: ").Append(UsedVehicleMarketId).Append("\n");
            sb.Append("  usedVehicleMarketAddress: ").Append(UsedVehicleMarketAddress).Append("\n");
            sb.Append("  usedVehicleMarketBankAccount: ").Append(UsedVehicleMarketBankAccount).Append("\n");
            sb.Append("  usedVehicleMarketPhone: ").Append(UsedVehicleMarketPhone).Append("\n");
            sb.Append("  reverseIssue: ").Append(ReverseIssue).Append("\n");
            sb.Append("  remark: ").Append(Remark).Append("\n");
            sb.Append("  drawerName: ").Append(DrawerName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  textLocation: ").Append(TextLocation).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MvsInvoiceResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MvsInvoiceResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.MachinePrintedCode == input.MachinePrintedCode ||
                    (this.MachinePrintedCode != null &&
                    this.MachinePrintedCode.Equals(input.MachinePrintedCode))
                ) && 
                (
                    this.MachinePrintedNumber == input.MachinePrintedNumber ||
                    (this.MachinePrintedNumber != null &&
                    this.MachinePrintedNumber.Equals(input.MachinePrintedNumber))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.MachineNumber == input.MachineNumber ||
                    (this.MachineNumber != null &&
                    this.MachineNumber.Equals(input.MachineNumber))
                ) && 
                (
                    this.BuyerName == input.BuyerName ||
                    (this.BuyerName != null &&
                    this.BuyerName.Equals(input.BuyerName))
                ) && 
                (
                    this.BuyerOrganizationNumber == input.BuyerOrganizationNumber ||
                    (this.BuyerOrganizationNumber != null &&
                    this.BuyerOrganizationNumber.Equals(input.BuyerOrganizationNumber))
                ) && 
                (
                    this.BuyerId == input.BuyerId ||
                    (this.BuyerId != null &&
                    this.BuyerId.Equals(input.BuyerId))
                ) && 
                (
                    this.BuyerAddress == input.BuyerAddress ||
                    (this.BuyerAddress != null &&
                    this.BuyerAddress.Equals(input.BuyerAddress))
                ) && 
                (
                    this.BuyerPhone == input.BuyerPhone ||
                    (this.BuyerPhone != null &&
                    this.BuyerPhone.Equals(input.BuyerPhone))
                ) && 
                (
                    this.SellerName == input.SellerName ||
                    (this.SellerName != null &&
                    this.SellerName.Equals(input.SellerName))
                ) && 
                (
                    this.SellerPhone == input.SellerPhone ||
                    (this.SellerPhone != null &&
                    this.SellerPhone.Equals(input.SellerPhone))
                ) && 
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) && 
                (
                    this.SellerAccount == input.SellerAccount ||
                    (this.SellerAccount != null &&
                    this.SellerAccount.Equals(input.SellerAccount))
                ) && 
                (
                    this.SellerAddress == input.SellerAddress ||
                    (this.SellerAddress != null &&
                    this.SellerAddress.Equals(input.SellerAddress))
                ) && 
                (
                    this.LicencePlateNumber == input.LicencePlateNumber ||
                    (this.LicencePlateNumber != null &&
                    this.LicencePlateNumber.Equals(input.LicencePlateNumber))
                ) && 
                (
                    this.RegistrationNumber == input.RegistrationNumber ||
                    (this.RegistrationNumber != null &&
                    this.RegistrationNumber.Equals(input.RegistrationNumber))
                ) && 
                (
                    this.DeptMotorVehicles == input.DeptMotorVehicles ||
                    (this.DeptMotorVehicles != null &&
                    this.DeptMotorVehicles.Equals(input.DeptMotorVehicles))
                ) && 
                (
                    this.SellerBank == input.SellerBank ||
                    (this.SellerBank != null &&
                    this.SellerBank.Equals(input.SellerBank))
                ) && 
                (
                    this.VehicleType == input.VehicleType ||
                    (this.VehicleType != null &&
                    this.VehicleType.Equals(input.VehicleType))
                ) && 
                (
                    this.BrandModel == input.BrandModel ||
                    (this.BrandModel != null &&
                    this.BrandModel.Equals(input.BrandModel))
                ) && 
                (
                    this.ManufacturingLocation == input.ManufacturingLocation ||
                    (this.ManufacturingLocation != null &&
                    this.ManufacturingLocation.Equals(input.ManufacturingLocation))
                ) && 
                (
                    this.QualityCertificate == input.QualityCertificate ||
                    (this.QualityCertificate != null &&
                    this.QualityCertificate.Equals(input.QualityCertificate))
                ) && 
                (
                    this.ImportCertificate == input.ImportCertificate ||
                    (this.ImportCertificate != null &&
                    this.ImportCertificate.Equals(input.ImportCertificate))
                ) && 
                (
                    this.InspectionNumber == input.InspectionNumber ||
                    (this.InspectionNumber != null &&
                    this.InspectionNumber.Equals(input.InspectionNumber))
                ) && 
                (
                    this.EngineNumber == input.EngineNumber ||
                    (this.EngineNumber != null &&
                    this.EngineNumber.Equals(input.EngineNumber))
                ) && 
                (
                    this.VehicleIdentificationNumber == input.VehicleIdentificationNumber ||
                    (this.VehicleIdentificationNumber != null &&
                    this.VehicleIdentificationNumber.Equals(input.VehicleIdentificationNumber))
                ) && 
                (
                    this.Tonnage == input.Tonnage ||
                    (this.Tonnage != null &&
                    this.Tonnage.Equals(input.Tonnage))
                ) && 
                (
                    this.SeatingCapacity == input.SeatingCapacity ||
                    (this.SeatingCapacity != null &&
                    this.SeatingCapacity.Equals(input.SeatingCapacity))
                ) && 
                (
                    this.TaxAuthority == input.TaxAuthority ||
                    (this.TaxAuthority != null &&
                    this.TaxAuthority.Equals(input.TaxAuthority))
                ) && 
                (
                    this.TaxAuthorityCode == input.TaxAuthorityCode ||
                    (this.TaxAuthorityCode != null &&
                    this.TaxAuthorityCode.Equals(input.TaxAuthorityCode))
                ) && 
                (
                    this.TaxPaymentReceipt == input.TaxPaymentReceipt ||
                    (this.TaxPaymentReceipt != null &&
                    this.TaxPaymentReceipt.Equals(input.TaxPaymentReceipt))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && 
                (
                    this.TaxExclusivePrice == input.TaxExclusivePrice ||
                    (this.TaxExclusivePrice != null &&
                    this.TaxExclusivePrice.Equals(input.TaxExclusivePrice))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.TotalChinese == input.TotalChinese ||
                    (this.TotalChinese != null &&
                    this.TotalChinese.Equals(input.TotalChinese))
                ) && 
                (
                    this.FiscalCode == input.FiscalCode ||
                    (this.FiscalCode != null &&
                    this.FiscalCode.Equals(input.FiscalCode))
                ) && 
                (
                    this.AuctionOrgName == input.AuctionOrgName ||
                    (this.AuctionOrgName != null &&
                    this.AuctionOrgName.Equals(input.AuctionOrgName))
                ) && 
                (
                    this.AuctionOrgAddress == input.AuctionOrgAddress ||
                    (this.AuctionOrgAddress != null &&
                    this.AuctionOrgAddress.Equals(input.AuctionOrgAddress))
                ) && 
                (
                    this.AuctionOrgId == input.AuctionOrgId ||
                    (this.AuctionOrgId != null &&
                    this.AuctionOrgId.Equals(input.AuctionOrgId))
                ) && 
                (
                    this.AuctionOrgBankAccount == input.AuctionOrgBankAccount ||
                    (this.AuctionOrgBankAccount != null &&
                    this.AuctionOrgBankAccount.Equals(input.AuctionOrgBankAccount))
                ) && 
                (
                    this.AuctionOrgPhone == input.AuctionOrgPhone ||
                    (this.AuctionOrgPhone != null &&
                    this.AuctionOrgPhone.Equals(input.AuctionOrgPhone))
                ) && 
                (
                    this.UsedVehicleMarketName == input.UsedVehicleMarketName ||
                    (this.UsedVehicleMarketName != null &&
                    this.UsedVehicleMarketName.Equals(input.UsedVehicleMarketName))
                ) && 
                (
                    this.UsedVehicleMarketId == input.UsedVehicleMarketId ||
                    (this.UsedVehicleMarketId != null &&
                    this.UsedVehicleMarketId.Equals(input.UsedVehicleMarketId))
                ) && 
                (
                    this.UsedVehicleMarketAddress == input.UsedVehicleMarketAddress ||
                    (this.UsedVehicleMarketAddress != null &&
                    this.UsedVehicleMarketAddress.Equals(input.UsedVehicleMarketAddress))
                ) && 
                (
                    this.UsedVehicleMarketBankAccount == input.UsedVehicleMarketBankAccount ||
                    (this.UsedVehicleMarketBankAccount != null &&
                    this.UsedVehicleMarketBankAccount.Equals(input.UsedVehicleMarketBankAccount))
                ) && 
                (
                    this.UsedVehicleMarketPhone == input.UsedVehicleMarketPhone ||
                    (this.UsedVehicleMarketPhone != null &&
                    this.UsedVehicleMarketPhone.Equals(input.UsedVehicleMarketPhone))
                ) && 
                (
                    this.ReverseIssue == input.ReverseIssue ||
                    (this.ReverseIssue != null &&
                    this.ReverseIssue.Equals(input.ReverseIssue))
                ) && 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
                ) && 
                (
                    this.DrawerName == input.DrawerName ||
                    (this.DrawerName != null &&
                    this.DrawerName.Equals(input.DrawerName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TextLocation == input.TextLocation ||
                    (this.TextLocation != null &&
                    this.TextLocation.Equals(input.TextLocation))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.MachinePrintedCode != null)
                    hashCode = hashCode * 59 + this.MachinePrintedCode.GetHashCode();
                if (this.MachinePrintedNumber != null)
                    hashCode = hashCode * 59 + this.MachinePrintedNumber.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.MachineNumber != null)
                    hashCode = hashCode * 59 + this.MachineNumber.GetHashCode();
                if (this.BuyerName != null)
                    hashCode = hashCode * 59 + this.BuyerName.GetHashCode();
                if (this.BuyerOrganizationNumber != null)
                    hashCode = hashCode * 59 + this.BuyerOrganizationNumber.GetHashCode();
                if (this.BuyerId != null)
                    hashCode = hashCode * 59 + this.BuyerId.GetHashCode();
                if (this.BuyerAddress != null)
                    hashCode = hashCode * 59 + this.BuyerAddress.GetHashCode();
                if (this.BuyerPhone != null)
                    hashCode = hashCode * 59 + this.BuyerPhone.GetHashCode();
                if (this.SellerName != null)
                    hashCode = hashCode * 59 + this.SellerName.GetHashCode();
                if (this.SellerPhone != null)
                    hashCode = hashCode * 59 + this.SellerPhone.GetHashCode();
                if (this.SellerId != null)
                    hashCode = hashCode * 59 + this.SellerId.GetHashCode();
                if (this.SellerAccount != null)
                    hashCode = hashCode * 59 + this.SellerAccount.GetHashCode();
                if (this.SellerAddress != null)
                    hashCode = hashCode * 59 + this.SellerAddress.GetHashCode();
                if (this.LicencePlateNumber != null)
                    hashCode = hashCode * 59 + this.LicencePlateNumber.GetHashCode();
                if (this.RegistrationNumber != null)
                    hashCode = hashCode * 59 + this.RegistrationNumber.GetHashCode();
                if (this.DeptMotorVehicles != null)
                    hashCode = hashCode * 59 + this.DeptMotorVehicles.GetHashCode();
                if (this.SellerBank != null)
                    hashCode = hashCode * 59 + this.SellerBank.GetHashCode();
                if (this.VehicleType != null)
                    hashCode = hashCode * 59 + this.VehicleType.GetHashCode();
                if (this.BrandModel != null)
                    hashCode = hashCode * 59 + this.BrandModel.GetHashCode();
                if (this.ManufacturingLocation != null)
                    hashCode = hashCode * 59 + this.ManufacturingLocation.GetHashCode();
                if (this.QualityCertificate != null)
                    hashCode = hashCode * 59 + this.QualityCertificate.GetHashCode();
                if (this.ImportCertificate != null)
                    hashCode = hashCode * 59 + this.ImportCertificate.GetHashCode();
                if (this.InspectionNumber != null)
                    hashCode = hashCode * 59 + this.InspectionNumber.GetHashCode();
                if (this.EngineNumber != null)
                    hashCode = hashCode * 59 + this.EngineNumber.GetHashCode();
                if (this.VehicleIdentificationNumber != null)
                    hashCode = hashCode * 59 + this.VehicleIdentificationNumber.GetHashCode();
                if (this.Tonnage != null)
                    hashCode = hashCode * 59 + this.Tonnage.GetHashCode();
                if (this.SeatingCapacity != null)
                    hashCode = hashCode * 59 + this.SeatingCapacity.GetHashCode();
                if (this.TaxAuthority != null)
                    hashCode = hashCode * 59 + this.TaxAuthority.GetHashCode();
                if (this.TaxAuthorityCode != null)
                    hashCode = hashCode * 59 + this.TaxAuthorityCode.GetHashCode();
                if (this.TaxPaymentReceipt != null)
                    hashCode = hashCode * 59 + this.TaxPaymentReceipt.GetHashCode();
                if (this.TaxRate != null)
                    hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.TaxExclusivePrice != null)
                    hashCode = hashCode * 59 + this.TaxExclusivePrice.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.TotalChinese != null)
                    hashCode = hashCode * 59 + this.TotalChinese.GetHashCode();
                if (this.FiscalCode != null)
                    hashCode = hashCode * 59 + this.FiscalCode.GetHashCode();
                if (this.AuctionOrgName != null)
                    hashCode = hashCode * 59 + this.AuctionOrgName.GetHashCode();
                if (this.AuctionOrgAddress != null)
                    hashCode = hashCode * 59 + this.AuctionOrgAddress.GetHashCode();
                if (this.AuctionOrgId != null)
                    hashCode = hashCode * 59 + this.AuctionOrgId.GetHashCode();
                if (this.AuctionOrgBankAccount != null)
                    hashCode = hashCode * 59 + this.AuctionOrgBankAccount.GetHashCode();
                if (this.AuctionOrgPhone != null)
                    hashCode = hashCode * 59 + this.AuctionOrgPhone.GetHashCode();
                if (this.UsedVehicleMarketName != null)
                    hashCode = hashCode * 59 + this.UsedVehicleMarketName.GetHashCode();
                if (this.UsedVehicleMarketId != null)
                    hashCode = hashCode * 59 + this.UsedVehicleMarketId.GetHashCode();
                if (this.UsedVehicleMarketAddress != null)
                    hashCode = hashCode * 59 + this.UsedVehicleMarketAddress.GetHashCode();
                if (this.UsedVehicleMarketBankAccount != null)
                    hashCode = hashCode * 59 + this.UsedVehicleMarketBankAccount.GetHashCode();
                if (this.UsedVehicleMarketPhone != null)
                    hashCode = hashCode * 59 + this.UsedVehicleMarketPhone.GetHashCode();
                if (this.ReverseIssue != null)
                    hashCode = hashCode * 59 + this.ReverseIssue.GetHashCode();
                if (this.Remark != null)
                    hashCode = hashCode * 59 + this.Remark.GetHashCode();
                if (this.DrawerName != null)
                    hashCode = hashCode * 59 + this.DrawerName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TextLocation != null)
                    hashCode = hashCode * 59 + this.TextLocation.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
