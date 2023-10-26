using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class WorkFlowModel 
    {

        /// <summary>
        /// 英文描述
        /// </summary>
        [JsonProperty("en-us", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> EnUs { get; set; }

        /// <summary>
        /// 中文描述
        /// </summary>
        [JsonProperty("zh-cn", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ZhCn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkFlowModel {\n");
            sb.Append("  enUs: ").Append(EnUs).Append("\n");
            sb.Append("  zhCn: ").Append(ZhCn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkFlowModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkFlowModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnUs == input.EnUs ||
                    this.EnUs != null &&
                    input.EnUs != null &&
                    this.EnUs.SequenceEqual(input.EnUs)
                ) && 
                (
                    this.ZhCn == input.ZhCn ||
                    this.ZhCn != null &&
                    input.ZhCn != null &&
                    this.ZhCn.SequenceEqual(input.ZhCn)
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
                if (this.EnUs != null)
                    hashCode = hashCode * 59 + this.EnUs.GetHashCode();
                if (this.ZhCn != null)
                    hashCode = hashCode * 59 + this.ZhCn.GetHashCode();
                return hashCode;
            }
        }
    }
}
