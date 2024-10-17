using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 共享带宽批量移出弹性公网IP请求参数
    /// </summary>
    public class DetachBatchSharedbwReq 
    {

        /// <summary>
        /// 共享带宽批量移出弹性公网IP请求对象
        /// </summary>
        [JsonProperty("publicips", NullValueHandling = NullValueHandling.Ignore)]
        public List<DetachBatchSharedbwReqPublicips> Publicips { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetachBatchSharedbwReq {\n");
            sb.Append("  publicips: ").Append(Publicips).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetachBatchSharedbwReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetachBatchSharedbwReq input)
        {
            if (input == null) return false;
            if (this.Publicips != input.Publicips || (this.Publicips != null && input.Publicips != null && !this.Publicips.SequenceEqual(input.Publicips))) return false;

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
                if (this.Publicips != null) hashCode = hashCode * 59 + this.Publicips.GetHashCode();
                return hashCode;
            }
        }
    }
}
