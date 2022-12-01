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
        /// 防护对象ID
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// EIP总数
        /// </summary>
        [JsonProperty("eip_total", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipTotal { get; set; }

        /// <summary>
        /// EIP防护数
        /// </summary>
        [JsonProperty("eip_protected", NullValueHandling = NullValueHandling.Ignore)]
        public int? EipProtected { get; set; }


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
                return hashCode;
            }
        }
    }
}
