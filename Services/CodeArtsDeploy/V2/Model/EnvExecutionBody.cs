using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 应用启动参数
    /// </summary>
    public class EnvExecutionBody 
    {

        /// <summary>
        /// 部署应用时传递的参数
        /// </summary>
        [JsonProperty("params", NullValueHandling = NullValueHandling.Ignore)]
        public List<DynamicConfigInfo> Params { get; set; }

        /// <summary>
        /// 应用的部署id，可通过record_id回滚至之前的部署状态。选中应用历史部署记录，在URL中获取
        /// </summary>
        [JsonProperty("record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordId { get; set; }

        /// <summary>
        /// 限制触发来源，0不限制任何部署请求来源，1时只允许通过流水线触发部署
        /// </summary>
        [JsonProperty("trigger_source", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerSource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvExecutionBody {\n");
            sb.Append("  Params: ").Append(Params).Append("\n");
            sb.Append("  recordId: ").Append(RecordId).Append("\n");
            sb.Append("  triggerSource: ").Append(TriggerSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnvExecutionBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnvExecutionBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Params == input.Params ||
                    this.Params != null &&
                    input.Params != null &&
                    this.Params.SequenceEqual(input.Params)
                ) && 
                (
                    this.RecordId == input.RecordId ||
                    (this.RecordId != null &&
                    this.RecordId.Equals(input.RecordId))
                ) && 
                (
                    this.TriggerSource == input.TriggerSource ||
                    (this.TriggerSource != null &&
                    this.TriggerSource.Equals(input.TriggerSource))
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
                if (this.Params != null)
                    hashCode = hashCode * 59 + this.Params.GetHashCode();
                if (this.RecordId != null)
                    hashCode = hashCode * 59 + this.RecordId.GetHashCode();
                if (this.TriggerSource != null)
                    hashCode = hashCode * 59 + this.TriggerSource.GetHashCode();
                return hashCode;
            }
        }
    }
}
