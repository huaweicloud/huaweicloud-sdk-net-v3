using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MasterEIPResponseSpecSpec 
    {

        /// <summary>
        /// 弹性网卡ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("eip", NullValueHandling = NullValueHandling.Ignore)]
        public EipSpec Eip { get; set; }

        /// <summary>
        /// 是否动态创建
        /// </summary>
        [JsonProperty("IsDynamic", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDynamic { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MasterEIPResponseSpecSpec {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  eip: ").Append(Eip).Append("\n");
            sb.Append("  isDynamic: ").Append(IsDynamic).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MasterEIPResponseSpecSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MasterEIPResponseSpecSpec input)
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
                    this.Eip == input.Eip ||
                    (this.Eip != null &&
                    this.Eip.Equals(input.Eip))
                ) && 
                (
                    this.IsDynamic == input.IsDynamic ||
                    (this.IsDynamic != null &&
                    this.IsDynamic.Equals(input.IsDynamic))
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
                if (this.Eip != null)
                    hashCode = hashCode * 59 + this.Eip.GetHashCode();
                if (this.IsDynamic != null)
                    hashCode = hashCode * 59 + this.IsDynamic.GetHashCode();
                return hashCode;
            }
        }
    }
}
