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
        /// 购买方名称。 
        /// </summary>
        [JsonProperty("buyer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerName { get; set; }

        /// <summary>
        /// 购买方身份证号码/组织机构代码。 
        /// </summary>
        [JsonProperty("buyer_organization_number", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerOrganizationNumber { get; set; }

        /// <summary>
        /// 购买方纳税人识别号。 
        /// </summary>
        [JsonProperty("buyer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuyerId { get; set; }

        /// <summary>
        /// 销货单位名称。 
        /// </summary>
        [JsonProperty("seller_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerName { get; set; }

        /// <summary>
        /// 销售方电话。 
        /// </summary>
        [JsonProperty("seller_phone", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerPhone { get; set; }

        /// <summary>
        /// 销售方纳税人识别号。 
        /// </summary>
        [JsonProperty("seller_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerId { get; set; }

        /// <summary>
        /// 销售方账号。 
        /// </summary>
        [JsonProperty("seller_account", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerAccount { get; set; }

        /// <summary>
        /// 销售方地址。 
        /// </summary>
        [JsonProperty("seller_address", NullValueHandling = NullValueHandling.Ignore)]
        public string SellerAddress { get; set; }

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
        /// 价税合计。 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public string Total { get; set; }

        /// <summary>
        /// 价税合计大写。 
        /// </summary>
        [JsonProperty("total_chinese", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalChinese { get; set; }

        /// <summary>
        /// 税控码。 
        /// </summary>
        [JsonProperty("fiscal_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FiscalCode { get; set; }


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
            sb.Append("  sellerName: ").Append(SellerName).Append("\n");
            sb.Append("  sellerPhone: ").Append(SellerPhone).Append("\n");
            sb.Append("  sellerId: ").Append(SellerId).Append("\n");
            sb.Append("  sellerAccount: ").Append(SellerAccount).Append("\n");
            sb.Append("  sellerAddress: ").Append(SellerAddress).Append("\n");
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
                return hashCode;
            }
        }
    }
}
