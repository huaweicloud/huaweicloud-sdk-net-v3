using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class InspectionReports 
    {

        /// <summary>
        /// 检查报告ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 检查时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [JsonProperty("check_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CheckTime { get; set; }

        /// <summary>
        /// 到期时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如偏移1个小时显示为+0100。
        /// </summary>
        [JsonProperty("expiration_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationTime { get; set; }

        /// <summary>
        /// 目标版本。
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// 检查结果。 success，表示成功。 failed，表示失败。 running， 表示检查中。
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 检查报告详情。
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InspectionReports {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  checkTime: ").Append(CheckTime).Append("\n");
            sb.Append("  expirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InspectionReports);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InspectionReports input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CheckTime == input.CheckTime ||
                    (this.CheckTime != null &&
                    this.CheckTime.Equals(input.CheckTime))
                ) && 
                (
                    this.ExpirationTime == input.ExpirationTime ||
                    (this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(input.ExpirationTime))
                ) && 
                (
                    this.TargetVersion == input.TargetVersion ||
                    (this.TargetVersion != null &&
                    this.TargetVersion.Equals(input.TargetVersion))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CheckTime != null)
                    hashCode = hashCode * 59 + this.CheckTime.GetHashCode();
                if (this.ExpirationTime != null)
                    hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                if (this.TargetVersion != null)
                    hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
                return hashCode;
            }
        }
    }
}
