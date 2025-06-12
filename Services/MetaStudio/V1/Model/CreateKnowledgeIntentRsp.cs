using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 创建知识库意图响应。
    /// </summary>
    public class CreateKnowledgeIntentRsp 
    {

        /// <summary>
        /// 意图ID。
        /// </summary>
        [JsonProperty("intent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IntentId { get; set; }

        /// <summary>
        /// 意图标识。
        /// </summary>
        [JsonProperty("identify", NullValueHandling = NullValueHandling.Ignore)]
        public string Identify { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateKnowledgeIntentRsp {\n");
            sb.Append("  intentId: ").Append(IntentId).Append("\n");
            sb.Append("  identify: ").Append(Identify).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateKnowledgeIntentRsp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateKnowledgeIntentRsp input)
        {
            if (input == null) return false;
            if (this.IntentId != input.IntentId || (this.IntentId != null && !this.IntentId.Equals(input.IntentId))) return false;
            if (this.Identify != input.Identify || (this.Identify != null && !this.Identify.Equals(input.Identify))) return false;

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
                if (this.IntentId != null) hashCode = hashCode * 59 + this.IntentId.GetHashCode();
                if (this.Identify != null) hashCode = hashCode * 59 + this.Identify.GetHashCode();
                return hashCode;
            }
        }
    }
}
