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
    /// EIP 数量查询反馈
    /// </summary>
    public class EipCountRespData 
    {

        /// <summary>
        /// 防护对象id，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用查询防火墙实例接口获得，注意type为0的为互联网边界防护对象id，type为1的为VPC边界防护对象id。具体可参考APIExlorer和帮助中心FAQ。
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// EIP总数
        /// </summary>
        [JsonProperty("eip_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipTotal { get; set; }

        /// <summary>
        /// 该账号下所有墙防护EIP总数量
        /// </summary>
        [JsonProperty("eip_protected", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipProtected { get; set; }

        /// <summary>
        /// 该当前防火墙防护EIP数量
        /// </summary>
        [JsonProperty("eip_protected_self", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipProtectedSelf { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EipCountRespData {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  eipTotal: ").Append(EipTotal).Append("\n");
            sb.Append("  eipProtected: ").Append(EipProtected).Append("\n");
            sb.Append("  eipProtectedSelf: ").Append(EipProtectedSelf).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EipCountRespData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EipCountRespData input)
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
                    this.EipTotal == input.EipTotal ||
                    (this.EipTotal != null &&
                    this.EipTotal.Equals(input.EipTotal))
                ) && 
                (
                    this.EipProtected == input.EipProtected ||
                    (this.EipProtected != null &&
                    this.EipProtected.Equals(input.EipProtected))
                ) && 
                (
                    this.EipProtectedSelf == input.EipProtectedSelf ||
                    (this.EipProtectedSelf != null &&
                    this.EipProtectedSelf.Equals(input.EipProtectedSelf))
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
                if (this.EipTotal != null)
                    hashCode = hashCode * 59 + this.EipTotal.GetHashCode();
                if (this.EipProtected != null)
                    hashCode = hashCode * 59 + this.EipProtected.GetHashCode();
                if (this.EipProtectedSelf != null)
                    hashCode = hashCode * 59 + this.EipProtectedSelf.GetHashCode();
                return hashCode;
            }
        }
    }
}
