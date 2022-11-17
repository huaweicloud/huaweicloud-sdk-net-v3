using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// EIP操作防护请求体
    /// </summary>
    public class EipOperateProtectReq 
    {

        /// <summary>
        /// 防护对象ID
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// EIP状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// EIP信息列表
        /// </summary>
        [JsonProperty("ip_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<EipOperateProtectReqIpInfos> IpInfos { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EipOperateProtectReq {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  ipInfos: ").Append(IpInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EipOperateProtectReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EipOperateProtectReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.IpInfos == input.IpInfos ||
                    this.IpInfos != null &&
                    input.IpInfos != null &&
                    this.IpInfos.SequenceEqual(input.IpInfos)
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
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IpInfos != null)
                    hashCode = hashCode * 59 + this.IpInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
