using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowWebHookConfigRequest 
    {

        /// <summary>
        /// 企业ID。按企业注册回调时需要填写。
        /// </summary>
        [SDKProperty("corpId", IsQuery = true)]
        [JsonProperty("corpId", NullValueHandling = NullValueHandling.Ignore)]
        public string CorpId { get; set; }

        /// <summary>
        /// SP ID。多租户场景下，按SP注册回调时需要填写。
        /// </summary>
        [SDKProperty("spId", IsQuery = true)]
        [JsonProperty("spId", NullValueHandling = NullValueHandling.Ignore)]
        public string SpId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowWebHookConfigRequest {\n");
            sb.Append("  corpId: ").Append(CorpId).Append("\n");
            sb.Append("  spId: ").Append(SpId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWebHookConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWebHookConfigRequest input)
        {
            if (input == null) return false;
            if (this.CorpId != input.CorpId || (this.CorpId != null && !this.CorpId.Equals(input.CorpId))) return false;
            if (this.SpId != input.SpId || (this.SpId != null && !this.SpId.Equals(input.SpId))) return false;

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
                if (this.CorpId != null) hashCode = hashCode * 59 + this.CorpId.GetHashCode();
                if (this.SpId != null) hashCode = hashCode * 59 + this.SpId.GetHashCode();
                return hashCode;
            }
        }
    }
}
