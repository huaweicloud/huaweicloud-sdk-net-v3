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
    /// 共享带宽批量加入弹性公网IP请求参数
    /// </summary>
    public class BatchAttachSharebwReq 
    {

        /// <summary>
        /// - 功能说明：共享带宽数据 - 约束：共享带宽批量加入多个弹性公网IP时，请求参数publicips中的bandwidth_id必须为同一个共享带宽的id
        /// </summary>
        [JsonProperty("publicips", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchAttachSharebwDict> Publicips { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAttachSharebwReq {\n");
            sb.Append("  publicips: ").Append(Publicips).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAttachSharebwReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAttachSharebwReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Publicips == input.Publicips ||
                    this.Publicips != null &&
                    input.Publicips != null &&
                    this.Publicips.SequenceEqual(input.Publicips)
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
                if (this.Publicips != null)
                    hashCode = hashCode * 59 + this.Publicips.GetHashCode();
                return hashCode;
            }
        }
    }
}
