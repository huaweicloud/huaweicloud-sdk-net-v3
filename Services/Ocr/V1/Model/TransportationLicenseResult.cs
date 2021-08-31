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
    public class TransportationLicenseResult 
    {

        /// <summary>
        /// 业户名称。 
        /// </summary>
        [JsonProperty("owner_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 道路运输证号。 
        /// </summary>
        [JsonProperty("license_number", NullValueHandling = NullValueHandling.Ignore)]
        public string LicenseNumber { get; set; }

        /// <summary>
        /// 车辆号牌。 
        /// </summary>
        [JsonProperty("vehicle_number", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleNumber { get; set; }

        /// <summary>
        /// 车辆类型。 
        /// </summary>
        [JsonProperty("vehicle_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleType { get; set; }

        /// <summary>
        /// 吨(座)位。 
        /// </summary>
        [JsonProperty("vehicle_weight", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleWeight { get; set; }

        /// <summary>
        /// 车辆尺寸。 
        /// </summary>
        [JsonProperty("vehicle_size", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleSize { get; set; }

        /// <summary>
        /// 核发机关（非必有，依赖对应运输证板式）。 
        /// </summary>
        [JsonProperty("issuing_authority", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuingAuthority { get; set; }

        /// <summary>
        /// 签发日期（非必有，依赖对应运输证板式）。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 业户地址（非必有，依赖对应运输证板式）。 
        /// </summary>
        [JsonProperty("owner_address", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerAddress { get; set; }

        /// <summary>
        /// 经济类型（非必有，依赖对应运输证板式）。 
        /// </summary>
        [JsonProperty("economic_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EconomicType { get; set; }

        /// <summary>
        /// 经营许可证号（非必有，依赖对应运输证板式）。 
        /// </summary>
        [JsonProperty("business_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessCertificate { get; set; }

        /// <summary>
        /// 道路普通货物运输（非必有，依赖对应运输证板式）。 
        /// </summary>
        [JsonProperty("business_scope", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessScope { get; set; }

        /// <summary>
        /// 相关字段的置信度信息，置信度越大，表示本次识别的对应字段的可靠性越高，在统计意义上，置信度越大，准确率越高。 置信度由算法给出，不直接等价于对应字段的准确率。 
        /// </summary>
        [JsonProperty("confidence", NullValueHandling = NullValueHandling.Ignore)]
        public Object Confidence { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransportationLicenseResult {\n");
            sb.Append("  ownerName: ").Append(OwnerName).Append("\n");
            sb.Append("  licenseNumber: ").Append(LicenseNumber).Append("\n");
            sb.Append("  vehicleNumber: ").Append(VehicleNumber).Append("\n");
            sb.Append("  vehicleType: ").Append(VehicleType).Append("\n");
            sb.Append("  vehicleWeight: ").Append(VehicleWeight).Append("\n");
            sb.Append("  vehicleSize: ").Append(VehicleSize).Append("\n");
            sb.Append("  issuingAuthority: ").Append(IssuingAuthority).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  ownerAddress: ").Append(OwnerAddress).Append("\n");
            sb.Append("  economicType: ").Append(EconomicType).Append("\n");
            sb.Append("  businessCertificate: ").Append(BusinessCertificate).Append("\n");
            sb.Append("  businessScope: ").Append(BusinessScope).Append("\n");
            sb.Append("  confidence: ").Append(Confidence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransportationLicenseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransportationLicenseResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.LicenseNumber == input.LicenseNumber ||
                    (this.LicenseNumber != null &&
                    this.LicenseNumber.Equals(input.LicenseNumber))
                ) && 
                (
                    this.VehicleNumber == input.VehicleNumber ||
                    (this.VehicleNumber != null &&
                    this.VehicleNumber.Equals(input.VehicleNumber))
                ) && 
                (
                    this.VehicleType == input.VehicleType ||
                    (this.VehicleType != null &&
                    this.VehicleType.Equals(input.VehicleType))
                ) && 
                (
                    this.VehicleWeight == input.VehicleWeight ||
                    (this.VehicleWeight != null &&
                    this.VehicleWeight.Equals(input.VehicleWeight))
                ) && 
                (
                    this.VehicleSize == input.VehicleSize ||
                    (this.VehicleSize != null &&
                    this.VehicleSize.Equals(input.VehicleSize))
                ) && 
                (
                    this.IssuingAuthority == input.IssuingAuthority ||
                    (this.IssuingAuthority != null &&
                    this.IssuingAuthority.Equals(input.IssuingAuthority))
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.OwnerAddress == input.OwnerAddress ||
                    (this.OwnerAddress != null &&
                    this.OwnerAddress.Equals(input.OwnerAddress))
                ) && 
                (
                    this.EconomicType == input.EconomicType ||
                    (this.EconomicType != null &&
                    this.EconomicType.Equals(input.EconomicType))
                ) && 
                (
                    this.BusinessCertificate == input.BusinessCertificate ||
                    (this.BusinessCertificate != null &&
                    this.BusinessCertificate.Equals(input.BusinessCertificate))
                ) && 
                (
                    this.BusinessScope == input.BusinessScope ||
                    (this.BusinessScope != null &&
                    this.BusinessScope.Equals(input.BusinessScope))
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
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.LicenseNumber != null)
                    hashCode = hashCode * 59 + this.LicenseNumber.GetHashCode();
                if (this.VehicleNumber != null)
                    hashCode = hashCode * 59 + this.VehicleNumber.GetHashCode();
                if (this.VehicleType != null)
                    hashCode = hashCode * 59 + this.VehicleType.GetHashCode();
                if (this.VehicleWeight != null)
                    hashCode = hashCode * 59 + this.VehicleWeight.GetHashCode();
                if (this.VehicleSize != null)
                    hashCode = hashCode * 59 + this.VehicleSize.GetHashCode();
                if (this.IssuingAuthority != null)
                    hashCode = hashCode * 59 + this.IssuingAuthority.GetHashCode();
                if (this.IssueDate != null)
                    hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.OwnerAddress != null)
                    hashCode = hashCode * 59 + this.OwnerAddress.GetHashCode();
                if (this.EconomicType != null)
                    hashCode = hashCode * 59 + this.EconomicType.GetHashCode();
                if (this.BusinessCertificate != null)
                    hashCode = hashCode * 59 + this.BusinessCertificate.GetHashCode();
                if (this.BusinessScope != null)
                    hashCode = hashCode * 59 + this.BusinessScope.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
