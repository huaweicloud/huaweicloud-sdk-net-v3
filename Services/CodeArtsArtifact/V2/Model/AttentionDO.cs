using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AttentionDO 
    {

        /// <summary>
        /// 关注/取消关注
        /// </summary>
        [JsonProperty("attention", NullValueHandling = NullValueHandling.Ignore)]
        public string Attention { get; set; }

        /// <summary>
        /// 组件id列表
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// 格式
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttentionDO {\n");
            sb.Append("  attention: ").Append(Attention).Append("\n");
            sb.Append("  ids: ").Append(Ids).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttentionDO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttentionDO input)
        {
            if (input == null) return false;
            if (this.Attention != input.Attention || (this.Attention != null && !this.Attention.Equals(input.Attention))) return false;
            if (this.Ids != input.Ids || (this.Ids != null && input.Ids != null && !this.Ids.SequenceEqual(input.Ids))) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;

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
                if (this.Attention != null) hashCode = hashCode * 59 + this.Attention.GetHashCode();
                if (this.Ids != null) hashCode = hashCode * 59 + this.Ids.GetHashCode();
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                return hashCode;
            }
        }
    }
}
