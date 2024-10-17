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
        [JsonProperty("maximum_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string MaximumCapacity { get; set; }

        /// <summary>
        /// 车辆尺寸。 
        /// </summary>
        [JsonProperty("vehicle_size", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleSize { get; set; }

        /// <summary>
        /// 核发机关。 
        /// </summary>
        [JsonProperty("issuing_authority", NullValueHandling = NullValueHandling.Ignore)]
        public string IssuingAuthority { get; set; }

        /// <summary>
        /// 发证日期。 
        /// </summary>
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 业户地址。 
        /// </summary>
        [JsonProperty("owner_address", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerAddress { get; set; }

        /// <summary>
        /// 经济类型。 
        /// </summary>
        [JsonProperty("economic_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EconomicType { get; set; }

        /// <summary>
        /// 经营许可证号。 
        /// </summary>
        [JsonProperty("business_certificate", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessCertificate { get; set; }

        /// <summary>
        /// 经营范围。 
        /// </summary>
        [JsonProperty("business_scope", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessScope { get; set; }

        /// <summary>
        /// 有效期。 
        /// </summary>
        [JsonProperty("expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// 审验有效期。 
        /// </summary>
        [JsonProperty("review_expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewExpiryDate { get; set; }

        /// <summary>
        /// 技术等级评定。 
        /// </summary>
        [JsonProperty("assessed_technical_level", NullValueHandling = NullValueHandling.Ignore)]
        public string AssessedTechnicalLevel { get; set; }

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
            sb.Append("  maximumCapacity: ").Append(MaximumCapacity).Append("\n");
            sb.Append("  vehicleSize: ").Append(VehicleSize).Append("\n");
            sb.Append("  issuingAuthority: ").Append(IssuingAuthority).Append("\n");
            sb.Append("  issueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  ownerAddress: ").Append(OwnerAddress).Append("\n");
            sb.Append("  economicType: ").Append(EconomicType).Append("\n");
            sb.Append("  businessCertificate: ").Append(BusinessCertificate).Append("\n");
            sb.Append("  businessScope: ").Append(BusinessScope).Append("\n");
            sb.Append("  expiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  reviewExpiryDate: ").Append(ReviewExpiryDate).Append("\n");
            sb.Append("  assessedTechnicalLevel: ").Append(AssessedTechnicalLevel).Append("\n");
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
            if (input == null) return false;
            if (this.OwnerName != input.OwnerName || (this.OwnerName != null && !this.OwnerName.Equals(input.OwnerName))) return false;
            if (this.LicenseNumber != input.LicenseNumber || (this.LicenseNumber != null && !this.LicenseNumber.Equals(input.LicenseNumber))) return false;
            if (this.VehicleNumber != input.VehicleNumber || (this.VehicleNumber != null && !this.VehicleNumber.Equals(input.VehicleNumber))) return false;
            if (this.VehicleType != input.VehicleType || (this.VehicleType != null && !this.VehicleType.Equals(input.VehicleType))) return false;
            if (this.MaximumCapacity != input.MaximumCapacity || (this.MaximumCapacity != null && !this.MaximumCapacity.Equals(input.MaximumCapacity))) return false;
            if (this.VehicleSize != input.VehicleSize || (this.VehicleSize != null && !this.VehicleSize.Equals(input.VehicleSize))) return false;
            if (this.IssuingAuthority != input.IssuingAuthority || (this.IssuingAuthority != null && !this.IssuingAuthority.Equals(input.IssuingAuthority))) return false;
            if (this.IssueDate != input.IssueDate || (this.IssueDate != null && !this.IssueDate.Equals(input.IssueDate))) return false;
            if (this.OwnerAddress != input.OwnerAddress || (this.OwnerAddress != null && !this.OwnerAddress.Equals(input.OwnerAddress))) return false;
            if (this.EconomicType != input.EconomicType || (this.EconomicType != null && !this.EconomicType.Equals(input.EconomicType))) return false;
            if (this.BusinessCertificate != input.BusinessCertificate || (this.BusinessCertificate != null && !this.BusinessCertificate.Equals(input.BusinessCertificate))) return false;
            if (this.BusinessScope != input.BusinessScope || (this.BusinessScope != null && !this.BusinessScope.Equals(input.BusinessScope))) return false;
            if (this.ExpiryDate != input.ExpiryDate || (this.ExpiryDate != null && !this.ExpiryDate.Equals(input.ExpiryDate))) return false;
            if (this.ReviewExpiryDate != input.ReviewExpiryDate || (this.ReviewExpiryDate != null && !this.ReviewExpiryDate.Equals(input.ReviewExpiryDate))) return false;
            if (this.AssessedTechnicalLevel != input.AssessedTechnicalLevel || (this.AssessedTechnicalLevel != null && !this.AssessedTechnicalLevel.Equals(input.AssessedTechnicalLevel))) return false;
            if (this.Confidence != input.Confidence || (this.Confidence != null && !this.Confidence.Equals(input.Confidence))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.OwnerName != null) hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.LicenseNumber != null) hashCode = hashCode * 59 + this.LicenseNumber.GetHashCode();
                if (this.VehicleNumber != null) hashCode = hashCode * 59 + this.VehicleNumber.GetHashCode();
                if (this.VehicleType != null) hashCode = hashCode * 59 + this.VehicleType.GetHashCode();
                if (this.MaximumCapacity != null) hashCode = hashCode * 59 + this.MaximumCapacity.GetHashCode();
                if (this.VehicleSize != null) hashCode = hashCode * 59 + this.VehicleSize.GetHashCode();
                if (this.IssuingAuthority != null) hashCode = hashCode * 59 + this.IssuingAuthority.GetHashCode();
                if (this.IssueDate != null) hashCode = hashCode * 59 + this.IssueDate.GetHashCode();
                if (this.OwnerAddress != null) hashCode = hashCode * 59 + this.OwnerAddress.GetHashCode();
                if (this.EconomicType != null) hashCode = hashCode * 59 + this.EconomicType.GetHashCode();
                if (this.BusinessCertificate != null) hashCode = hashCode * 59 + this.BusinessCertificate.GetHashCode();
                if (this.BusinessScope != null) hashCode = hashCode * 59 + this.BusinessScope.GetHashCode();
                if (this.ExpiryDate != null) hashCode = hashCode * 59 + this.ExpiryDate.GetHashCode();
                if (this.ReviewExpiryDate != null) hashCode = hashCode * 59 + this.ReviewExpiryDate.GetHashCode();
                if (this.AssessedTechnicalLevel != null) hashCode = hashCode * 59 + this.AssessedTechnicalLevel.GetHashCode();
                if (this.Confidence != null) hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                return hashCode;
            }
        }
    }
}
