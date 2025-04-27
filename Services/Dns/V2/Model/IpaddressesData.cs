using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IpaddressesData 
    {

        /// <summary>
        /// 资源状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 终端节点的ID，UUID形式的一个资源标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// IP地址信息。
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 创建时间。 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间。 格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSS。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 子网ID。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpaddressesData {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpaddressesData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpaddressesData input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.ErrorInfo != input.ErrorInfo || (this.ErrorInfo != null && !this.ErrorInfo.Equals(input.ErrorInfo))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.ErrorInfo != null) hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
